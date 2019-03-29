using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Comments;

namespace Skybrud.Social.Facebook.Responses.Comments {

    /// <summary>
    /// Class representing a response of a request to get information about a single <see cref="FacebookComment"/>.
    /// </summary>
    public class FacebookGetCommentResponse : FacebookResponse<FacebookComment> {

        #region Constructors

        private FacebookGetCommentResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookComment.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of
        /// <see cref="FacebookGetCommentResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetCommentResponse"/> representing the response.</returns>
        public static FacebookGetCommentResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new FacebookGetCommentResponse(response);
        }

        #endregion

    }

}