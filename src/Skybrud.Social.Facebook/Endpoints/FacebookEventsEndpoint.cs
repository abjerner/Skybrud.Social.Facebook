using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Options.Events;
using Skybrud.Social.Facebook.Responses.Events;

namespace Skybrud.Social.Facebook.Endpoints {

    /// <summary>
    /// Class representing the implementation of the events endpoint.
    /// </summary>
    public class FacebookEventsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookEventsRawEndpoint Raw => Service.Client.Events;

        #endregion

        #region Constructors

        internal FacebookEventsEndpoint(FacebookService service) {
            Service = service;
        }

        #endregion

        #region Methods


        /// <summary>
        /// Gets information about the event with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the event.</param>
        /// <returns>An instance of <see cref="FacebookGetEventResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developers.facebook.com/docs/graph-api/reference/event</cref>
        /// </see>
        public FacebookGetEventResponse GetEvent(string identifier) {
            return FacebookGetEventResponse.ParseResponse(Raw.GetEvent(identifier));
        }

        /// <summary>
        /// Gets information about the event matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetEventResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developers.facebook.com/docs/graph-api/reference/event</cref>
        /// </see>
        public FacebookGetEventResponse GetEvent(FacebookGetEventOptions options) {
            return FacebookGetEventResponse.ParseResponse(Raw.GetEvent(options));
        }

        /// <summary>
        /// Gets a list of events of a user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID or name of the user/page.</param>
        /// <returns>An instance of <see cref="FacebookGetEventsResponse"/> representing the response.</returns>
        public FacebookGetEventsResponse GetEvents(string identifier) {
            return FacebookGetEventsResponse.ParseResponse(Raw.GetEvents(identifier));
        }

        /// <summary>
        /// Gets a list of events of a user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID or name of the user/page.</param>
        /// <param name="limit">The maximum amount of events to return.</param>
        /// <returns>An instance of <see cref="FacebookGetEventsResponse"/> representing the response.</returns>
        public FacebookGetEventsResponse GetEvents(string identifier, int limit) {
            return FacebookGetEventsResponse.ParseResponse(Raw.GetEvents(identifier, limit));
        }

        /// <summary>
        /// Gets a list of events for a user or page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetEventsResponse"/> representing the response.</returns>
        public FacebookGetEventsResponse GetEvents(FacebookGetEventsOptions options) {
            return FacebookGetEventsResponse.ParseResponse(Raw.GetEvents(options));
        }

        #endregion

    }

}