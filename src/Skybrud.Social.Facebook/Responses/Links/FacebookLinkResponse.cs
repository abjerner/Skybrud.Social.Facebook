using Skybrud.Social.Facebook.Objects.Links;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Links {

    public class FacebookLinkResponse : FacebookResponse<FacebookLink> {

        #region Constructors

        private FacebookLinkResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookLink.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookLinkResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookLinkResponse(response);
        }

        #endregion

    }

}