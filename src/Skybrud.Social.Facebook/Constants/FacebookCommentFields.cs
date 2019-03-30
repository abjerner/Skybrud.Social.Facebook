using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Models.Comments;

namespace Skybrud.Social.Facebook.Constants {

    /// <summary>
    ///  Static class with constants for the fields available for a Facebook comment (<see cref="FacebookComment" />).
    ///  
    ///  The class is auto-generated and based on the fields listed in the Facebook Graph API documentation. Not all
    ///  fields may have been mapped for the implementation in Skybrud.Social.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.12/comment</cref>
    /// </see>
    public static class FacebookCommentFields {

        #region Individial fields

        /// <summary>
        /// The comment ID.
        /// </summary>
        public static readonly FacebookField Id = new FacebookField("id");

        /// <summary>
        /// Link, video, sticker, or photo attached to the comment.
        /// </summary>
        public static readonly FacebookField Attachment = new FacebookField("attachment");

        /// <summary>
        /// Whether the viewer can reply to this comment.
        /// </summary>
        public static readonly FacebookField CanComment = new FacebookField("can_comment");

        /// <summary>
        /// Whether the viewer can remove this comment.
        /// </summary>
        public static readonly FacebookField CanRemove = new FacebookField("can_remove");

        /// <summary>
        /// Whether the viewer can hide this comment.  Only visible to a page admin.
        /// </summary>
        public static readonly FacebookField CanHide = new FacebookField("can_hide");

        /// <summary>
        /// Whether the viewer can like this comment.
        /// </summary>
        public static readonly FacebookField CanLike = new FacebookField("can_like");

        /// <summary>
        /// Whether the viewer can send a private reply to this comment (Page viewers only).
        /// </summary>
        public static readonly FacebookField CanReplyPrivately = new FacebookField("can_reply_privately");

        /// <summary>
        /// Number of replies to this comment.
        /// </summary>
        public static readonly FacebookField CommentCount = new FacebookField("comment_count");

        /// <summary>
        /// The time this comment was made.
        /// </summary>
        public static readonly FacebookField CreatedTime = new FacebookField("created_time");

        /// <summary>
        /// The person that made this comment.
        /// </summary>
        public static readonly FacebookField From = new FacebookField("from");

        /// <summary>
        /// Number of times this comment was liked.
        /// </summary>
        public static readonly FacebookField LikeCount = new FacebookField("like_count");

        /// <summary>
        /// The comment text.
        /// </summary>
        public static readonly FacebookField Message = new FacebookField("message");

        /// <summary>
        /// An array of Profiles tagged in <c>message</c>.
        /// </summary>
        public static readonly FacebookField MessageTags = new FacebookField("message_tags");

        /// <summary>
        /// For comments on a photo or video, this is that object. Otherwise, this is empty.
        /// </summary>
        public static readonly FacebookField Object = new FacebookField("object");

        /// <summary>
        /// For comment replies, this the comment that this is a reply to.
        /// </summary>
        public static readonly FacebookField Parent = new FacebookField("parent");

        /// <summary>
        /// For comments with private replies, gets conversation between the Page and author of the comment (Page
        /// viewers only).
        /// </summary>
        public static readonly FacebookField PrivateReplyConversation = new FacebookField("private_reply_conversation");

        /// <summary>
        /// Whether the viewer has liked this comment.
        /// </summary>
        public static readonly FacebookField UserLikes = new FacebookField("user_likes");

        #endregion

        /// <summary>
        /// Gets an array of all known fields available for a Facebook comment.
        /// </summary>
        public static readonly FacebookField[] All = {
            Id, Attachment, CanComment, CanRemove, CanHide, CanLike, CanReplyPrivately, CommentCount, CreatedTime, From,
            LikeCount, Message, MessageTags, Object, Parent, PrivateReplyConversation, UserLikes
        };

    }

}