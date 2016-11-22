using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Common;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Comments {
    
    /// <summary>
    /// Class representing a single comment.
    /// </summary>
    public class FacebookComment : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the comment.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets information about the person that made the comment.
        /// </summary>
        public FacebookFrom From { get; private set; }

        /// <summary>
        /// Gets the text of the comment.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Gets whether the authenticated user can remove the comment.
        /// </summary>
        public bool CanRemove { get; private set; }

        /// <summary>
        /// Gets the time the comment was made.
        /// </summary>
        public DateTime CreatedTime { get; private set; }

        /// <summary>
        /// Gets the number of times the comment was liked.
        /// </summary>
        public int LikeCount { get; private set; }

        /// <summary>
        /// Gets whether the authenticated has like the comment.
        /// </summary>
        public bool UserLikes { get; private set; }

        // TODO: Add more properties: https://developers.facebook.com/docs/graph-api/reference/v2.2/comment#fields

        #endregion

        #region Constructors

        private FacebookComment(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            From = obj.GetObject("from", FacebookFrom.Parse);
            Message = obj.GetString("message");
            CanRemove = obj.GetBoolean("can_remove");
            CreatedTime = obj.GetDateTime("created_time");
            LikeCount = obj.GetInt32("like_count");
            UserLikes = obj.GetBoolean("user_likes");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookComment"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="FacebookComment"/>.</returns>
        public static FacebookComment Parse(JObject obj) {
            return obj == null ? null : new FacebookComment(obj);
        }

        #endregion

    }

}