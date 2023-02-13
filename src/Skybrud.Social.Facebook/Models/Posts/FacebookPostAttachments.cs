using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Social.Facebook.Models.Attachments;

namespace Skybrud.Social.Facebook.Models.Posts {

    /// <summary>
    /// Class representing a collection of attachments witin a Facebook post.
    /// </summary>
    public class FacebookPostAttachments : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets an array of the attachments within the collection.
        /// </summary>
        public FacebookAttachment[] Data { get; }

        /// <summary>
        /// Gets the amount of attachments within the collection.
        /// </summary>
        public int Count => Data.Length;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookPostAttachments(JObject obj) : base(obj) {
            Data = obj.GetArrayItems("data", FacebookAttachment.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookPostAttachments"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPostAttachments"/>.</returns>
        public static FacebookPostAttachments Parse(JObject obj) {
            return obj == null ? null : new FacebookPostAttachments(obj);
        }

        #endregion

    }

}