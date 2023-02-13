﻿using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Events;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the events endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/event</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/page/events/</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/events/</cref>
    /// </see>
    public class FacebookEventsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal FacebookEventsRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the event with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the event.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetEvent(string identifier) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier));
            return GetEvent(new FacebookGetEventOptions(identifier));
        }

        /// <summary>
        /// Gets information about the event matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetEvent(FacebookGetEventOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier));
            return Client.DoHttpGetRequest("/" + options.Identifier, options);
        }

        /// <summary>
        /// Gets a list of events of a user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID or name of the user/page.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetEvents(string identifier) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier));
            return GetEvents(new FacebookGetEventsOptions(identifier));
        }

        /// <summary>
        /// Gets a list of events of a user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID or name of the user/page.</param>
        /// <param name="limit">The maximum amount of events to return.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetEvents(string identifier, int limit) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier));
            return GetEvents(new FacebookGetEventsOptions(identifier) { Limit = limit });
        }

        /// <summary>
        /// Gets a list of events for a user or page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetEvents(FacebookGetEventsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier));
            return Client.DoHttpGetRequest("/" + options.Identifier + "/events", options);
        }

        #endregion

    }

}