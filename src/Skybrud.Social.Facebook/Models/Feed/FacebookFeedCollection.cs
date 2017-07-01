using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Facebook.Models.Pagination;

namespace Skybrud.Social.Facebook.Models.Feed {
    
    public class FacebookFeedCollection : FacebookObject {

        #region Properties

        public FacebookFeedEntry[] Data { get; private set; }

        public FacebookPaging Paging { get; private set; }

        #endregion

        #region Constructors

        private FacebookFeedCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookFeedEntry.Parse);
            Paging = obj.GetObject("paging", FacebookPaging.Parse);
        }

        #endregion

        #region Static methods

        public static FacebookFeedCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookFeedCollection(obj);
        }

        #endregion
    
    }

}