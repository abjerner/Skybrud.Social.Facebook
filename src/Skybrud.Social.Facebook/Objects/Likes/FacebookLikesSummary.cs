using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Likes {

    public class FacebookLikesSummary : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the total number of people who liked.
        /// </summary>
        public int TotalCount { get; private set; }

        #endregion

        #region Constructors

        private FacebookLikesSummary(JObject obj) : base(obj) {
            TotalCount = obj.GetInt32("total_count");
        }

        #endregion

        #region Static methods

        public static FacebookLikesSummary Parse(JObject obj) {
            return obj == null ? null : new FacebookLikesSummary(obj);
        }

        #endregion

    }

}