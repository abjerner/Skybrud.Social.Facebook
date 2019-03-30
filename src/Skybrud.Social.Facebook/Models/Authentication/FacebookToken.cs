using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Authentication {
    
    /// <summary>
    /// Class describing an access token received from the Facebook Graph API.
    /// </summary>
    public class FacebookToken : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the access token. Depending on the request, the access token can be either a user access token or an
        /// app access token.
        /// </summary>
        public string AccessToken { get; }

        /// <summary>
        /// Gets the type of the access token. Given the authentication flows supported by Skybrud.Social, this will
        /// always be <code>bearer</code>.
        /// </summary>
        public string TokenType { get; }

        /// <summary>
        /// Gets an instance of <see cref="TimeSpan"/> representing the time until the access token will expire. If
        /// <see cref="TimeSpan.TotalSeconds"/> is <code>0</code>, the token will not expire (eg. an app access token).
        /// </summary>
        public TimeSpan ExpiresIn { get; }

        #endregion

        #region Constructors

        private FacebookToken(JObject obj) : base(obj) {
            AccessToken = obj.GetString("access_token");
            TokenType = obj.GetString("token_type");
            ExpiresIn = obj.GetDouble("expires_in", TimeSpan.FromSeconds);
        }

        #endregion

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookToken"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookToken"/>.</returns>
        public static FacebookToken Parse(JObject obj) {
            return obj == null ? null : new FacebookToken(obj);
        }

    }

}