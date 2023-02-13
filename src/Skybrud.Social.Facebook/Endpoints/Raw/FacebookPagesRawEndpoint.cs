using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Pages;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the pages endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page</cref>
    /// </see>
    public class FacebookPagesRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal FacebookPagesRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the post with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the page.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPage(string identifier) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID or alias) must be specified.");
            return Client.DoHttpGetRequest("/" + identifier);
        }

        /// <summary>
        /// Gets information about the post with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPage(string identifier, FacebookFieldsCollection fields) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID or alias) must be specified.");
            return GetPage(new FacebookGetPageOptions(identifier, fields));
        }

        /// <summary>
        /// Gets information about the page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPage(FacebookGetPageOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier), "A Facebook identifier (ID or alias) must be specified.");
            return Client.DoHttpGetRequest("/" + options.Identifier, options);
        }

        #endregion

    }

}