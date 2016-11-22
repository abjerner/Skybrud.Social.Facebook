using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Pagination;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Links {

    public class FacebookLinksCollection : FacebookObject {

        #region Properties

        public FacebookLink[] Data { get; private set; }

        public FacebookCursorBasedPagination Paging { get; private set; }

        #endregion
        
        #region Constructors

        private FacebookLinksCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookLink.Parse);
            Paging = obj.GetObject("paging", FacebookCursorBasedPagination.Parse);
        }

        #endregion

        #region Static methods

        public static FacebookLinksCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookLinksCollection(obj);
        }

        #endregion
    
    }

}