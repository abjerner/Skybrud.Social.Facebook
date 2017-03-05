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
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page/feed</cref>
    /// </see>
    public class FacebookPostsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookPostsRawEndpoint Raw {
            get { return Service.Client.Posts; }
        }

        #endregion

        #region Constructors

        internal FacebookPostsEndpoint(FacebookService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the post with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the post.</param>
        /// <returns>An instance of <see cref="FacebookGetPostResponse"/> representing the response.</returns>
        public FacebookGetPostResponse GetPost(string identifier) {
            return FacebookGetPostResponse.ParseResponse(Raw.GetPost(identifier));
        }

        /// <summary>
        /// Gets information about the post with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the post.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPostResponse"/> representing the response.</returns>
        public FacebookGetPostResponse GetPost(string identifier, FacebookFieldsCollection fields) {
            return FacebookGetPostResponse.ParseResponse(Raw.GetPost(identifier, fields));
        }

        /// <summary>
        /// Gets information about the post matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPostResponse"/> representing the response.</returns>
        public FacebookGetPostResponse GetPost(FacebookGetPostOptions options) {
            return FacebookGetPostResponse.ParseResponse(Raw.GetPost(options));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <returns>An instance of <see cref="FacebookGetPostsResponse"/> representing the response.</returns>
        public FacebookGetPostsResponse GetPosts(string identifier) {
            return FacebookGetPostsResponse.ParseResponse(Raw.GetPosts(identifier));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPostsResponse"/> representing the response.</returns>
        public FacebookGetPostsResponse GetPosts(string identifier, FacebookFieldsCollection fields) {
            return FacebookGetPostsResponse.ParseResponse(Raw.GetPosts(identifier, fields));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of posts to be returned on each page.</param>
        /// <returns>An instance of <see cref="FacebookGetPostsResponse"/> representing the response.</returns>
        public FacebookGetPostsResponse GetPosts(string identifier, int limit) {
            return FacebookGetPostsResponse.ParseResponse(Raw.GetPosts(identifier, limit));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit"></param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPostsResponse"/> representing the response.</returns>
        public FacebookGetPostsResponse GetPosts(string identifier, int limit, FacebookFieldsCollection fields) {
            return FacebookGetPostsResponse.ParseResponse(Raw.GetPosts(identifier, limit, fields));
        }

        /// <summary>
        /// Gets a list of posts of the user or page with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the user or page.</param>
        /// <param name="limit">The maximum amount of posts to be returned on each page.</param>
        /// <param name="until">A timestamp that points to the start of the range of time-based data.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPostsResponse"/> representing the response.</returns>
        public FacebookGetPostsResponse GetPosts(string identifier, int limit, EssentialsDateTime until, FacebookFieldsCollection fields) {
            return FacebookGetPostsResponse.ParseResponse(Raw.GetPosts(identifier, limit, until, fields));
        }

        /// <summary>
        /// Gets a list of posts of the user or page matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetPostsResponse"/> representing the response.</returns>
        public FacebookGetPostsResponse GetPosts(FacebookGetPostsOptions options) {
            return FacebookGetPostsResponse.ParseResponse(Raw.GetPosts(options));
        }

        /// <summary>
        /// Publishes a new post to the feed matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookCreatePostResponse"/> representing the response.</returns>
        public FacebookCreatePostResponse CreatePost(FacebookCreatePostOptions options) {
            return FacebookCreatePostResponse.ParseResponse(Raw.CreatePost(options));
        }

        #endregion

    }

}