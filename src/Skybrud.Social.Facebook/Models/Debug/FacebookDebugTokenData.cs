using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Scopes;

namespace Skybrud.Social.Facebook.Models.Debug {
    
    /// <summary>
    /// Class representing the metadata about a given access token.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.5/debug_token#read</cref>
    /// </see>
    public class FacebookDebugTokenData : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the application this access token is for.
        /// </summary>
        public long AppId { get; }

        /// <summary>
        /// Gets the name of the application this access token is for.
        /// </summary>
        public string Application { get; }

        /// <summary>
        /// Gets the timestamp for when the token will expire.
        /// </summary>
        public EssentialsDateTime ExpiresAt { get; }

        /// <summary>
        /// Gets whether the the access token is valid.
        /// </summary>
        public bool IsValid { get; }

        /// <summary>
        /// Gets the timestamp for when the token was issued.
        /// </summary>
        public EssentialsDateTime IssuedAt { get; }

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

            // If an access token doesn't have an expire date, it may be specified as "0". In other scenarios, the
            // property is not present at all. In either case, we should set the "ExpiresAt" property to "NULL".
            EssentialsDateTime expiresAt = null;
            if (obj.HasValue("expires_at")) {
                int value = obj.GetInt32("expires_at");
                if (value > 0) expiresAt = EssentialsDateTime.FromUnixTimestamp(value);
            }

            // Parse the array of scopes
            FacebookScope[] scopes = (
                from name in obj.GetArray("scopes", x => x.ToString()) ?? new string[0]
                select FacebookScope.GetScope(name) ?? new FacebookScope(name)
            ).ToArray();

            // Populate the properties
            AppId = obj.GetInt64("app_id");
            Application = obj.GetString("application");
            ExpiresAt = expiresAt;
            IsValid = obj.GetBoolean("is_valid");
            IssuedAt = obj.HasValue("issued_at") ? obj.GetInt64("issued_at", EssentialsDateTime.FromUnixTimestamp) : null;
            UserId = obj.GetString("user_id");
            Scopes = scopes;

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookDebugTokenData"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="FacebookDebugTokenData"/>.</returns>
        public static FacebookDebugTokenData Parse(JObject obj) {
            return obj == null ? null : new FacebookDebugTokenData(obj);
        }

        #endregion

    }

}