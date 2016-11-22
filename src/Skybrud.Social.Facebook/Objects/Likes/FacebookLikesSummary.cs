using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Likes {

    /// <summary>
    /// Class representing a summary for the likes of a given object.
    /// </summary>
    public class FacebookLikesSummary : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the total number of people who liked the parent object.
        /// </summary>
        public int TotalCount { get; private set; }

        /// <summary>
        /// Gets whether the authenticated user can like the parent object.
        /// </summary>
        public bool CanLike { get; private set; }

        /// <summary>
        /// Gets whether the authenticated user has liked the parent object.
        /// </summary>
        public bool HasLiked { get; private set; }

        #endregion

        #region Constructors

        private FacebookLikesSummary(JObject obj) : base(obj) {
            TotalCount = obj.GetInt32("total_count");
            CanLike = obj.GetBoolean("can_like");
            HasLiked = obj.GetBoolean("has_liked");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookLikesSummary"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="Newtonsoft.Json.Linq.JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="FacebookLikesSummary"/>.</returns>
        public static FacebookLikesSummary Parse(JObject obj) {
            return obj == null ? null : new FacebookLikesSummary(obj);
        }

        #endregion

    }

}