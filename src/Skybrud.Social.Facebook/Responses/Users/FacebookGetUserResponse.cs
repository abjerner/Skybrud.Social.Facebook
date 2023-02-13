using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Users;

namespace Skybrud.Social.Facebook.Responses.Users {

    /// <summary>
    /// Class representing a response of a call to get information about a <see cref="FacebookUser"/>.
    /// </summary>
    public class FacebookGetUserResponse : FacebookResponse<FacebookUser> {

        #region Constructors

        private FacebookGetUserResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookUser.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookGetUserResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetUserResponse"/> representing the response.</returns>
        public static FacebookGetUserResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new FacebookGetUserResponse(response);
        }

        #endregion

    }

}