using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Attachments {

    /// <summary>
    /// Class representing the target object of a Facebook attachment.
    /// </summary>
    public class FacebookAttachmentTarget : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the object in the attachment. An attachment may refer to an external URL, in which case an ID isn't available.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets whether the <see cref="Id"/> property was included in the response.
        /// </summary>
        public bool HasId => string.IsNullOrWhiteSpace(Id) == false;

        /// <summary>
        /// Gets the URL to the attachment.
        /// </summary>
        public string Url { get; }

        #endregion

        #region Constructors

        private FacebookAttachmentTarget(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Url = obj.GetString("url");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookAttachmentTarget"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookAttachmentTarget"/>.</returns>
        public static FacebookAttachmentTarget Parse(JObject obj) {
            return obj == null ? null : new FacebookAttachmentTarget(obj);
        }

        #endregion

    }

}