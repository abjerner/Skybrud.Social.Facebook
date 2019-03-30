using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Comments;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the comments endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/object/comments</cref>
    /// </see>
    public class FacebookCommentsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal FacebookCommentsRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the comment with specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the comment.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetComment(string identifier) {
            return GetComment(new FacebookGetCommentOptions(identifier));
        }

        /// <summary>
        /// Gets information about the comment with specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the comment.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetComment(string identifier, FacebookFieldsCollection fields) {
            return GetComment(new FacebookGetCommentOptions(identifier, fields));
        }

        /// <summary>
        /// Gets information about the comment matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetComment(FacebookGetCommentOptions options) {
            return Client.DoHttpGetRequest("/" + options.Identifier, options);
        }

        /// <summary>
        /// Gets a list of comments for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetComments(string identifier) {
            return GetComments(new FacebookGetCommentsOptions(identifier));
        }

        /// <summary>
        /// Gets a list of comments for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetComments(string identifier, FacebookFieldsCollection fields) {
            return GetComments(new FacebookGetCommentsOptions(identifier, fields));
        }

        /// <summary>
        /// Gets a list of comments for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of comments to be returned per page.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetComments(string identifier, int limit) {
            return GetComments(new FacebookGetCommentsOptions(identifier, limit));
        }

        /// <summary>
        /// Gets a list of comments for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of comments to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetComments(string identifier, int limit, string after, FacebookFieldsCollection fields) {
            return GetComments(new FacebookGetCommentsOptions(identifier, limit, after, fields));
        }

        /// <summary>
        /// Gets a list of comments for the object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of comments to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetComments(string identifier, int limit, FacebookFieldsCollection fields) {
            return GetComments(new FacebookGetCommentsOptions(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of comments for the object matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="IHttpResponse"/> representing the raw response.</returns>
        public IHttpResponse GetComments(FacebookGetCommentsOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            if (String.IsNullOrWhiteSpace(options.Identifier)) throw new PropertyNotSetException(nameof(options.Identifier));
            return Client.DoHttpGetRequest("/" + options.Identifier + "/comments", options);
        }

        #endregion

    }

}