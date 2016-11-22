using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Pagination;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Photos {

    public class FacebookPhotosCollection : FacebookObject {

        #region Properties

        public FacebookPhoto[] Data { get; private set; }

        public FacebookCursorBasedPagination Paging { get; private set; }

        #endregion
        
        #region Constructors

        private FacebookPhotosCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookPhoto.Parse);
            Paging = obj.GetObject("paging", FacebookCursorBasedPagination.Parse);
        }

        #endregion

        #region Static methods

        public static FacebookPhotosCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookPhotosCollection(obj);
        }

        #endregion
    
    }

}