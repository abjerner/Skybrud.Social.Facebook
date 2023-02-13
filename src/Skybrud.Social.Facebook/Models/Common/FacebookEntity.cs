using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Common {

    public class FacebookEntity : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the object.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the name of the object.
        /// </summary>
        public string Name { get; }

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