using System;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Applications;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the apps endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/application</cref>
    /// </see>
    public class FacebookApplicationsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal FacebookApplicationsRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the current app by calling the <c>/app</c> method. This requires an app access
        /// token.
        /// </summary>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetApplication() {
            return GetApplication(new FacebookGetApplicationOptions("app"));
        }

        /// <summary>
        /// Gets information about the app with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the app. Can either be "app" or the ID of the app.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetApplication(string identifier) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetApplication(new FacebookGetApplicationOptions(identifier));
        }

        /// <summary>
        /// Gets information about the app with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the app. Can either be "app" or the ID of the app.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetApplication(string identifier, FacebookFieldList fields) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetApplication(new FacebookGetApplicationOptions(identifier, fields));
        }

        /// <summary>
        /// Gets information about the app matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetApplication(FacebookGetApplicationOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier), "A Facebook identifier (ID) must be specified.");
            return Client.DoHttpGetRequest("/" + options.Identifier, options);
        }

        #endregion

    }

}