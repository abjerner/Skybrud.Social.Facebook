using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Extensions;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Models.Applications;
using Skybrud.Social.Facebook.Models.Comments;
using Skybrud.Social.Facebook.Models.Common;
using Skybrud.Social.Facebook.Models.Common.Tags;
using Skybrud.Social.Facebook.Models.Likes;
using Skybrud.Social.Facebook.Models.Places;

namespace Skybrud.Social.Facebook.Models.Posts {

    /// <summary>
    /// Class representing a Facebook post.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.12/post</cref>
    /// </see>
    public class FacebookPost : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the post.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets information about the app or business that created the post. Applies to pages only.
        /// </summary>
        public FacebookEntity? AdminCreator { get; }

        /// <summary>
        /// Gets information about the app the post was published by.
        /// </summary>
        public FacebookApplication? Application { get; }

        /// <summary>
        /// Gets a collection of the attachments of the post. Not all posts have attachments.
        /// </summary>
        public FacebookPostAttachments? Attachments { get; }

        // TODO: Add support for the "call_to_action" property

        /// <summary>
        /// Gets the link caption in post that appears below name.
        /// </summary>
        public string? Caption { get; }

        /// <summary>
        /// Gets the time the post was initially published. For a post about a life event, this will be the date and
        /// time of the life event.
        /// </summary>
        public EssentialsTime? CreatedTime { get; }

        /// <summary>
        /// Gets a description of a link in the post (appears beneath the <see cref="Caption"/>).
        /// </summary>
        public string? Description { get; }

        /// <summary>
        /// Gets information about the profile that posted the message.
        /// </summary>
        public FacebookProfile? From { get; }

        /// <summary>
        /// Gets the URL to a full-sized version of the photo published in the post or scraped from a link in the post.
        /// If the photo's largest dimension exceeds 720 pixels, it will be resized, with the largest dimension set to
        /// 720.
        /// </summary>
        public string? FullPicture { get; }

        /// <summary>
        /// Gets a link to an icon representing the type of this post.
        /// </summary>
        public string? Icon { get; }

        // TODO: Add support for the "instagram_eligibility" property

        /// <summary>
        /// Gets whether this post is marked as hidden (Applies to Pages only).
        /// </summary>
        public bool? IsHidden { get; }

        // TODO: Add support for the "is_instagram_eligible" property

        /// <summary>
        /// Gets whether this post is marked as hidden (Applies to Pages only).
        /// </summary>
        public bool? IsPublished { get; }

        /// <summary>
        /// Gets the link attached to this post.
        /// </summary>
        public string? Link { get; }

        /// <summary>
        /// Gets the status message in the post.
        /// </summary>
        public string? Message { get; }

        /// <summary>
        /// Gets an array of the profiles tagged in the <see cref="Message"/> property.
        /// </summary>
        public IReadOnlyList<FacebookProfileTag>? MessageTags { get; }

        /// <summary>
        /// Gets the name of the <see cref="Link"/>.
        /// </summary>
        public string? Name { get; }

        /// <summary>
        /// Gets the ID of any uploaded photo or video attached to the post.
        /// </summary>
        public string? ObjectId { get; }

        /// <summary>
        /// Gets the ID of a parent post for this post, if it exists. For example, if this story is a
        /// 'Your Page was mentioned in a post' story, the <see cref="ParentId"/> will be the original post where the
        /// mention happened.
        /// </summary>
        public string? ParentId { get; }

        /// <summary>
        /// Gets the URL to the permalink page of the post.
        /// </summary>
        public string? PermalinkUrl { get; }

        /// <summary>
        /// Gets the picture scraped from any <see cref="Link"/> included with the post.
        /// </summary>
        public string? Picture { get; }

        /// <summary>
        /// Gets any location information attached to the post.
        /// </summary>
        public FacebookPlace? Place { get; }

        /// <summary>
        /// Gets the privacy settings of the post.
        /// </summary>
        public FacebookPostPrivacy? Privacy { get; }

        /// <summary>
        /// Gets a list of properties for any attached video, for example, the length of the video.
        /// </summary>
        public IReadOnlyList<FacebookPostProperty>? Properties { get; }

        /// <summary>
        /// Gets information about how many times the post has been shared. If the post hasn't yet
        /// been shared, this property will return <c>null</c>.
        /// </summary>
        public FacebookShares? Shares { get; }

        /// <summary>
        /// Gets an object with information about how the entry has been liked.
        /// </summary>
        public FacebookLikesCollection? Likes { get; }

        /// <summary>
        /// Gets an object with information about how the entry has been commented.
        /// </summary>
        public FacebookCommentsCollection? Comments { get; }

        /// <summary>
        /// Gets a URL to any Flash movie or video file attached to the post.
        /// </summary>
        public string? Source { get; }

        /// <summary>
        /// Gets the type of a status update.
        /// </summary>
        public FacebookPostStatusType? StatusType { get; }

        /// <summary>
        /// Gets text from stories not intentionally generated by users, such as those generated when two people become
        /// friends, or when someone else posts on the person's wall.
        /// </summary>
        public string? Story { get; }

        /// <summary>
        /// Gets an array of the profiles tagged in the <see cref="Story"/> property.
        /// </summary>
        public IReadOnlyList<FacebookProfileTag>? StoryTags { get; }

        // TODO: Add support for the "targeting" property

        // TODO: Add support for the "to" property

        /// <summary>
        /// Gets the object type of this post.
        /// </summary>
        public FacebookPostType? Type { get; }

        /// <summary>
        /// Gets the time when the post was created, last edited or the time of the last comment that was left on the
        /// post.
        ///
        /// For a post about a life event, this will be the date and time of the life event.
        /// </summary>
        public EssentialsTime? UpdatedTime { get; }

        // TODO: Add support for the "with_tags" property

        #endregion

        #region Constructors

        private FacebookPost(JObject json) : base(json) {
            Id = json.GetString("id")!;
            AdminCreator = json.GetObject("admin_creator", FacebookEntity.Parse);
            Application = json.GetObject("application", FacebookApplication.Parse);
            Attachments = json.GetObject("attachments", FacebookPostAttachments.Parse);
            // TODO: Add support for the "call_to_action" property
            // TODO: Add support for the "can_reply_privately" property
            Caption = json.GetString("caption");
            CreatedTime = json.GetString("created_time", EssentialsTime.Parse);
            Description = json.GetString("description");
            // TODO: Add support for the "feed_targeting" property
            From = json.GetObject("from", FacebookProfile.Parse);
            FullPicture = json.GetString("full_picture");
            Icon = json.GetString("icon");
            // TODO: Add support for the "instagram_eligibility" property
            IsHidden = json.GetBooleanOrNull(FacebookPostFields.IsHidden.Alias);
            // TODO: Add support for the "is_instagram_eligible" property
            IsPublished = json.GetBooleanOrNull("is_published");
            Link = json.GetString("link");
            Message = json.GetString("message");
            MessageTags = json.GetArray("message_tags", FacebookProfileTag.Parse);
            Name = json.GetString("name");
            ObjectId = json.GetString("object_id");
            ParentId = json.GetString("parent_id");
            PermalinkUrl = json.GetString("permalink_url");
            Picture = json.GetString("picture");
            Place = json.GetObject("place", FacebookPlace.Parse);
            Privacy = json.GetObject("privacy", FacebookPostPrivacy.Parse);
            Properties = json.GetArray("properties", FacebookPostProperty.Parse);
            Shares = json.GetObject("shares", FacebookShares.Parse);
            Likes = json.GetObject("likes", FacebookLikesCollection.Parse);
            Comments = json.GetObject("comments", FacebookCommentsCollection.Parse);
            Source = json.GetString("source");
            StatusType = json.GetEnumOrDefault<FacebookPostStatusType>("status_type");
            Story = json.GetString("story");
            StoryTags = json.GetArray("story_tags", FacebookProfileTag.Parse);
            // TODO: Add support for the "targeting" property
            // TODO: Add support for the "to" property
            Type = json.GetEnumOrDefault<FacebookPostType>("type");
            UpdatedTime = json.GetString("updated_time", EssentialsTime.Parse);
            // TODO: Add support for the "with_tags" property
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> into an instance of <see cref="FacebookPost"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPost"/>.</returns>
        [return: NotNullIfNotNull("json")]
        public static FacebookPost? Parse(JObject? json) {
            return json == null ? null : new FacebookPost(json);
        }

        #endregion

    }

}