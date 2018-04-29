using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Attachments {

    /// <summary>
    /// Class with media data about a Facebook attachment.
    /// </summary>
    public class FacebookAttachmentMedia : FacebookObject {

        #region Properties
        
        /// <summary>
        /// Gets a reference to the image of the attachment.
        /// </summary>
        public FacebookAttachmentImage Image { get; }
        
        #endregion

        #region Constructors

        private FacebookAttachmentMedia(JObject obj) : base(obj) {
            Image = obj.GetObject("image", FacebookAttachmentImage.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookAttachmentMedia"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookAttachmentMedia"/>.</returns>
        public static FacebookAttachmentMedia Parse(JObject obj) {
            return obj == null ? null : new FacebookAttachmentMedia(obj);
        }

        #endregion

    }

}