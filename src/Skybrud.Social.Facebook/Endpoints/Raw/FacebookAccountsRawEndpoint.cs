using System;
using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Accounts;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the accounts endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/accounts/</cref>
    /// </see>
    public class FacebookAccountsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal FacebookAccountsRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAccounts() {
            return GetAccounts(new FacebookFieldsCollection());
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="fields">A collection of the fields to be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAccounts(FacebookFieldsCollection fields) {
            return GetAccounts(new FacebookGetAccountsOptions(fields));
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAccounts(int limit) {
            return GetAccounts(new FacebookGetAccountsOptions(limit));
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="fields">A collection of the fields to be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAccounts(int limit, FacebookFieldsCollection fields) {
            return GetAccounts(new FacebookGetAccountsOptions(limit, fields));
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAccounts(int limit, string after) {
            return GetAccounts(new FacebookGetAccountsOptions(limit, after));
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields to be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAccounts(int limit, string after, FacebookFieldsCollection fields) {
            return GetAccounts(new FacebookGetAccountsOptions(limit, after, fields));
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAccounts(FacebookGetAccountsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/me/accounts", options);
        }

        #endregion

    }

}