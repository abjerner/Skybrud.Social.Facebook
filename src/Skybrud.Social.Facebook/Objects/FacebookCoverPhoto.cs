using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects {

    /// <summary>
    /// Class representing a cover photo of a user, page or similar.
    /// </summary>
    public class FacebookCoverPhoto : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the photo that represents the cover photo.
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        /// Gets the URL of the photo that represents the cover photo.
        /// </summary>
        public string Source { get; internal set; }

        /// <summary>
        /// Gets the vertical offset in pixels of the photo from the bottom.
        /// </summary>
        public int OffsetY { get; internal set; }

        /// <summary>
        /// Gets the horizontal offset in pixels of the photo from the left.
        /// </summary>
        public int OffsetX { get; internal set; }

        #endregion

        #region Constructors

        private FacebookCoverPhoto(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Source = obj.GetString("source");
            OffsetY = obj.GetInt32("offset_y");
            OffsetX = obj.GetInt32("offset_x");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookCoverPhoto"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="FacebookCoverPhoto"/>.</returns>
        public static FacebookCoverPhoto Parse(JObject obj) {
            return obj == null ? null : new FacebookCoverPhoto(obj);
        }

        #endregion

    }

}