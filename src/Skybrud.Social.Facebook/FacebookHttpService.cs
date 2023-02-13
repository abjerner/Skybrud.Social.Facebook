using System;
using Skybrud.Social.Facebook.Endpoints;
using Skybrud.Social.Facebook.OAuth;

namespace Skybrud.Social.Facebook {

    /// <summary>
    /// Class working as an entry point to the Facebook Graph API.
    /// </summary>
    public class FacebookHttpService {

        #region Properties

        /// <summary>
        /// Gets a reference to the internal OAuth client for communication with the Facebook API.
        /// </summary>
        public FacebookOAuthClient Client { get; }

        /// <summary>
        /// Gets a reference to the accounts endpoint.
        /// </summary>
        public FacebookAccountsEndpoint Accounts { get; }

        /// <summary>
        /// Gets a reference to the albums endpoint.
        /// </summary>
        public FacebookAlbumsEndpoint Albums { get; }

        /// <summary>
        /// Gets a reference to the apps endpoint.
        /// </summary>
        public FacebookApplicationsEndpoint Applications { get; }

        /// <summary>
        /// Gets a reference to the debug endpoint.
        /// </summary>
        public FacebookDebugEndpoint Debug { get; }

        /// <summary>
        /// Gets a reference to the comments endpoint.
        /// </summary>
        public FacebookCommentsEndpoint Comments { get; }

        /// <summary>
        /// Gets a reference to the events endpoint.
        /// </summary>
        public FacebookEventsEndpoint Events { get; }

        /// <summary>
        /// Gets a reference to the feed endpoint.
        /// </summary>
        public FacebookFeedEndpoint Feed { get; }

        /// <summary>
        /// Gets a reference to the likes endpoint.
        /// </summary>
        public FacebookLikesEndpoint Likes { get; }

        /// <summary>
        /// Gets a reference to the pages endpoint.
        /// </summary>
        public FacebookPagesEndpoint Pages { get; }

        /// <summary>
        /// Gets a reference to the photos endpoint.
        /// </summary>
        public FacebookPhotosEndpoint Photos { get; }

        /// <summary>
        /// Gets a reference to the posts endpoint.
        /// </summary>
        public FacebookPostsEndpoint Posts { get; }

        /// <summary>
        /// Gets a reference to the users endpoint.
        /// </summary>
        public FacebookUsersEndpoint Users { get; }

        #endregion

        #region Constructors

        private FacebookHttpService(FacebookOAuthClient client) {
            Client = client;
            Accounts = new FacebookAccountsEndpoint(this);
            Albums = new FacebookAlbumsEndpoint(this);
            Applications = new FacebookApplicationsEndpoint(this);
            Debug = new FacebookDebugEndpoint(this);
            Comments = new FacebookCommentsEndpoint(this);
            Events = new FacebookEventsEndpoint(this);
            Feed = new FacebookFeedEndpoint(this);
            Likes = new FacebookLikesEndpoint(this);
            Pages = new FacebookPagesEndpoint(this);
            Photos = new FacebookPhotosEndpoint(this);
            Posts = new FacebookPostsEndpoint(this);
            Users = new FacebookUsersEndpoint(this);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initialize a new service instance from the specified <paramref name="accessToken"/>. Internally a new OAuth
        /// client will be initialized from the access token.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        /// <returns>The created instance of <see cref="FacebookHttpService" />.</returns>
        public static FacebookHttpService CreateFromAccessToken(string accessToken) {
            return new FacebookHttpService(new FacebookOAuthClient(accessToken));
        }

        /// <summary>
        /// Initialize a new service instance from the specified OAuth <paramref name="client"/>.
        /// </summary>
        /// <param name="client">The OAuth client.</param>
        /// <returns>The created instance of <see cref="FacebookHttpService" />.</returns>
        public static FacebookHttpService CreateFromOAuthClient(FacebookOAuthClient client) {
            if (client == null) throw new ArgumentNullException(nameof(client));
            return new FacebookHttpService(client);
        }

        #endregion

    }

}