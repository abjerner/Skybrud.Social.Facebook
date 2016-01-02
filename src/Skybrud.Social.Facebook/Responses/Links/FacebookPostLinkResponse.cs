using Skybrud.Social.Facebook.Objects.Links;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Links {

    public class FacebookPostLinkResponse : FacebookResponse<FacebookPostLinkSummary> {

        #region Constructors

        private FacebookPostLinkResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPostLinkSummary.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookPostLinkResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookPostLinkResponse(response);
        }

        #endregion

    }

}