using System;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Albums;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the albums endpoint.
    /// </summary>
    public class FacebookAlbumsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference of the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal FacebookAlbumsRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the album with the specified <code>id</code>
        /// </summary>
        /// <param name="id">The ID of the album.</param>
        public SocialHttpResponse GetAlbum(string id) {
            return Client.DoHttpGetRequest("/" + id);
        }

        /// <summary>
        /// Gets information about the album matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public SocialHttpResponse GetAlbum(FacebookGetAlbumOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("/" + options.Identifier);
        }

        /// <summary>
        /// Gets a list of albums of the user or page matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public SocialHttpResponse GetAlbums(FacebookGetAlbumsOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("/" + options.Identifier + "/albums", options);
        }
        
        /// <summary>
        /// Creates a new album for the page or user matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public SocialHttpResponse PostAlbum(FacebookPostAlbumOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpPostRequest("/" + options.Identifier + "/albums", options);
        }

        #endregion

    }

}