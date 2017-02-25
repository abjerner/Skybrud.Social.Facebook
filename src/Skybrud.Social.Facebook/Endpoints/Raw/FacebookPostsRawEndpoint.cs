using System;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Posts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {
    
    /// <summary>
    /// Class representing the raw implementation of the posts endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page/feed</cref>
    /// </see>
    public class FacebookPostsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal FacebookPostsRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the post with the specified <paramref name="postId"/>.
        /// </summary>
        /// <param name="postId">The ID of the post.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPost(string postId) {
            if (String.IsNullOrWhiteSpace(postId)) throw new ArgumentNullException("postId");
            return Client.DoHttpGetRequest("/" + postId);
        }

        /// <summary>
        /// Gets information about the post with the specified <paramref name="postId"/>.
        /// </summary>
        /// <param name="postId">The ID of the post.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPost(string postId, FacebookFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(postId)) throw new ArgumentNullException("postId");
            return GetPost(new FacebookGetPostOptions(postId, fields));
        }

        /// <summary>
        /// Gets information about the post matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPost(FacebookGetPostOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("/" + options.Identifier, options);
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPosts(string identifier) {
            if (String.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException("identifier", "A Facebook identifier (ID or alias) must be specified.");
            return GetPosts(new FacebookGetPostsOptions(identifier));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPosts(string identifier, FacebookFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException("identifier", "A Facebook identifier (ID or alias) must be specified.");
            return GetPosts(new FacebookGetPostsOptions(identifier, fields));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of posts to be returned on each page.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPosts(string identifier, int limit) {
            if (String.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException("identifier", "A Facebook identifier (ID or alias) must be specified.");
            return GetPosts(new FacebookGetPostsOptions(identifier, limit));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit"></param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPosts(string identifier, int limit, FacebookFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException("identifier", "A Facebook identifier (ID or alias) must be specified.");
            return GetPosts(new FacebookGetPostsOptions(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of posts to be returned on each page.</param>
        /// <param name="until">A timestamp that points to the start of the range of time-based data.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPosts(string identifier, int limit, EssentialsDateTime until, FacebookFieldsCollection fields) {
            if (String.IsNullOrWhiteSpace(identifier)) throw new ArgumentNullException("identifier", "A Facebook identifier (ID or alias) must be specified.");
            return GetPosts(new FacebookGetPostsOptions(identifier, limit, until, fields));
        }

        /// <summary>
        /// Gets a list of posts of the user or page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetPosts(FacebookGetPostsOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("/" + options.Identifier + "/posts", options);
        }

        #endregion

    }

}