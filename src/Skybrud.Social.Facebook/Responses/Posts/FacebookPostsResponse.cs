using Skybrud.Social.Facebook.Objects.Posts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Posts {

    public class FacebookPostsResponse : FacebookResponse<FacebookPostsCollection> {

        #region Constructors

        private FacebookPostsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPostsCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookPostsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookPostsResponse(response);
        }

        #endregion

    }

}