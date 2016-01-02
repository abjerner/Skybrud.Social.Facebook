using Skybrud.Social.Facebook.Objects.Pages;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Pages {

    public class FacebookPageResponse : FacebookResponse<FacebookPage> {

        #region Constructors

        private FacebookPageResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPage.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookPageResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookPageResponse(response);
        }

        #endregion

    }

}