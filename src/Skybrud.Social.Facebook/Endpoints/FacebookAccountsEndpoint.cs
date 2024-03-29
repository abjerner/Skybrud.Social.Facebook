using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Accounts;
using Skybrud.Social.Facebook.Responses.Pages;

namespace Skybrud.Social.Facebook.Endpoints {

    /// <summary>
    /// Class representing the implementation of the accounts endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/accounts/</cref>
    /// </see>
    public class FacebookAccountsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookHttpService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookAccountsRawEndpoint Raw => Service.Client.Accounts;

        #endregion

        #region Constructors

        internal FacebookAccountsEndpoint(FacebookHttpService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <returns>An instance of <see cref="FacebookPageListResponse"/> representing the response.</returns>
        public FacebookPageListResponse GetAccounts() {
            return new FacebookPageListResponse(Raw.GetAccounts());
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="fields">A collection of the fields to be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookPageListResponse"/> representing the response.</returns>
        public FacebookPageListResponse GetAccounts(FacebookFieldList? fields) {
            return new FacebookPageListResponse(Raw.GetAccounts(fields));
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <returns>An instance of <see cref="FacebookPageListResponse"/> representing the response.</returns>
        public FacebookPageListResponse GetAccounts(int? limit) {
            return new FacebookPageListResponse(Raw.GetAccounts(limit));
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="fields">A collection of the fields to be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookPageListResponse"/> representing the response.</returns>
        public FacebookPageListResponse GetAccounts(int? limit, FacebookFieldList? fields) {
            return new FacebookPageListResponse(Raw.GetAccounts(limit, fields));
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <returns>An instance of <see cref="FacebookPageListResponse"/> representing the response.</returns>
        public FacebookPageListResponse GetAccounts(int? limit, string? after) {
            return new FacebookPageListResponse(Raw.GetAccounts(limit, after));
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields to be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookPageListResponse"/> representing the response.</returns>
        public FacebookPageListResponse GetAccounts(int? limit, string? after, FacebookFieldList? fields) {
            return new FacebookPageListResponse(Raw.GetAccounts(limit, after, fields));
        }

        /// <summary>
        /// Gets information about accounts associated with the current user by calling the <c>/me/accounts</c>
        /// method. This call requires a user access token as well as the <c>manage_scope</c>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookPageListResponse"/> representing the response.</returns>
        public FacebookPageListResponse GetAccounts(FacebookGetAccountsOptions options) {
            return new FacebookPageListResponse(Raw.GetAccounts(options));
        }

        #endregion

    }

}