using Skybrud.Social.Facebook.Objects.Users;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Users {

    /// <summary>
    /// Class representing a response of a call to get information about a user.
    /// </summary>
    public class FacebookGetUserResponse : FacebookResponse<FacebookUser> {

        #region Constructors

        private FacebookGetUserResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookUser.Parse);

        }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetUserResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetUserResponse"/> representing the response.</returns>
        public static FacebookGetUserResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetUserResponse(response);
        }

        #endregion

    }

}