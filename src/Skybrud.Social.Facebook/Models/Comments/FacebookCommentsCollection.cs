using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Social.Facebook.Models.Pagination;
using Skybrud.Social.Facebook.Options.Comments;

namespace Skybrud.Social.Facebook.Models.Comments {

    /// <summary>
    /// Class representing the response to get the comments of a Facebook object.
    /// </summary>
    public class FacebookCommentsCollection : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets an array of comments.
        /// </summary>
        public FacebookComment[] Data { get; }

        /// <summary>
        /// Gets pagination information.
        /// </summary>
        public FacebookCursorBasedPagination Paging { get; }

        /// <summary>
        /// Gets a summary for all comments. The summary is only present in the response if
        /// <see cref="FacebookGetCommentsOptions.IncludeSummary"/> was <c>true</c> in the request options.
        /// </summary>
        public FacebookCommentsSummary Summary { get; }

        /// <summary>
        /// Gets whether the <see cref="Summary"/> property is present.
        /// </summary>
        public bool HasSummary => Summary != null;

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
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookCommentsCollection"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="FacebookCommentsCollection"/>.</returns>
        public static FacebookCommentsCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookCommentsCollection(obj);
        }

        #endregion

    }

}