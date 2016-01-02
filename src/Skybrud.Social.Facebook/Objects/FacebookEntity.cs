using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects {

    public class FacebookEntity : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the object.
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        /// Gets the name of the object.
        /// </summary>
        public string Name { get; internal set; }

        #endregion

        #region Constructors

        private FacebookEntity(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        public static FacebookEntity Parse(JObject obj) {
            return obj == null ? null : new FacebookEntity(obj);
        }

        #endregion

    }

}