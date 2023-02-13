using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Pages;
using Skybrud.Social.Facebook.Responses.Pages;

namespace Skybrud.Social.Facebook.Endpoints {

    /// <summary>
    /// Class representing the implementation of the pages endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page</cref>
    /// </see>
    public class FacebookPagesEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookPagesRawEndpoint Raw => Service.Client.Pages;

        #endregion

        #region Constructors

        internal FacebookPagesEndpoint(FacebookService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the post with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the page.</param>
        /// <returns>An instance of <see cref="FacebookGetPageResponse"/> representing the response.</returns>
        public FacebookGetPageResponse GetPage(string identifier) {
            return FacebookGetPageResponse.ParseResponse(Raw.GetPage(identifier));
        }

        /// <summary>
        /// Gets information about the post with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPageResponse"/> representing the response.</returns>
        public FacebookGetPageResponse GetPage(string identifier, FacebookFieldsCollection fields) {
            return FacebookGetPageResponse.ParseResponse(Raw.GetPage(identifier, fields));
        }

        /// <summary>
        /// Gets information about the page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPageResponse"/> representing the response.</returns>
        public FacebookGetPageResponse GetPage(FacebookGetPageOptions options) {
            return FacebookGetPageResponse.ParseResponse(Raw.GetPage(options));
        }

        #endregion

    }

}