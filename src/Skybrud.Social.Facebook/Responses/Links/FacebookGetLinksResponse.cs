using Skybrud.Social.Facebook.Objects.Links;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Links {

    public class FacebookGetLinksResponse : FacebookResponse<FacebookLinksCollection> {

        #region Constructors

        private FacebookGetLinksResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookLinksCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookGetLinksResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetLinksResponse(response);
        }

        #endregion

    }

}