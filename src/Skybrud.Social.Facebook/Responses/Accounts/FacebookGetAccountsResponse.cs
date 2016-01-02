using Skybrud.Social.Facebook.Objects.Accounts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Accounts {

    public class FacebookGetAccountsResponse : FacebookResponse<FacebookAccountsCollection> {

        #region Constructors

        private FacebookGetAccountsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookAccountsCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookGetAccountsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetAccountsResponse(response);
        }

        #endregion

    }

}