using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Pagination;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Comments {
    
    /// <summary>
    /// Class representing the response to get the comments of a Facebook object.
    /// </summary>
    public class FacebookCommentsCollection : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets an array of comments.
        /// </summary>
        public FacebookComment[] Data { get; private set; }

        /// <summary>
        /// Gets pagination information.
        /// </summary>
        public FacebookCursorBasedPagination Paging { get; private set; }

        /// <summary>
        /// Gets a summary for all comments. The summary is only present in the response if <code>IncludeSummary</code>
        /// was <code>TRUE</code> in the request options.
        /// </summary>
        public FacebookCommentsSummary Summary { get; private set; }

        /// <summary>
        /// Gets whether the <code>Summary</code> property is present.
        /// </summary>
        public bool HasSummary {
            get { return Summary != null; }
        }

        #endregion
        
        #region Constructors

        private FacebookCommentsCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookComment.Parse);
            Paging = obj.GetObject("paging", FacebookCursorBasedPagination.Parse);
            Summary = obj.GetObject("summary", FacebookCommentsSummary.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookCommentsCollection"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="FacebookCommentsCollection"/>.</returns>
        public static FacebookCommentsCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookCommentsCollection(obj);
        }

        #endregion

    }

}