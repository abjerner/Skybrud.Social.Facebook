using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Albums;
using Skybrud.Social.Facebook.Responses.Albums;

namespace Skybrud.Social.Facebook.Endpoints {

    /// <summary>
    /// Class representing the implementation of the albums endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/album</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page/albums/</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/user/albums/</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/group/albums</cref>
    /// </see>
    public class FacebookAlbumsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookHttpService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookAlbumsRawEndpoint Raw => Service.Client.Albums;

        #endregion

        #region Constructors

        internal FacebookAlbumsEndpoint(FacebookHttpService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the album with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the album.</param>
        /// <returns>An instance of <see cref="FacebookGetAlbumResponse"/> representing the response.</returns>
        public FacebookGetAlbumResponse GetAlbum(string identifier) {
            return FacebookGetAlbumResponse.ParseResponse(Raw.GetAlbum(identifier));
        }

        /// <summary>
        /// Gets information about the album with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the album.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetAlbumResponse"/> representing the response.</returns>
        public FacebookGetAlbumResponse GetAlbum(string identifier, FacebookFieldsCollection fields) {
            return FacebookGetAlbumResponse.ParseResponse(Raw.GetAlbum(identifier, fields));
        }

        /// <summary>
        /// Gets information about the album matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetAlbumResponse"/> representing the response.</returns>
        public FacebookGetAlbumResponse GetAlbum(FacebookGetAlbumOptions options) {
            return FacebookGetAlbumResponse.ParseResponse(Raw.GetAlbum(options));
        }

        /// <summary>
        /// Gets a list of albums of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the user or page.</param>
        /// <returns>An instance of <see cref="FacebookGetAlbumsResponse"/> representing the response.</returns>
        public FacebookGetAlbumsResponse GetAlbums(string identifier) {
            return FacebookGetAlbumsResponse.ParseResponse(Raw.GetAlbums(identifier));
        }

        /// <summary>
        /// Gets a list of albums of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the user or page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetAlbumsResponse"/> representing the response.</returns>
        public FacebookGetAlbumsResponse GetAlbums(string identifier, FacebookFieldsCollection fields) {
            return FacebookGetAlbumsResponse.ParseResponse(Raw.GetAlbums(identifier, fields));
        }

        /// <summary>
        /// Gets a list of albums of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the user or page.</param>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <returns>An instance of <see cref="FacebookGetAlbumsResponse"/> representing the response.</returns>
        public FacebookGetAlbumsResponse GetAlbums(string identifier, int limit) {
            return FacebookGetAlbumsResponse.ParseResponse(Raw.GetAlbums(identifier, limit));
        }

        /// <summary>
        /// Gets a list of albums of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The ID of the user or page.</param>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetAlbumsResponse"/> representing the response.</returns>
        public FacebookGetAlbumsResponse GetAlbums(string identifier, int limit, FacebookFieldsCollection fields) {
            return FacebookGetAlbumsResponse.ParseResponse(Raw.GetAlbums(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of albums of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of albums to be returned on each page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetAlbumsResponse"/> representing the response.</returns>
        public FacebookGetAlbumsResponse GetAlbums(string identifier, int limit, string after, FacebookFieldsCollection fields) {
            return FacebookGetAlbumsResponse.ParseResponse(Raw.GetAlbums(identifier, limit, after, fields));
        }

        /// <summary>
        /// Gets a list of albums of the user or page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetAlbumsResponse"/> representing the response.</returns>
        public FacebookGetAlbumsResponse GetAlbums(FacebookGetAlbumsOptions options) {
            return FacebookGetAlbumsResponse.ParseResponse(Raw.GetAlbums(options));
        }

        #endregion

    }

}