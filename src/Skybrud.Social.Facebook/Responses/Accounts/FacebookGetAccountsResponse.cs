using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Accounts;
using Skybrud.Social.Facebook.Models.Pages;

namespace Skybrud.Social.Facebook.Responses.Accounts {

    /// <summary>
    /// Class representing a response for a collection of <see cref="FacebookPage"/>.
    /// </summary>
    public class FacebookGetAccountsResponse : FacebookResponse<FacebookAccountsCollection> {

        #region Constructors

        private FacebookGetAccountsResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookAccountsCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookGetAccountsResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetAccountsResponse"/> representing the response.</returns>
        public static FacebookGetAccountsResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new FacebookGetAccountsResponse(response);
        }

        #endregion

    }

}