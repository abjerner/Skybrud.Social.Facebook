using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Attachments {

    /// <summary>
    /// Class representing a Facebook attachment.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.12/attachment</cref>
    /// </see>
    public class FacebookAttachment : FacebookAttachmentBase {

        #region Properties
        
        /// <summary>
        /// Gets an array of all sub attachments within the attachment. Not all attachments have sub attachments.
        /// </summary>
        public FacebookAttachmentBase[] SubAttachments { get; }

        /// <summary>
        /// Gets whether the attachment has any sub attachments.
        /// </summary>
        public bool HasSubAttachments => SubAttachments.Length > 0;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookAttachment(JObject obj) : base(obj) {
            SubAttachments = obj.GetArrayItems("subattachments", FacebookAttachmentBase.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookAttachment"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookAttachment"/>.</returns>
        public new static FacebookAttachment Parse(JObject obj) {
            return obj == null ? null : new FacebookAttachment(obj);
        }

        #endregion

    }

}