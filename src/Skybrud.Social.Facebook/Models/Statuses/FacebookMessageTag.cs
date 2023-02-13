using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Statuses {

    public class FacebookMessageTag : FacebookObject {

        #region Properties

        public string Id { get; }

        public string Name { get; }

        public string Type { get; }

        public int Offset { get; }

        public int Length { get; }

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