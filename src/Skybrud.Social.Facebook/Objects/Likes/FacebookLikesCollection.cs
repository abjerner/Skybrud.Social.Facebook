using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Pagination;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Likes {
    
    public class FacebookLikesCollection : FacebookObject {

        #region Properties

        public FacebookLike[] Data { get; private set; }

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

        public static FacebookLikesCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookLikesCollection(obj);
        }

        #endregion

    }

}