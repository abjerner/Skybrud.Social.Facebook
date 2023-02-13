using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Social.Facebook.Models.Pagination;
using Skybrud.Social.Facebook.Options.Likes;

namespace Skybrud.Social.Facebook.Models.Likes {

    /// <summary>
    /// Class representing the response to get the likes of a Facebook object.
    /// </summary>
    public class FacebookLikesCollection : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets an array of likes.
        /// </summary>
        public FacebookLike[] Data { get; }

        /// <summary>
        /// Gets pagination information.
        /// </summary>
        public FacebookCursorBasedPagination Paging { get; }

        /// <summary>
        /// Gets a summary for all likes. The summary is only present in the response if
        /// <see cref="FacebookGetLikesOptions.IncludeSummary"/> was <c>true</c> in the request options.
        /// </summary>
        public FacebookLikesSummary Summary { get; }

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
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookLikesCollection"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookLikesCollection"/>.</returns>
        public static FacebookLikesCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookLikesCollection(obj);
        }

        #endregion

    }

}