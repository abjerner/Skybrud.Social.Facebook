using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Photos {
    
    public class FacebookPostPhotoSummary : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the photo.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the ID of the post about the photo.
        /// </summary>
        public string PostId { get; private set; }

        #endregion

        #region Constructors

        private FacebookPostPhotoSummary(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            PostId = obj.GetString("post_id");
        }

        #endregion

        #region Static methods

        public static FacebookPostPhotoSummary Parse(JObject obj) {
            return obj == null ? null : new FacebookPostPhotoSummary(obj);
        }

        #endregion

    }

}