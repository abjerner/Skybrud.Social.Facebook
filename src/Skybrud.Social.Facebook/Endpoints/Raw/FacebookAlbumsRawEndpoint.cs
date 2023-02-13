using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Albums;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the albums endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/album</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page/albums/</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/user/albums/</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/group/albums</cref>
    /// </see>
    public class FacebookAlbumsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal FacebookAlbumsRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the album with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the album.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAlbum(string identifier) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetAlbum(new FacebookGetAlbumOptions(identifier));
        }

        /// <summary>
        /// Gets information about the album with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the album.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAlbum(string identifier, FacebookFieldList fields) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetAlbum(new FacebookGetAlbumOptions(identifier, fields));
        }

        /// <summary>
        /// Gets information about the album matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAlbum(FacebookGetAlbumOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier), "A Facebook identifier (ID) must be specified.");
            return Client.DoHttpGetRequest("/" + options.Identifier, options);
        }

        /// <summary>
        /// Gets a list of albums of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the user or page.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAlbums(string identifier) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetAlbums(new FacebookGetAlbumsOptions(identifier));
        }

        /// <summary>
        /// Gets a list of albums of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the user or page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAlbums(string identifier, FacebookFieldList fields) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetAlbums(new FacebookGetAlbumsOptions(identifier, fields));
        }

        /// <summary>
        /// Gets a list of albums of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the user or page.</param>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAlbums(string identifier, int limit) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetAlbums(new FacebookGetAlbumsOptions(identifier, limit));
        }

        /// <summary>
        /// Gets a list of albums of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the user or page.</param>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAlbums(string identifier, int limit, FacebookFieldList fields) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetAlbums(new FacebookGetAlbumsOptions(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of albums of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of albums to be returned on each page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAlbums(string identifier, int limit, string after, FacebookFieldList fields) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier));
            return GetAlbums(new FacebookGetAlbumsOptions(identifier, limit, after, fields));
        }

        /// <summary>
        /// Gets a list of albums of the user or page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetAlbums(FacebookGetAlbumsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier), "A Facebook identifier (ID) must be specified.");
            return Client.DoHttpGetRequest("/" + options.Identifier + "/albums", options);
        }

        /// <summary>
        /// Creates a new album for the page or user matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse CreateAlbum(FacebookCreateAlbumOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier), "A Facebook identifier (ID) must be specified.");
            if (string.IsNullOrWhiteSpace(options.Name)) throw new PropertyNotSetException(nameof(options.Name), "CreateAlbum: An album name must be specified.");
            return Client.DoHttpPostRequest("/" + options.Identifier + "/albums", options);
        }

        #endregion

    }

}