using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Facebook.Models.Pages;
using Skybrud.Social.Facebook.Models.Pagination;

namespace Skybrud.Social.Facebook.Models.Accounts {

    /// <summary>
    /// Class representing a collection of accounts/pages as returned by the Facebook Graph API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/accounts/</cref>
    /// </see>
    public class FacebookAccountsCollection : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets an array of the <see cref="FacebookPage"/> returned in the response.
        /// </summary>
        public FacebookPage[] Data { get; }

        /// <summary>
        /// Gets pagination information about the response.
        /// </summary>
        public FacebookCursorBasedPagination Paging { get; }

        /// <summary>
        /// Gets a summary about the collection. Use <see cref="HasSummary"/> to check whether the summary was included in the response.
        /// </summary>
        public FacebookAccountsSummary Summary { get; }

        /// <summary>
        /// Gets whether the <see cref="Summary"/> property was included in the response.
        /// </summary>
        public bool HasSummary => Summary != null;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookAccountsCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookPage.Parse);
            Paging = obj.GetObject("paging", FacebookCursorBasedPagination.Parse);
            Summary = obj.GetObject("summary", FacebookAccountsSummary.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookAccountsCollection"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookAccountsCollection"/>.</returns>
        public static FacebookAccountsCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookAccountsCollection(obj);
        }

        #endregion
    
    }

}