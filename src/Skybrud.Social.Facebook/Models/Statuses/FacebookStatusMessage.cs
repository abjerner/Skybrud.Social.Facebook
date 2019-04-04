using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Facebook.Models.Common;

namespace Skybrud.Social.Facebook.Models.Statuses {

    public class FacebookStatusMessage : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the status message.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets brief information about the entity (eg. user) that posted the status message.
        /// </summary>
        public FacebookEntity From { get; }

        /// <summary>
        /// Gets the text of the status message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets an array of all tags used in the message.
        /// </summary>
        public FacebookMessageTag[] MessageTags { get; }

        /// <summary>
        /// Gets brief information about the application used to post the status message. If the status message was
        /// posted directly from facebook.com, this property will return <c>null</c>.
        /// </summary>
        public FacebookEntity Application { get; }

        /// <summary>
        /// Gets the timestamp for when the status message was created.
        /// </summary>
        public DateTime CreatedTime { get; }

        /// <summary>
        /// ets the timestamp for when the status message was last updated.
        /// </summary>
        public DateTime UpdatedTime { get; }

        #endregion

        #region Constructors

        private FacebookStatusMessage(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            From = obj.GetObject("from", FacebookEntity.Parse);
            Message = obj.GetString("message");
            MessageTags = FacebookMessageTag.ParseMultiple(obj.GetObject("message_tags")) ?? new FacebookMessageTag[0];
            Application = obj.GetObject("from", FacebookEntity.Parse);
            CreatedTime = DateTime.Parse(obj.GetString("created_time"));
            UpdatedTime = DateTime.Parse(obj.GetString("updated_time"));
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookStatusMessage"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="FacebookStatusMessage"/>.</returns>
        public static FacebookStatusMessage Parse(JObject obj) {
            return obj == null ? null : new FacebookStatusMessage(obj);
        }

        #endregion

    }

}