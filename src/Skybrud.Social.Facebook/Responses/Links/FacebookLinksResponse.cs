using Skybrud.Social.Facebook.Objects.Links;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Links {

    public class FacebookLinksResponse : FacebookResponse<FacebookLinksCollection> {

        #region Constructors

        private FacebookLinksResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookLinksCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookLinksResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookLinksResponse(response);
        }

        #endregion

    }

}