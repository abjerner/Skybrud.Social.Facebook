using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Likes;
using Skybrud.Social.Facebook.Responses.Likes;

namespace Skybrud.Social.Facebook.Endpoints {

    /// <summary>
    /// Class representing the implementation of the likes endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/object/likes</cref>
    /// </see>
    public class FacebookLikesEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookLikesRawEndpoint Raw {
            get { return Service.Client.Likes; }
        }

        #endregion

        #region Constructors

        internal FacebookLikesEndpoint(FacebookService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a list of likes for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <returns>An instance of <see cref="FacebookGetLikesResponse"/> representing the response.</returns>
        public FacebookGetLikesResponse GetLikes(string identifier) {
            return FacebookGetLikesResponse.ParseResponse(Raw.GetLikes(identifier));
        }

        /// <summary>
        /// Gets a list of likes for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetLikesResponse"/> representing the response.</returns>
        public FacebookGetLikesResponse GetLikes(string identifier, FacebookFieldsCollection fields) {
            return FacebookGetLikesResponse.ParseResponse(Raw.GetLikes(identifier, fields));
        }

        /// <summary>
        /// Gets a list of likes for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of likes to be returned per page.</param>
        /// <returns>An instance of <see cref="FacebookGetLikesResponse"/> representing the response.</returns>
        public FacebookGetLikesResponse GetLikes(string identifier, int limit) {
            return FacebookGetLikesResponse.ParseResponse(Raw.GetLikes(identifier, limit));
        }

        /// <summary>
        /// Gets a list of likes for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of likes to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetLikesResponse"/> representing the response.</returns>
        public FacebookGetLikesResponse GetLikes(string identifier, int limit, string after, FacebookFieldsCollection fields) {
            return FacebookGetLikesResponse.ParseResponse(Raw.GetLikes(identifier, limit, after, fields));
        }

        /// <summary>
        /// Gets a list of likes for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of likes to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetLikesResponse"/> representing the response.</returns>
        public FacebookGetLikesResponse GetLikes(string identifier, int limit, FacebookFieldsCollection fields) {
            return FacebookGetLikesResponse.ParseResponse(Raw.GetLikes(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of likes for the object matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetLikesResponse"/> representing the response.</returns>
        public FacebookGetLikesResponse GetLikes(FacebookGetLikesOptions options) {
            return FacebookGetLikesResponse.ParseResponse(Raw.GetLikes(options));
        }

        #endregion

    }

}