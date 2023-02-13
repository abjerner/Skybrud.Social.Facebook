using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Facebook.Models.Common.Tags;

namespace Skybrud.Social.Facebook.Models.Attachments {

    /// <summary>
    /// Class representing a Facebook attachment.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.12/attachment</cref>
    /// </see>
    public class FacebookAttachmentBase : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the text accompanying the attachment.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets whether the <see cref="Description"/> property was included in the response.
        /// </summary>
        public bool HasDescription => string.IsNullOrWhiteSpace(Description) == false;

        /// <summary>
        /// Gets an array of the profiles tagged in the <see cref="Description"/> property.
        /// </summary>
        public FacebookProfileTag[] DescriptionTags { get; }

        /// <summary>
        /// Gets whether the <see cref="DescriptionTags"/> property was included in the response.
        /// </summary>
        public bool HasDescriptionTagsTags => DescriptionTags.Length > 0;

        /// <summary>
        /// Gets a reference to the media data of the attachment.
        /// </summary>
        public FacebookAttachmentMedia Media { get; }

        /// <summary>
        /// Gets whether the <see cref="Media"/> property was included in the response.
        /// </summary>
        public bool HasMedia => Media != null;

        /// <summary>
        /// Gets the title of the attachment.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the type of the attachment.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets the URL of the attachment.
        /// </summary>
        public string Url { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        protected FacebookAttachmentBase(JObject obj) : base(obj) {
            Description = obj.GetString("id");
            DescriptionTags = obj.GetArrayItems("description_tags", FacebookProfileTag.Parse);
            Media = obj.GetObject("media", FacebookAttachmentMedia.Parse);
            Title = obj.GetString("title");
            Type = obj.GetString("type");
            Url = obj.GetString("url");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookAttachmentBase"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookAttachmentBase"/>.</returns>
        public static FacebookAttachmentBase Parse(JObject obj) {
            return obj == null ? null : new FacebookAttachmentBase(obj);
        }

        #endregion

    }

}