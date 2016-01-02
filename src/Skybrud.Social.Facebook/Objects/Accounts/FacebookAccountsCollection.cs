using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Accounts {
    
    public class FacebookAccountsCollection : FacebookObject {

        #region Properties

        public FacebookAccount[] Data { get; private set; }

        public FacebookPaging Paging { get; private set; }

        #endregion

        #region Constructors

        private FacebookAccountsCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookAccount.Parse);
            Paging = obj.GetObject("paging", FacebookPaging.Parse);
        }

        #endregion

        #region Static methods

        public static FacebookAccountsCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookAccountsCollection(obj);
        }

        #endregion
    
    }

}