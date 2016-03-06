using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects {

    public class FacebookStatusMessage : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the status message.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets brief information about the entity (eg. user) that posted the status message.
        /// </summary>
        public FacebookEntity From { get; private set; }

        /// <summary>
        /// Gets the text of the status message.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Gets an array of all tags used in the message.
        /// </summary>
        public FacebookMessageTag[] MessageTags { get; private set; }

        /// <summary>
        /// Gets brief information about the application used to post the status message. If the status message was
        /// posted directly from facebook.com, this property will return <code>null</code>.
        /// </summary>
        public FacebookEntity Application { get; private set; }

        /// <summary>
        /// Gets the timestamp for when the status message was created.
        /// </summary>
        public DateTime CreatedTime { get; private set; }

        /// <summary>
        /// ets the timestamp for when the status message was last updated.
        /// </summary>
        public DateTime UpdatedTime { get; private set; }

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
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookStatusMessage"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="FacebookStatusMessage"/>.</returns>
        public static FacebookStatusMessage Parse(JObject obj) {
            return obj == null ? null : new FacebookStatusMessage(obj);
        }

        #endregion

    }

}