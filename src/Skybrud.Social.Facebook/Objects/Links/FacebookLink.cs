using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Common;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Links {

    public class FacebookLink : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the link.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the time the message was published.
        /// </summary>
        public DateTime CreatedTime { get; private set; }

        /// <summary>
        /// Gets the description of the link (appears beneath the link caption).
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets the user that created the link.
        /// </summary>
        public FacebookFrom From { get; private set; }

        /// <summary>
        /// Gets the URL to the link icon that Facebook displays in the news feed.
        /// </summary>
        public string Icon { get; private set; }

        /// <summary>
        /// Gets the URL that was shared.
        /// </summary>
        public string Link { get; private set; }

        /// <summary>
        /// Gets the optional message from the user about this link.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Gets the name of the link.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the URL to the thumbnail image used in the link post.
        /// </summary>
        public string Picture { get; private set; }

        #endregion

        #region Constructors

        private FacebookLink(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            CreatedTime = DateTime.Parse(obj.GetString("created_time"));
            Description = obj.GetString("description");
            From = obj.GetObject("from", FacebookFrom.Parse);
            Icon = obj.GetString("icon");
            Link = obj.GetString("link");
            Message = obj.GetString("message");
            Name = obj.GetString("name");
            Picture = obj.GetString("picture");
        }

        #endregion

        #region Static methods

        public static FacebookLink Parse(JObject obj) {
            return obj == null ? null : new FacebookLink(obj);
        }

        #endregion

    }

}