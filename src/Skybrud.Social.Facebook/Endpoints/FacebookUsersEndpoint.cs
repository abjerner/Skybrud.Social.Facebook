using Skybrud.Social.Facebook.Endpoints.Raw;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.User;
using Skybrud.Social.Facebook.Responses.Users;

namespace Skybrud.Social.Facebook.Endpoints {

    /// <summary>
    /// Class representing the implementation of the users endpoint.
    /// </summary>
    public class FacebookUsersEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Facebook service.
        /// </summary>
        public FacebookService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public FacebookUsersRawEndpoint Raw => Service.Client.Users;

        #endregion

        #region Constructors

        internal FacebookUsersEndpoint(FacebookService service) {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets information about the user with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the user.</param>
        /// <returns>An instance of <see cref="FacebookGetUserResponse"/> representing the response.</returns>
        public FacebookGetUserResponse GetUser(string identifier) {
            return FacebookGetUserResponse.ParseResponse(Raw.GetUser(identifier));
        }

        /// <summary>
        /// Gets information about the user with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the user.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        /// <returns>An instance of <see cref="FacebookGetUserResponse"/> representing the response.</returns>
        public FacebookGetUserResponse GetUser(string identifier, FacebookFieldsCollection fields) {
            return FacebookGetUserResponse.ParseResponse(Raw.GetUser(identifier, fields));
        }

        /// <summary>
        /// Gets information about the user matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="FacebookGetUserResponse"/> representing the response.</returns>
        public FacebookGetUserResponse GetUser(FacebookGetUserOptions options) {
            return FacebookGetUserResponse.ParseResponse(Raw.GetUser(options));
        }

        #endregion

    }

}