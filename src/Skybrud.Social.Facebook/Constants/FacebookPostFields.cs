using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Models.Photos;

namespace Skybrud.Social.Facebook.Constants {

    /// <summary>
    ///  Static class with constants for the fields available for a Facebook post (<see cref="FacebookPhoto" />).
    ///
    ///  The class is auto-generated and based on the fields listed in the Facebook Graph API documentation. Not all
    ///  fields may have been mapped for the implementation in Skybrud.Social.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.12/post</cref>
    /// </see>
    public static class FacebookPostFields {

        #region Individial fields

        /// <summary>
        /// The post ID.
        /// </summary>
        public static readonly FacebookField Id = new FacebookField("id");

        /// <summary>
        /// The admin creator of a Page post. If the Page has only one admin, no data will be returned. Requires a Page
        /// Access Token and the.
        /// </summary>
        public static readonly FacebookField AdminCreator = new FacebookField("admin_creator");

        /// <summary>
        /// Information about the app this post was published by.
        /// </summary>
        public static readonly FacebookField Application = new FacebookField("application");

        /// <summary>
        /// The call to action type used in any Page posts for.
        /// </summary>
        public static readonly FacebookField CallToAction = new FacebookField("call_to_action");

        /// <summary>
        /// Whether the Page viewer can send a private reply to this Post. Requires the <c>read_page_mailboxes</c>
        /// permission.
        /// </summary>
        public static readonly FacebookField CanReplyPrivately = new FacebookField("can_reply_privately");

        /// <summary>
        /// Link caption in post that appears below name. The caption must be an actual URLs and should accurately
        /// reflect the URL and associated advertiser or business someone visits when they click on it.
        /// </summary>
        public static readonly FacebookField Caption = new FacebookField("caption");

        /// <summary>
        /// The time the post was initially published. For a post about a life event, this will be the date and time of
        /// the life event.
        /// </summary>
        public static readonly FacebookField CreatedTime = new FacebookField("created_time");

        /// <summary>
        /// A description of a link in the post (appears beneath the.
        /// </summary>
        public static readonly FacebookField Description = new FacebookField("description");

        /// <summary>
        /// Object that controls.
        /// </summary>
        public static readonly FacebookField FeedTargeting = new FacebookField("feed_targeting");

        /// <summary>
        /// Information (<c>name</c> and <c>id</c>) about the <a
        /// href="https://developers.facebook.com/docs/graph-api/reference/profile" target="_blank">Profile</a> that
        /// created the Post.
        /// </summary>
        public static readonly FacebookField From = new FacebookField("from");

        /// <summary>
        /// URL to a full-sized version of the Photo published in the Post or scraped from a <c>link</c> in the Post. If
        /// the photo's largest dimension exceeds 720 pixels, it will be resized, with the largest dimension set to 720.
        /// </summary>
        public static readonly FacebookField FullPicture = new FacebookField("full_picture");

        /// <summary>
        /// A link to an icon representing the type of this post.
        /// </summary>
        public static readonly FacebookField Icon = new FacebookField("icon");

        /// <summary>
        /// Whether the post can be promoted on Instagram. It returns the enum "eligible" if it can be promoted.
        /// Otherwise it returns an enum for why it cannot be promoted.
        /// </summary>
        public static readonly FacebookField InstagramEligibility = new FacebookField("instagram_eligibility");

        /// <summary>
        /// If this post is marked as hidden (Applies to Pages only).
        /// </summary>
        public static readonly FacebookField IsHidden = new FacebookField("is_hidden");

        /// <summary>
        /// Whether this post can be promoted in Instagram.
        /// </summary>
        public static readonly FacebookField IsInstagramEligible = new FacebookField("is_instagram_eligible");

        /// <summary>
        /// Indicates whether a scheduled post was published (applies to scheduled Page Post only, for users post and
        /// instantly published posts this value is always.
        /// </summary>
        public static readonly FacebookField IsPublished = new FacebookField("is_published");

        /// <summary>
        /// The link attached to this post.
        /// </summary>
        public static readonly FacebookField Link = new FacebookField("link");

        /// <summary>
        /// The status message in the post.
        /// </summary>
        public static readonly FacebookField Message = new FacebookField("message");

        /// <summary>
        /// An array of profiles tagged in the.
        /// </summary>
        public static readonly FacebookField MessageTags = new FacebookField("message_tags");

        /// <summary>
        /// The name of the.
        /// </summary>
        public static readonly FacebookField Name = new FacebookField("name");

        /// <summary>
        /// The ID of any uploaded photo or video attached to the post.
        /// </summary>
        public static readonly FacebookField ObjectId = new FacebookField("object_id");

        /// <summary>
        /// The ID of a parent post for this post, if it exists.  For example, if this story is a 'Your Page was
        /// mentioned in a post' story, the.
        /// </summary>
        public static readonly FacebookField ParentId = new FacebookField("parent_id");

        /// <summary>
        /// URL to the permalink page of the post.
        /// </summary>
        public static readonly FacebookField PermalinkUrl = new FacebookField("permalink_url");

        /// <summary>
        /// URL to a resized version of the Photo published in the Post or scraped from a <c>link</c> in the Post. If
        /// the photo's largest dimension exceeds 130 pixels, it will be resized, with the largest dimension set to 130.
        /// </summary>
        public static readonly FacebookField Picture = new FacebookField("picture");

        /// <summary>
        /// Any location information attached to the post.
        /// </summary>
        public static readonly FacebookField Place = new FacebookField("place");

        /// <summary>
        /// The privacy settings of the post.
        /// </summary>
        public static readonly FacebookField Privacy = new FacebookField("privacy");

        /// <summary>
        /// ID of post to use for promotion for stories that cannot be promoted directly.
        /// </summary>
        public static readonly FacebookField PromotableId = new FacebookField("promotable_id");

        /// <summary>
        /// Status of the promotion. Requires Page admin privileges. Possible values:.
        /// </summary>
        public static readonly FacebookField PromotionStatus = new FacebookField("promotion_status");

        /// <summary>
        /// A list of properties for any attached video, for example, the length of the video.
        /// </summary>
        public static readonly FacebookField Properties = new FacebookField("properties");

        /// <summary>
        /// The shares count of this post. The share count may include deleted posts and posts you cannot see for
        /// privacy reasons.
        /// </summary>
        public static readonly FacebookField Shares = new FacebookField("shares");

        /// <summary>
        /// A URL to any Flash movie or video file attached to the post.
        /// </summary>
        public static readonly FacebookField Source = new FacebookField("source");

        /// <summary>
        /// Description of the type of a status update.
        /// </summary>
        public static readonly FacebookField StatusType = new FacebookField("status_type");

        /// <summary>
        /// Text from stories not intentionally generated by users, such as those generated when two people become
        /// friends, or when someone else posts on the person's wall.
        /// </summary>
        public static readonly FacebookField Story = new FacebookField("story");

        /// <summary>
        /// Deprecated field, same as.
        /// </summary>
        public static readonly FacebookField StoryTags = new FacebookField("story_tags");

        /// <summary>
        /// Object that.
        /// </summary>
        public static readonly FacebookField Targeting = new FacebookField("targeting");

        /// <summary>
        /// Profiles mentioned or targeted in this post.
        /// </summary>
        public static readonly FacebookField To = new FacebookField("to");

        /// <summary>
        /// A string indicating the object type of this post.
        /// </summary>
        public static readonly FacebookField Type = new FacebookField("type");

        /// <summary>
        /// This field's behavior depends on the type of object the Post is on:.
        /// </summary>
        public static readonly FacebookField UpdatedTime = new FacebookField("updated_time");

        /// <summary>
        /// Profiles tagged as being 'with' the publisher of the post.
        /// </summary>
        public static readonly FacebookField WithTags = new FacebookField("with_tags");

        #endregion

        /// <summary>
        /// Gets an array of all known fields available for a Facebook post.
        /// </summary>
        public static readonly FacebookField[] All = {
            Id, AdminCreator, Application, CallToAction, CanReplyPrivately, Caption, CreatedTime, Description, FeedTargeting,
            From, FullPicture, Icon, InstagramEligibility, IsHidden, IsInstagramEligible, IsPublished, Link, Message, MessageTags,
            Name, ObjectId, ParentId, PermalinkUrl, Picture, Place, Privacy, PromotableId, PromotionStatus, Properties, Shares,
            Source, StatusType, Story, StoryTags, Targeting, To, Type, UpdatedTime, WithTags
        };

    }

}