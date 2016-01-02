using Skybrud.Social.Facebook.Objects.Comments;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Comments {

    public class FacebookCommentResponse : FacebookResponse<FacebookComment> {

        // TODO: Rename to "FacebookGetCommentResponse" in v1.0

        #region Constructors

        private FacebookCommentResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookComment.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookCommentResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookCommentResponse(response);
        }

        #endregion

    }

}