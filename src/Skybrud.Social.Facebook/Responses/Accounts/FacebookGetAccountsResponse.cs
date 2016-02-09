using Skybrud.Social.Facebook.Objects.Accounts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Accounts {

    /// <summary>
    /// Class representing a response for a collection of Facebook accounts.
    /// </summary>
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

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetAccountsResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetAccountsResponse"/> representing the response.</returns>
        public static FacebookGetAccountsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetAccountsResponse(response);
        }

        #endregion

    }

}