using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Accounts {

    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/accounts/</cref>
    /// </see>
    public class FacebookAccountsSummary : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the total number of connected pages.
        /// </summary>
        public int TotalCount { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookAccountsSummary(JObject obj) : base(obj) {
            TotalCount = obj.GetInt32("total_count");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookAccountsSummary"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookAccountsSummary"/>.</returns>
        public static FacebookAccountsSummary Parse(JObject obj) {
            return obj == null ? null : new FacebookAccountsSummary(obj);
        }

        #endregion

    }

}