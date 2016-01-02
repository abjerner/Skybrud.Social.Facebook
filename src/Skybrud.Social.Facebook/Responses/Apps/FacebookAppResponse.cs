using Skybrud.Social.Facebook.Objects.Apps;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Apps {

    public class FacebookAppResponse : FacebookResponse<FacebookApp> {

        #region Constructors

        private FacebookAppResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookApp.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookAppResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookAppResponse(response);
        }

        #endregion

    }

}