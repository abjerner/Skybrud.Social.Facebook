using Skybrud.Social.Facebook.Objects.Posts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Posts {

    public class FacebookPostResponse : FacebookResponse<FacebookPost> {

        #region Constructors

        private FacebookPostResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPost.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookPostResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookPostResponse(response);
        }

        #endregion

    }

}