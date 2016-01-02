using Skybrud.Social.Facebook.Objects.Apps;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Apps {

    public class FacebookGetAppResponse : FacebookResponse<FacebookApp> {

        #region Constructors

        private FacebookGetAppResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookApp.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookGetAppResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetAppResponse(response);
        }

        #endregion

    }

}