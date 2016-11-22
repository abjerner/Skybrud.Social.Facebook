using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Posts {
    
    public class FacebookPostProperties : FacebookObject {

        #region Properties

        public string Name { get; internal set; }
        public string Text { get; internal set; }
        public string Href { get; internal set; }

        #endregion

        #region Constructors

        private FacebookPostProperties(JObject obj) : base(obj) {
            Name = obj.GetString("name");
            Text = obj.GetString("text");
            Href = obj.GetString("href");
        }

        #endregion

        #region Static methods

        public static FacebookPostProperties Parse(JObject obj) {
            return obj == null ? null : new FacebookPostProperties(obj);
        }

        #endregion

    }

}