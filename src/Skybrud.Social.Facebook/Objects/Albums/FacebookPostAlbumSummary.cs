using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Albums {
    
    public class FacebookPostAlbumSummary : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the album.
        /// </summary>
        public string Id { get; private set; }

        #endregion

        #region Constructors

        private FacebookPostAlbumSummary(JObject obj) : base(obj) {
            Id = obj.GetString("id");
        }

        #endregion

        #region Static methods

        public static FacebookPostAlbumSummary Parse(JObject obj) {
            return obj == null ? null : new FacebookPostAlbumSummary(obj);
        }

        #endregion

    }

}