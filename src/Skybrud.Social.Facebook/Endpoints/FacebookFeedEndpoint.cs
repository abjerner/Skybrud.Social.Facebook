using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Feed;
using Skybrud.Social.Facebook.Responses.Feed;

namespace Skybrud.Social.Facebook.Endpoints {

    /// <summary>
    /// Class representing the implementation of the feed endpoint.
    /// </summary>
    public class FacebookFeedEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookHttpService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookFeedRawEndpoint Raw => Service.Client.Feed;

        #endregion

        #region Constructors

        internal FacebookFeedEndpoint(FacebookHttpService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a list of items from the feed of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <returns>An instance of <see cref="FacebookGetFeedResponse"/> representing the response.</returns>
        public FacebookGetFeedResponse GetFeed(string identifier) {
            return FacebookGetFeedResponse.ParseResponse(Raw.GetFeed(identifier));
        }

        /// <summary>
        /// Gets a list of items from the feed of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetFeedResponse"/> representing the response.</returns>
        public FacebookGetFeedResponse GetFeed(string identifier, FacebookFieldList fields) {
            return FacebookGetFeedResponse.ParseResponse(Raw.GetFeed(identifier, fields));
        }

        /// <summary>
        /// Gets a list of items from the feed of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of items to return.</param>
        /// <returns>An instance of <see cref="FacebookGetFeedResponse"/> representing the response.</returns>
        public FacebookGetFeedResponse GetFeed(string identifier, int limit) {
            return FacebookGetFeedResponse.ParseResponse(Raw.GetFeed(identifier, limit));
        }

        /// <summary>
        /// Gets a list of items from the feed of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of items to return.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetFeedResponse"/> representing the response.</returns>
        public FacebookGetFeedResponse GetFeed(string identifier, int limit, FacebookFieldList fields) {
            return FacebookGetFeedResponse.ParseResponse(Raw.GetFeed(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of items from the feed of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of items to be returned on each page.</param>
        /// <param name="until">A timestamp that points to the start of the range of time-based data.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetFeedResponse"/> representing the response.</returns>
        public FacebookGetFeedResponse GetFeed(string identifier, int limit, EssentialsTime until, FacebookFieldList fields) {
            return FacebookGetFeedResponse.ParseResponse(Raw.GetFeed(identifier, limit, until, fields));
        }

        /// <summary>
        /// Gets a list of items from the feed of the user or page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetFeedResponse"/> representing the response.</returns>
        public FacebookGetFeedResponse GetFeed(FacebookGetFeedOptions options) {
            return FacebookGetFeedResponse.ParseResponse(Raw.GetFeed(options));
        }

        #endregion

    }

}