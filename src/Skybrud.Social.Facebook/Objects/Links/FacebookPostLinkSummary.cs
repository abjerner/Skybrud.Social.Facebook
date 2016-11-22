using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Links {
    
    public class FacebookPostLinkSummary : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the link.
        /// </summary>
        public string Id { get; private set; }

        #endregion

        #region Constructors

        private FacebookPostLinkSummary(JObject obj) : base(obj) {
            Id = obj.GetString("id");
        }

        #endregion

        #region Static methods

        public static FacebookPostLinkSummary Parse(JObject obj) {
            return obj == null ? null : new FacebookPostLinkSummary(obj);
        }

        #endregion

    }

}