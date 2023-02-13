using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Comments {

    /// <summary>
    /// Class representing a summary for the comments of a given object.
    /// </summary>
    public class FacebookCommentsSummary : FacebookObject {

        #region Properties

        /// <summary>
        /// Order in which comments were returned. <see cref="FacebookCommentsOrder.Ranked"/> indicates the most
        /// interesting comments are sorted first. <see cref="FacebookCommentsOrder.Chronological"/> indicates comments
        /// are sorted by the oldest comments first.
        /// </summary>
        public FacebookCommentsOrder Order { get; }

        /// <summary>
        /// Gets the count of comments on this object. It is important to note that this value is changed depending on
        /// the filter modifier being used (where comment replies are available):
        ///
        /// - <c>toplevel</c> - this is the default, returns all top-level comments in either <c>ranked</c>
        /// or <c>chronological</c> order depending on how the comments are ordered on Facebook. This filter is
        /// useful for displaying comments in the same structure as they appear on Facebook.
        ///
        /// - <c>stream</c> - all-level comments in <c>chronological</c> order. This filter is useful for
        /// comment moderation tools where it is helpful to see a chronological list of all comments.
        /// </summary>
        public int TotalCount { get; }

        /// <summary>
        /// Gets whether the authenticated user can post on the parent object.
        /// </summary>
        public bool CanComment { get; }

        #endregion

        #region Constructors

        private FacebookCommentsSummary(JObject obj) : base(obj) {
            Order = obj.GetEnum<FacebookCommentsOrder>("order");
            TotalCount = obj.GetInt32("total_count");
            CanComment = obj.GetBoolean("can_comment");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookCommentsSummary"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="Newtonsoft.Json.Linq.JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="FacebookCommentsSummary"/>.</returns>
        public static FacebookCommentsSummary Parse(JObject obj) {
            return obj == null ? null : new FacebookCommentsSummary(obj);
        }

        #endregion

    }

}