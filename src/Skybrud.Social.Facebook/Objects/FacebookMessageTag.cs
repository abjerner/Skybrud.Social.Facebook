using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects {

    public class FacebookMessageTag : FacebookObject {

        #region Properties

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Offset { get; private set; }
        public int Length { get; private set; }

        #endregion

        #region Constructors

        private FacebookMessageTag(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
            Type = obj.GetString("type");
            Offset = obj.GetInt32("offset");
            Length = obj.GetInt32("length");
        }

        #endregion

        #region Static methods

        public static FacebookMessageTag Parse(JObject obj) {
            return obj == null ? null : new FacebookMessageTag(obj);
        }

        public static FacebookMessageTag[] ParseMultiple(JObject obj) {
            if (obj == null) return null;
            List<FacebookMessageTag> temp = new List<FacebookMessageTag>();
            foreach (JProperty property in obj.Properties()) {
                temp.AddRange(obj.GetArray(property.Name, Parse));
            }
            return temp.ToArray();
        }

        #endregion

    }

}