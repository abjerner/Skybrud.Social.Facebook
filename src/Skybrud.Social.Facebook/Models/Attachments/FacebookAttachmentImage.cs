using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Attachments {

    /// <summary>
    /// Class representing an image of a Facebook attachment.
    /// </summary>
    public class FacebookAttachmentImage : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the height of the image.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Gets the source URL of the image.
        /// </summary>
        public string Src { get; }

        /// <summary>
        /// Gets the width of the image.
        /// </summary>
        public int Width { get; }

        #endregion

        #region Constructors

        private FacebookAttachmentImage(JObject obj) : base(obj) {
            Height = obj.GetInt32("height");
            Src = obj.GetString("src");
            Width = obj.GetInt32("width");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookAttachmentImage"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookAttachmentImage"/>.</returns>
        public static FacebookAttachmentImage Parse(JObject obj) {
            return obj == null ? null : new FacebookAttachmentImage(obj);
        }

        #endregion

    }

}