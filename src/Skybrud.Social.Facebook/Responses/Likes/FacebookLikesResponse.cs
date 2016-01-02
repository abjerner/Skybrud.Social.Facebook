using Skybrud.Social.Facebook.Objects.Likes;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Likes {

    public class FacebookLikesResponse : FacebookResponse<FacebookLikesCollection> {

        #region Constructors

        private FacebookLikesResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookLikesCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookLikesResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookLikesResponse(response);
        }

        #endregion

    }

}