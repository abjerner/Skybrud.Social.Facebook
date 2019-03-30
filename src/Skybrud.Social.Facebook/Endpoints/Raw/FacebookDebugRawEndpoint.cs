using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the debug endpoint.
    /// </summary>
    public class FacebookDebugRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal FacebookDebugRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets debug information about the access token used for accessing the Graph API.
        /// </summary>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse DebugToken() {
            if (String.IsNullOrWhiteSpace(Client.AccessToken)) throw new PropertyNotSetException(nameof(Client.AccessToken));
            return DebugToken(Client.AccessToken);
        }

        /// <summary>
        /// Gets debug information about the specified access token.
        /// </summary>
        /// <param name="accessToken">The access token to debug.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse DebugToken(string accessToken) {

            // Declare the query string
            IHttpQueryString query = new HttpQueryString();
            query.Add("input_token", accessToken);
            
            // Make the call to the API
            return Client.DoHttpGetRequest("/debug_token", query);
        
        }

        #endregion

    }

}