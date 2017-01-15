using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Apps;
using Skybrud.Social.Facebook.Responses.Apps;

namespace Skybrud.Social.Facebook.Endpoints {

    /// <summary>
    /// Class representing the implementation of the accounts endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/application</cref>
    /// </see>
    public class FacebookAppsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookAppsRawEndpoint Raw {
            get { return Service.Client.Apps; }
        }

        #endregion

        #region Constructors

        internal FacebookAppsEndpoint(FacebookService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the current app by calling the <code>/app</code> method. This requires an app access
        /// token.
        /// </summary>
        public FacebookGetAppResponse GetApp() {
            return GetApp("app");
        }

        /// <summary>
        /// Gets information about the app with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the app. Can either be "app" or the ID of the app.</param>
        /// <returns>An instance of <see cref="FacebookGetAppResponse"/> representing the response.</returns>
        public FacebookGetAppResponse GetApp(string identifier) {
            return FacebookGetAppResponse.ParseResponse(Raw.GetApp(identifier));
        }

        /// <summary>
        /// Gets information about the app with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the app. Can either be "app" or the ID of the app.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetAppResponse"/> representing the response.</returns>
        public FacebookGetAppResponse GetApp(string identifier, FacebookFieldsCollection fields) {
            return FacebookGetAppResponse.ParseResponse(Raw.GetApp(identifier, fields));
        }

        /// <summary>
        /// Gets information about the app matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetAppResponse"/> representing the response.</returns>
        public FacebookGetAppResponse GetApp(FacebookGetAppOptions options) {
            return FacebookGetAppResponse.ParseResponse(Raw.GetApp(options));
        }

        #endregion

    }

}