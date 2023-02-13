using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Posts;
using Skybrud.Social.Facebook.Responses.Posts;

namespace Skybrud.Social.Facebook.Endpoints {

    /// <summary>
    /// Class representing the implementation of the posts endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v16.0/page/feed</cref>
    /// </see>
    public class FacebookPostsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookHttpService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookPostsRawEndpoint Raw => Service.Client.Posts;

        #endregion

        #region Constructors

        internal FacebookPostsEndpoint(FacebookHttpService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Publishes a new post to the feed matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookPostResponse"/> representing the response.</returns>
        public FacebookPostResponse CreatePost(FacebookCreatePostOptions options) {
            return new FacebookPostResponse(Raw.CreatePost(options));
        }

        /// <summary>
        /// Gets information about the post with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the post.</param>
        /// <returns>An instance of <see cref="FacebookPostResponse"/> representing the response.</returns>
        public FacebookPostResponse GetPost(string identifier) {
            return new FacebookPostResponse(Raw.GetPost(identifier));
        }

        /// <summary>
        /// Gets information about the post with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the post.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookPostResponse"/> representing the response.</returns>
        public FacebookPostResponse GetPost(string identifier, FacebookFieldList fields) {
            return new FacebookPostResponse(Raw.GetPost(identifier, fields));
        }

        /// <summary>
        /// Gets information about the post matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookPostResponse"/> representing the response.</returns>
        public FacebookPostResponse GetPost(FacebookGetPostOptions options) {
            return new FacebookPostResponse(Raw.GetPost(options));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <returns>An instance of <see cref="FacebookPostListResponse"/> representing the response.</returns>
        public FacebookPostListResponse GetPosts(string identifier) {
            return new FacebookPostListResponse(Raw.GetPosts(identifier));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookPostListResponse"/> representing the response.</returns>
        public FacebookPostListResponse GetPosts(string identifier, FacebookFieldList fields) {
            return new FacebookPostListResponse(Raw.GetPosts(identifier, fields));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of posts to be returned on each page.</param>
        /// <returns>An instance of <see cref="FacebookPostListResponse"/> representing the response.</returns>
        public FacebookPostListResponse GetPosts(string identifier, int limit) {
            return new FacebookPostListResponse(Raw.GetPosts(identifier, limit));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit"></param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookPostListResponse"/> representing the response.</returns>
        public FacebookPostListResponse GetPosts(string identifier, int limit, FacebookFieldList fields) {
            return new FacebookPostListResponse(Raw.GetPosts(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of posts of the user or page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookPostListResponse"/> representing the response.</returns>
        public FacebookPostListResponse GetPosts(FacebookGetPostsOptions options) {
            return new FacebookPostListResponse(Raw.GetPosts(options));
        }

        #endregion

    }

}