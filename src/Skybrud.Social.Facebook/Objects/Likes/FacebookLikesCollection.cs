using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Pagination;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Likes {

    /// <summary>
    /// Class representing the response to get the likes of a Facebook object.
    /// </summary>
    public class FacebookLikesCollection : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets an array of likes.
        /// </summary>
        public FacebookLike[] Data { get; private set; }

        /// <summary>
        /// Gets pagination information.
        /// </summary>
        public FacebookCursorBasedPagination Paging { get; private set; }

        /// <summary>
        /// Gets a summary for all likes. The summary is only present in the response if <code>IncludeSummary</code>
        /// was <code>true</code> in the request options.
        /// </summary>
        public FacebookLikesSummary Summary { get; private set; }

        #endregion
        
        #region Constructors

        private FacebookLikesCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookLike.Parse);
            Paging = obj.GetObject("paging", FacebookCursorBasedPagination.Parse);
            Summary = obj.GetObject("summary", FacebookLikesSummary.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookLikesCollection"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="FacebookLikesCollection"/>.</returns>
        public static FacebookLikesCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookLikesCollection(obj);
        }

        #endregion

    }

}