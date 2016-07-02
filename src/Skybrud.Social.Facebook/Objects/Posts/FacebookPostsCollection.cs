using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Pagination;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Posts {
    
    public class FacebookPostsCollection : FacebookObject {

        #region Properties

        public FacebookPost[] Data { get; private set; }

        public FacebookPaging Paging { get; private set; }

        #endregion

        #region Constructors

        private FacebookPostsCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookPost.Parse);
            Paging = obj.GetObject("paging", FacebookPaging.Parse);
        }

        #endregion

        #region Static methods

        public static FacebookPostsCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookPostsCollection(obj);
        }

        #endregion
    
    }

}