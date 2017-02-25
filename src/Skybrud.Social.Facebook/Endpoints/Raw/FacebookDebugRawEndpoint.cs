using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the debug endpoint.
    /// </summary>
    public class FacebookDebugRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; private set; }

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
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse DebugToken() {
            if (String.IsNullOrWhiteSpace(Client.AccessToken)) throw new PropertyNotSetException("Client.AccessToken");
            return DebugToken(Client.AccessToken);
        }

        /// <summary>
        /// Gets debug information about the specified access token.
        /// </summary>
        /// <param name="accessToken">The access token to debug.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse DebugToken(string accessToken) {

            // Declare the query string
            SocialHttpQueryString query = new SocialHttpQueryString();
            query.Add("input_token", accessToken);
            
            // Make the call to the API
            return Client.DoHttpGetRequest("/debug_token", query);
        
        }

        #endregion

    }

}