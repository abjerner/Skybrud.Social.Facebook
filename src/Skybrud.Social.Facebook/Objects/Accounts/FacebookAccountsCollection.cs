using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Pagination;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Accounts {

    /// <summary>
    /// Class representing a collection of accounts as returned by the Facebook Graph API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/accounts/</cref>
    /// </see>
    public class FacebookAccountsCollection : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets an array of the <see cref="FacebookAccount"/> returned in the response.
        /// </summary>
        public FacebookAccount[] Data { get; private set; }

        /// <summary>
        /// Gets pagination information about the response.
        /// </summary>
        public Skybrud.Social.Facebook.Objects.Pagination.FacebookCursorBasedPagination Paging { get; private set; }

        /// <summary>
        /// Gets a summary about the collection. Use <see cref="HasSummary"/> to check whether the summary was included in the response.
        /// </summary>
        public FacebookAccountsSummary Summary { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Summary"/> property was included in the response.
        /// </summary>
        public bool HasSummary {
            get { return Summary != null; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookAccountsCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookAccount.Parse);
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