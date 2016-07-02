using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Pages {
    
    public class FacebookPageCategory : FacebookObject {

        #region Properties

        public string Id { get; internal set; }

        public string Name { get; internal set; }

        #endregion

        #region Constructors

        private FacebookPageCategory(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        public static FacebookPageCategory Parse(JObject obj) {
            return obj == null ? null : new FacebookPageCategory(obj);
        }

        #endregion

    }

}