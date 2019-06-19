using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Photos;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the photos endpoint.
    /// </summary>
    public class FacebookPhotosRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal FacebookPhotosRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods
        
        /// <summary>
        /// Gets information about the photo with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the photo.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPhoto(string identifier) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return Client.DoHttpGetRequest("/" + identifier);
        }

        /// <summary>
        /// Gets information about the photo with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the photo.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPhoto(string identifier, FacebookFieldsCollection fields) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetPhoto(new FacebookGetPhotoOptions(identifier, fields));
        }

        /// <summary>
        /// Gets information about the photo matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPhoto(FacebookGetPhotoOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier), "A Facebook identifier (ID) must be specified.");
            return Client.DoHttpGetRequest("/" + options.Identifier, options);
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the parent object.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPhotos(string identifier) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID or alias) must be specified.");
            return GetPhotos(new FacebookGetPhotosOptions(identifier));
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPhotos(string identifier, FacebookFieldsCollection fields) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID or alias) must be specified.");
            return GetPhotos(new FacebookGetPhotosOptions(identifier, fields));
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of photos to be returned per page.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPhotos(string identifier, int limit) {
            return GetPhotos(new FacebookGetPhotosOptions(identifier, limit));
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of photos to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPhotos(string identifier, int limit, string after, FacebookFieldsCollection fields) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID or alias) must be specified.");
            return GetPhotos(new FacebookGetPhotosOptions(identifier, limit, after, fields));
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of photos to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPhotos(string identifier, int limit, FacebookFieldsCollection fields) {
            if (string.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID or alias) must be specified.");
            return GetPhotos(new FacebookGetPhotosOptions(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetPhotos(FacebookGetPhotosOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier), "A Facebook identifier (ID or alias) must be specified.");
            return Client.DoHttpGetRequest("/" + options.Identifier + "/photos", options);
        }

        /// <summary>
        /// Posts a new photo to the object matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse PostPhoto(FacebookPostUserPhotoOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (string.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier), "A Facebook identifier (ID or alias) must be specified.");
            return Client.DoHttpPostRequest("/" + options.Identifier + "/photos", options);
        }

        #endregion

    }

}