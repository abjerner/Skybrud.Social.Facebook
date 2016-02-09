using Skybrud.Social.Facebook.Objects.Comments;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Comments {

    /// <summary>
    /// Class representing a response of a call to get information about a single Facebook comment.
    /// </summary>
    public class FacebookGetCommentResponse : FacebookResponse<FacebookComment> {

        #region Constructors

        private FacebookGetCommentResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookComment.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetCommentResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetCommentResponse"/> representing the response.</returns>
        public static FacebookGetCommentResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetCommentResponse(response);
        }

        #endregion

    }

}