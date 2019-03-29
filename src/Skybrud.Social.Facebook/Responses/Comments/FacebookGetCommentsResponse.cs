using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Comments;

namespace Skybrud.Social.Facebook.Responses.Comments {

    /// <summary>
    /// Class representing a response of a request to get a collection of <see cref="FacebookComment"/> of a given
    /// Facebook object.
    /// </summary>
    public class FacebookGetCommentsResponse : FacebookResponse<FacebookCommentsCollection> {

        #region Constructors

        private FacebookGetCommentsResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookCommentsCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of
        /// <see cref="FacebookGetCommentsResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetCommentsResponse"/> representing the response.</returns>
        public static FacebookGetCommentsResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new FacebookGetCommentsResponse(response);
        }

        #endregion

    }

}