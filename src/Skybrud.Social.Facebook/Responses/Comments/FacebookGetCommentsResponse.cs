using Skybrud.Social.Facebook.Objects.Comments;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Comments {

    public class FacebookGetCommentsResponse : FacebookResponse<FacebookCommentsCollection> {

        #region Constructors

        private FacebookGetCommentsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookCommentsCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookGetCommentsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetCommentsResponse(response);
        }

        #endregion

    }

}