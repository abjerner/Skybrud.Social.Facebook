using Skybrud.Social.Facebook.Objects.Comments;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Comments {

    public class FacebookCommentsResponse : FacebookResponse<FacebookCommentsCollection> {

        // TODO: Rename to "FacebookGetCommentsResponse" in v1.0

        #region Constructors

        private FacebookCommentsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookCommentsCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookCommentsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookCommentsResponse(response);
        }

        #endregion

    }

}