using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Pages {

    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/accounts/</cref>
    /// </see>
    public class FacebookPageListSummary : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the total number of connected pages.
        /// </summary>
        public int TotalCount { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/> object.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookPageListSummary(JObject json) : base(json) {
            TotalCount = json.GetInt32("total_count");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="FacebookPageListSummary"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPageListSummary"/>.</returns>
        [return: NotNullIfNotNull("json")]
        public static FacebookPageListSummary? Parse(JObject? json) {
            return json == null ? null : new FacebookPageListSummary(json);
        }

        #endregion

    }

}