using System;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Comments;
using Skybrud.Social.Http;

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
        public FacebookOAuthClient Client { get; private set; }

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
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetComment(string identifier) {
            return GetComment(new FacebookGetCommentOptions(identifier));
        }

        /// <summary>
        /// Gets information about the comment matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetComment(FacebookGetCommentOptions options) {
            return Client.DoHttpGetRequest("/" + options.Identifier, options);
        }

        /// <summary>
        /// Gets a list of comments for an object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the parent object.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetComments(string identifier) {
            return GetComments(new FacebookGetCommentsOptions(identifier));
        }

        /// <summary>
        /// Gets a list of comments for an object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the parent object.</param>
        /// <param name="limit">The maximum amount of comments to be returned per page.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetComments(string identifier, int limit) {
            return GetComments(new FacebookGetCommentsOptions(identifier, limit));
        }

        /// <summary>
        /// Gets a list of comments for an object matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetComments(FacebookGetCommentsOptions options) {
            if (options == null) throw new ArgumentException("options");
            return Client.DoHttpGetRequest("/" + options.Identifier + "/comments", options);
        }

        #endregion

    }

}