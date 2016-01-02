using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Likes {

    public class FacebookLike : FacebookObject {

        #region Properties

        /// <summary>
        /// The ID of the person.
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        /// The name of the person.
        /// </summary>
        public string Name { get; internal set; }

        #endregion

        #region Constructors

        private FacebookLike(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        public static FacebookLike Parse(JObject obj) {
            return obj == null ? null : new FacebookLike(obj);
        }

        #endregion

    }

}