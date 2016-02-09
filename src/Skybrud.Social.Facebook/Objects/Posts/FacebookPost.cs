using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Comments;
using Skybrud.Social.Facebook.Objects.Likes;
using Skybrud.Social.Interfaces;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Posts {

    public class FacebookPost : FacebookObject, ISocialTimelineEntry {

        #region Properties

        public string Id { get; private set; }
        public FacebookEntity From { get; private set; }
        public FacebookEntity Application { get; private set; }
        public FacebookPostProperties[] Properties { get; private set; }
        public string Message { get; private set; }
        public string Caption { get; private set; }
        public string Description { get; private set; }
        public string Story { get; private set; }
        public string Picture { get; private set; }
        public string Link { get; private set; }
        public string Source { get; private set; }
        public string Name { get; private set; }
        public string Icon { get; private set; }
        public string Type { get; private set; }
        public string StatusType { get; private set; }
        public string ObjectId { get; private set; }
        public DateTime CreatedTime { get; private set; }
        public DateTime UpdatedTime { get; private set; }
        
        /// <summary>
        /// Gets information about how many times the post has been shared. If the post hasn't yet
        /// been shared, this property will return <code>NULL</code>.
        /// </summary>
        public FacebookShares Shares { get; private set; }
        
        public FacebookLikesCollection Likes { get; private set; }
        public FacebookCommentsCollection Comments { get; private set; }

        public DateTime SortDate {
            get { return CreatedTime; }
        }

        #endregion

        #region Constructors

        private FacebookPost(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            From = obj.GetObject("from", FacebookEntity.Parse);
            Application = obj.GetObject("application", FacebookEntity.Parse);
            Properties = obj.GetArray("properties", FacebookPostProperties.Parse) ?? new FacebookPostProperties[0];
            Caption = obj.GetString("caption");
            Message = obj.GetString("message");
            Description = obj.GetString("description");
            Story = obj.GetString("story");
            Picture = obj.GetString("picture");
            Link = obj.GetString("link");
            Source = obj.GetString("source");
            Name = obj.GetString("name");
            Icon = obj.GetString("icon");
            Type = obj.GetString("type");
            StatusType = obj.GetString("status_type");
            ObjectId = obj.GetString("object_id");
            CreatedTime = obj.GetDateTime("created_time");
            UpdatedTime = obj.GetDateTime("updated_time");
            Shares = obj.GetObject("shares", FacebookShares.Parse);
            Likes = obj.GetObject("likes", FacebookLikesCollection.Parse);
            Comments = obj.GetObject("comments", FacebookCommentsCollection.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets a post from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static FacebookPost Parse(JObject obj) {
            return obj == null ? null : new FacebookPost(obj);
        }

        #endregion

    }

}