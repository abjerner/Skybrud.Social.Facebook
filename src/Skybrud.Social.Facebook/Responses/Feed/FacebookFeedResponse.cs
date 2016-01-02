using Skybrud.Social.Facebook.Objects.Feed;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Feed {

    public class FacebookFeedResponse : FacebookResponse<FacebookFeedCollection> {

        #region Constructors

        private FacebookFeedResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookFeedCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookFeedResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookFeedResponse(response);
        }

        #endregion

    }

}