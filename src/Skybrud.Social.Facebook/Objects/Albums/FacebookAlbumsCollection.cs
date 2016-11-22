using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Pagination;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Albums {
    
    public class FacebookAlbumsCollection : FacebookObject {

        #region Properties

        public FacebookAlbum[] Data { get; private set; }

        public FacebookCursorBasedPagination Paging { get; private set; }

        #endregion

        #region Constructors

        private FacebookAlbumsCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookAlbum.Parse);
            Paging = obj.GetObject("paging", FacebookCursorBasedPagination.Parse);
        }

        #endregion

        #region Static methods

        public static FacebookAlbumsCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookAlbumsCollection(obj);
        }

        #endregion
    
    }

}