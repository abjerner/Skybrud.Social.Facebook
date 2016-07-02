using System;
using System.Collections.Specialized;

namespace Skybrud.Social.Facebook.Objects.Authentication {
    
    /// <summary>
    /// Class describing an access token received from the Facebook Graph API.
    /// </summary>
    public class FacebookToken {

        #region Properties

        /// <summary>
        /// Gets the access token. Depending on the request, the access token can be either a user access token or an
        /// app access token.
        /// </summary>
        public string AccessToken { get; private set; }

        /// <summary>
        /// Gets an instance of <see cref="TimeSpan"/> representing the time until the access token will expire. If
        /// <see cref="TimeSpan.TotalSeconds"/> is <code>0</code>, the token will not expire (eg. an app access token).
        /// </summary>
        public TimeSpan ExpiresIn { get; private set; }

        #endregion

        #region Constructors

        private FacebookToken() { }

        #endregion

        /// <summary>
        /// Parses the specified <code>str</code> into an instance of <see cref="FacebookToken"/>.
        /// </summary>
        /// <param name="str">The string to be parsed.</param>
        /// <returns>Returns an instance of <see cref="FacebookToken"/>.</returns>
        public static FacebookToken Parse(string str) {
            
            // Parse the contents
            NameValueCollection body = SocialUtils.Misc.ParseQueryString(str);

            // Get the amount of seconds until the access token expires (0 = doesn't expire)
            int expires = body["expires"] == null ? 0 : Int32.Parse(body["expires"]);

            // Initialize the response body
            return new FacebookToken {
                AccessToken = body["access_token"],
                ExpiresIn = TimeSpan.FromSeconds(expires)
            };

        }

    }

}