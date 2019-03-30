using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Likes;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the likes endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/object/likes</cref>
    /// </see>
    public class FacebookLikesRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal FacebookLikesRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a list of likes for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetLikes(string identifier) {
            if (String.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetLikes(new FacebookGetLikesOptions(identifier));
        }

        /// <summary>
        /// Gets a list of likes for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetLikes(string identifier, FacebookFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetLikes(new FacebookGetLikesOptions(identifier, fields));
        }

        /// <summary>
        /// Gets a list of likes for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of likes to be returned per page.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetLikes(string identifier, int limit) {
            if (String.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetLikes(new FacebookGetLikesOptions(identifier, limit));
        }

        /// <summary>
        /// Gets a list of likes for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of likes to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetLikes(string identifier, int limit, string after, FacebookFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetLikes(new FacebookGetLikesOptions(identifier, limit, after, fields));
        }

        /// <summary>
        /// Gets a list of likes for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of likes to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetLikes(string identifier, int limit, FacebookFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException(nameof(identifier), "A Facebook identifier (ID) must be specified.");
            return GetLikes(new FacebookGetLikesOptions(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of likes for the object matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetLikes(FacebookGetLikesOptions options) {
            if (options == null) throw new ArgumentException(nameof(options));
            if (String.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier), "A Facebook identifier (ID) must be specified.");
            return Client.DoHttpGetRequest("/" + options.Identifier + "/likes", options);
        }

        #endregion

    }

}