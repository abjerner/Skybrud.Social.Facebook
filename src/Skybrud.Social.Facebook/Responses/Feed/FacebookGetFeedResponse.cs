using Skybrud.Social.Facebook.Objects.Feed;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Feed {

    public class FacebookGetFeedResponse : FacebookResponse<FacebookFeedCollection> {

        #region Constructors

        private FacebookGetFeedResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookFeedCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookGetFeedResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetFeedResponse(response);
        }

        #endregion

    }

}