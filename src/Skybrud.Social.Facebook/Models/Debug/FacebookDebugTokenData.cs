using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Extensions;
using Skybrud.Social.Facebook.Scopes;

namespace Skybrud.Social.Facebook.Models.Debug {

    /// <summary>
    /// Class representing the metadata about a given access token.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v3.2/debug_token#read</cref>
    /// </see>
    public class FacebookDebugTokenData : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the application this access token is for.
        /// </summary>
        public string AppId { get; }

        /// <summary>
        /// Gets the name of the application this access token is for.
        /// </summary>
        public string Application { get; }

        /// <summary>
        /// Gets the timestamp for when the token will expire.
        /// </summary>
        public EssentialsTime ExpiresAt { get; }

        /// <summary>
        /// Gets the timestamp for when app's access to user data expires.
        /// </summary>
        public EssentialsTime DataAccessExpiresAt { get; }

        /// <summary>
        /// Gets whether the the access token is valid.
        /// </summary>
        public bool IsValid { get; }

        /// <summary>
        /// Gets the timestamp for when the token was issued.
        /// </summary>
        public EssentialsTime IssuedAt { get; }

        /// <summary>
        /// Gets the ID of the user. The ID is only present for user access tokens.
        /// </summary>
        public string UserId { get; }

        /// <summary>
        /// For user access tokens, the user will grant the app one or multiple scopes. This property will be an array
        /// of all granted scopes. For any other types of access tokens, this array will be empty.
        /// </summary>
        public FacebookScope[] Scopes { get; }

        #endregion

        #region Constructors

        private FacebookDebugTokenData(JObject obj) : base(obj) {
            AppId = obj.GetString("app_id");
            // TODO: Add support for the "type" property (not documented by Facebook)
            Application = obj.GetString("application");
            ExpiresAt = ParseUnixTimestamp(obj, "expires_at");
            DataAccessExpiresAt = ParseUnixTimestamp(obj, "data_access_expires_at");
            IsValid = obj.GetBoolean("is_valid");
            IssuedAt = obj.HasValue("issued_at") ? obj.GetInt64("issued_at", EssentialsTime.FromUnixTimestamp) : null;
            // TODO: Add support for the "metadata" property
            // TODO: Add support for the "profile_id" property
            UserId = obj.GetString("user_id");
            Scopes = ParseScopes(obj);

        }

        #endregion

        #region Member methods

        private FacebookScope[] ParseScopes(JObject obj) {
            return (
                from alias in obj.GetStringArray("scopes")
                select FacebookScope.GetScope(alias) ?? new FacebookScope(alias, alias)
            ).ToArray();
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookDebugTokenData"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookDebugTokenData"/>.</returns>
        public static FacebookDebugTokenData Parse(JObject obj) {
            return obj == null ? null : new FacebookDebugTokenData(obj);
        }

        #endregion

    }

}