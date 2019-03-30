using System;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Feed;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the feed endpoint.
    /// </summary>
    public class FacebookFeedRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal FacebookFeedRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a list of items from the feed of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetFeed(string identifier) {
            return GetFeed(new FacebookGetFeedOptions(identifier));
        }

        /// <summary>
        /// Gets a list of items from the feed of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetFeed(string identifier, FacebookFieldsCollection fields) {
            return GetFeed(new FacebookGetFeedOptions(identifier, fields));
        }

        /// <summary>
        /// Gets a list of items from the feed of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of items to return.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetFeed(string identifier, int limit) {
            return GetFeed(new FacebookGetFeedOptions(identifier, limit));
        }

        /// <summary>
        /// Gets a list of items from the feed of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of items to return.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetFeed(string identifier, int limit, FacebookFieldsCollection fields) {
            return GetFeed(new FacebookGetFeedOptions(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of items from the feed of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of items to be returned on each page.</param>
        /// <param name="until">A timestamp that points to the start of the range of time-based data.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetFeed(string identifier, int limit, EssentialsDateTime until, FacebookFieldsCollection fields) {
            return GetFeed(new FacebookGetFeedOptions(identifier, limit, until, fields));
        }

        /// <summary>
        /// Gets a list of items from the feed of the user or page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetFeed(FacebookGetFeedOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (String.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier));
            return Client.DoHttpGetRequest("/" + options.Identifier + "/feed", options);
        }

        #endregion

    }

}