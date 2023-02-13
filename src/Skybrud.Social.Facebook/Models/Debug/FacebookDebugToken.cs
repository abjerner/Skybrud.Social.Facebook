using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Debug {

    /// <summary>
    /// Class representing the response body of a call to get metadata about a given access token.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v3.2/debug_token#read</cref>
    /// </see>
    public class FacebookDebugToken : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets a referennce to the metadata about the access token.
        /// </summary>
        public FacebookDebugTokenData Data { get; }

        #endregion

        #region Constructors

        private FacebookDebugToken(JObject obj) : base(obj) {
            Data = obj.GetObject("data", FacebookDebugTokenData.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookDebugToken"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookDebugToken"/>.</returns>
        public static FacebookDebugToken Parse(JObject obj) {
            return obj == null ? null : new FacebookDebugToken(obj);
        }

        #endregion

    }

}