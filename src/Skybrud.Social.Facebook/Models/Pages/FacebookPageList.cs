using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Social.Facebook.Models.Common;
using Skybrud.Social.Facebook.Models.Pagination;

namespace Skybrud.Social.Facebook.Models.Pages {

    /// <summary>
    /// Class representing a collection of accounts/pages as returned by the Facebook Graph API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/accounts/</cref>
    /// </see>
    public class FacebookPageList : FacebookObject, IFacebookList<FacebookPage> {

        #region Properties

        /// <summary>
        /// Gets an array of the <see cref="FacebookPage"/> returned in the response.
        /// </summary>
        public IReadOnlyCollection<FacebookPage> Data { get; }

        /// <summary>
        /// Gets pagination information about the response.
        /// </summary>
        public FacebookCursorBasedPagination Paging { get; }

        /// <summary>
        /// Gets a summary about the collection.
        /// </summary>
        public FacebookPageListSummary? Summary { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="json"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookPageList(JObject json) : base(json) {
            Data = json.GetArrayItems("data", FacebookPage.Parse);
            Paging = json.GetObject("paging", FacebookCursorBasedPagination.Parse)!;
            Summary = json.GetObject("summary", FacebookPageListSummary.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="FacebookPageList"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPageList"/>.</returns>
        [return: NotNullIfNotNull("json")]
        public static FacebookPageList? Parse(JObject? json) {
            return json == null ? null : new FacebookPageList(json);
        }

        #endregion

    }

}