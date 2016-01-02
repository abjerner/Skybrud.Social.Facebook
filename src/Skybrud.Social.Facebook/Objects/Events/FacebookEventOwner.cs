using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Events {

    public class FacebookEventOwner : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the user or page.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the user or page.
        /// </summary>
        public string Name { get; private set; }

        #endregion

        #region Constructors

        private FacebookEventOwner(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        public static FacebookEventOwner Parse(JObject obj) {
            return obj == null ? null : new FacebookEventOwner(obj);
        }

        #endregion

    }

}