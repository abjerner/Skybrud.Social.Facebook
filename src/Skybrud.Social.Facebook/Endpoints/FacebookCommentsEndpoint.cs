using System;
using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Options.Comments;
using Skybrud.Social.Facebook.Responses.Comments;

namespace Skybrud.Social.Facebook.Endpoints {

    /// <summary>
    /// Class representing the implementation of the comments endpoint.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/object/comments</cref>
    /// </see>
    public class FacebookCommentsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookCommentsRawEndpoint Raw {
            get { return Service.Client.Comments; }
        }

        #endregion

        #region Constructors

        internal FacebookCommentsEndpoint(FacebookService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the comment with specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the comment.</param>
        /// <returns>An instance of <see cref="FacebookGetCommentResponse"/> representing the response.</returns>
        public FacebookGetCommentResponse GetComment(string identifier) {
            return FacebookGetCommentResponse.ParseResponse(Raw.GetComment(identifier));
        }

        /// <summary>
        /// Gets information about the comment matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetCommentResponse"/> representing the response.</returns>
        public FacebookGetCommentResponse GetComment(FacebookGetCommentOptions options) {
            return FacebookGetCommentResponse.ParseResponse(Raw.GetComment(options));
        }

        /// <summary>
        /// Gets a list of comments for an object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the parent object.</param>
        /// <returns>An instance of <see cref="FacebookGetCommentsResponse"/> representing the response.</returns>
        public FacebookGetCommentsResponse GetComments(string identifier) {
            return FacebookGetCommentsResponse.ParseResponse(Raw.GetComments(identifier));
        }

        /// <summary>
        /// Gets a list of comments for an object with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the parent object.</param>
        /// <param name="limit">The maximum amount of comments to be returned per page.</param>
        /// <returns>An instance of <see cref="FacebookGetCommentsResponse"/> representing the response.</returns>
        public FacebookGetCommentsResponse GetComments(string identifier, int limit) {
            return FacebookGetCommentsResponse.ParseResponse(Raw.GetComments(identifier, limit));
        }

        /// <summary>
        /// Gets a list of comments for an object matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetCommentsResponse"/> representing the response.</returns>
        public FacebookGetCommentsResponse GetComments(FacebookGetCommentsOptions options) {
            if (options == null) throw new ArgumentException("options");
            return FacebookGetCommentsResponse.ParseResponse(Raw.GetComments(options));
        }

        #endregion

    }

}