using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Photos;
using Skybrud.Social.Facebook.Responses.Photos;

namespace Skybrud.Social.Facebook.Endpoints {

    /// <summary>
    /// Class representing the implementation of the photos endpoint.
    /// </summary>
    public class FacebookPhotosEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookPhotosRawEndpoint Raw {
            get { return Service.Client.Photos; }
        }

        #endregion

        #region Constructors

        internal FacebookPhotosEndpoint(FacebookService service) {
            Service = service;
        }

        #endregion

        #region Methods
        
        /// <summary>
        /// Gets information about the photo with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the photo.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotoResponse"/> representing the response.</returns>
        public FacebookGetPhotoResponse GetPhoto(string identifier) {
            return FacebookGetPhotoResponse.ParseResponse(Raw.GetPhoto(identifier));
        }

        /// <summary>
        /// Gets information about the photo with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the photo.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotoResponse"/> representing the response.</returns>
        public FacebookGetPhotoResponse GetPhoto(string identifier, FacebookFieldsCollection fields) {
            return FacebookGetPhotoResponse.ParseResponse(Raw.GetPhoto(identifier, fields));
        }

        /// <summary>
        /// Gets information about the photo matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotoResponse"/> representing the response.</returns>
        public FacebookGetPhotoResponse GetPhoto(FacebookGetPhotoOptions options) {
            return FacebookGetPhotoResponse.ParseResponse(Raw.GetPhoto(options));
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the parent object.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotosResponse"/> representing the response.</returns>
        public FacebookGetPhotosResponse GetPhotos(string identifier) {
            return FacebookGetPhotosResponse.ParseResponse(Raw.GetPhotos(identifier));
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotosResponse"/> representing the response.</returns>
        public FacebookGetPhotosResponse GetPhotos(string identifier, FacebookFieldsCollection fields) {
            return FacebookGetPhotosResponse.ParseResponse(Raw.GetPhotos(identifier, fields));
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of photos to be returned per page.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotosResponse"/> representing the response.</returns>
        public FacebookGetPhotosResponse GetPhotos(string identifier, int limit) {
            return FacebookGetPhotosResponse.ParseResponse(Raw.GetPhotos(identifier, limit));
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of photos to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotosResponse"/> representing the response.</returns>
        public FacebookGetPhotosResponse GetPhotos(string identifier, int limit, string after, FacebookFieldsCollection fields) {
            return FacebookGetPhotosResponse.ParseResponse(Raw.GetPhotos(identifier, limit, after, fields));
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of photos to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotosResponse"/> representing the response.</returns>
        public FacebookGetPhotosResponse GetPhotos(string identifier, int limit, FacebookFieldsCollection fields) {
            return FacebookGetPhotosResponse.ParseResponse(Raw.GetPhotos(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotosResponse"/> representing the response.</returns>
        public FacebookGetPhotosResponse GetPhotos(FacebookGetPhotosOptions options) {
            return FacebookGetPhotosResponse.ParseResponse(Raw.GetPhotos(options));
        }

        /// <summary>
        /// Posts a new photo to the object matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookCreatePhotoResponse"/> representing the response.</returns>
        public FacebookCreatePhotoResponse PostPhoto(FacebookPostUserPhotoOptions options) {
            return FacebookCreatePhotoResponse.ParseResponse(Raw.PostPhoto(options));
        }

        #endregion

    }

}