using Skybrud.Social.Facebook.Objects.Comments;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Comments {

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

        public static FacebookGetCommentResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetCommentResponse(response);
        }

        #endregion

    }

}