using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Comments {

    public class FacebookCommentSummary : FacebookObject {

        // TODO: Check whether this class is still used...

        #region Properties

        public string Id { get; private set; }
        public FacebookEntity From { get; private set; }
        public string Message { get; private set; }
        public FacebookMessageTag[] MessageTags { get; private set; }
        public DateTime CreatedTime { get; private set; }
        public int Likes { get; private set; }

        #endregion

        #region Constructors

        private FacebookCommentSummary(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            From = obj.GetObject("from", FacebookEntity.Parse);
            Message = obj.GetString("message");
            MessageTags = obj.GetArray("message_tags", FacebookMessageTag.Parse);
            CreatedTime = obj.GetDateTime("created_time");
            Likes = obj.HasValue("likes") ? obj.GetInt32("likes") : 0;
        }

        #endregion

        #region Static methods

        public static FacebookCommentSummary Parse(JObject obj) {
            return obj == null ? null : new FacebookCommentSummary(obj);
        }

        #endregion

    }

}