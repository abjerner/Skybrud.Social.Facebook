using Skybrud.Social.Facebook.Objects.Links;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Links {

    /// <summary>
    /// Class representing the response of a call to get information about a single Facebook link.
    /// </summary>
    public class FacebookGetLinkResponse : FacebookResponse<FacebookLink> {

        #region Constructors

        private FacebookGetLinkResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookLink.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookGetLinkResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetLinkResponse(response);
        }

        #endregion

    }

}