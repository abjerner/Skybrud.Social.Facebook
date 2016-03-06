using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Common {
    
    public class FacebookPlace : FacebookObject {

        #region Properties

        public string Id { get; private set; }

        public string Name { get; private set; }

        public FacebookLocation Location { get; private set; }

        #endregion

        #region Constructor

        private FacebookPlace(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
            Location = obj.GetObject("location", FacebookLocation.Parse);
        }

        #endregion

        #region Static methods

        public static FacebookPlace Parse(JObject obj) {
            return obj == null ? null : new FacebookPlace(obj);
        }

        #endregion

    }

}