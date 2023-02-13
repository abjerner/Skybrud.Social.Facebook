using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Models.Photos;

namespace Skybrud.Social.Facebook.Constants {

    /// <summary>
    ///  Static class with constants for the fields available for a Facebook photo (<see cref="FacebookPhoto" />).
    ///
    ///  The class is auto-generated and based on the fields listed in the Facebook Graph API documentation. Not all
    ///  fields may have been mapped for the implementation in Skybrud.Social.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.12/photo</cref>
    /// </see>
    public static class FacebookPhotoFields {

        #region Individial fields

        /// <summary>
        /// The photo ID.
        /// </summary>
        public static readonly FacebookField Id = new FacebookField("id");

        /// <summary>
        /// The album this photo is in.
        /// </summary>
        public static readonly FacebookField Album = new FacebookField("album");

        /// <summary>
        /// A user-specified time for when this object was created.
        /// </summary>
        public static readonly FacebookField BackdatedTime = new FacebookField("backdated_time");

        /// <summary>
        /// How accurate the backdated time is.
        /// </summary>
        public static readonly FacebookField BackdatedTimeGranularity = new FacebookField("backdated_time_granularity");

        /// <summary>
        /// Indicates whether the viewer can backdate the photo.
        /// </summary>
        public static readonly FacebookField CanBackdate = new FacebookField("can_backdate");

        /// <summary>
        /// Indicates whether the viewer can delete the photo.
        /// </summary>
        public static readonly FacebookField CanDelete = new FacebookField("can_delete");

        /// <summary>
        /// Indicates whether the viewer can tag the photo.
        /// </summary>
        public static readonly FacebookField CanTag = new FacebookField("can_tag");

        /// <summary>
        /// The time this photo was published.
        /// </summary>
        public static readonly FacebookField CreatedTime = new FacebookField("created_time");

        /// <summary>
        /// If this object has a place, the event associated with the place.
        /// </summary>
        public static readonly FacebookField Event = new FacebookField("event");

        /// <summary>
        /// The profile (user or page) that uploaded this photo.
        /// </summary>
        public static readonly FacebookField From = new FacebookField("from");

        /// <summary>
        /// The height of this photo in pixels.
        /// </summary>
        public static readonly FacebookField Height = new FacebookField("height");

        /// <summary>
        /// The icon that Facebook displays when photos are published to News Feed.
        /// </summary>
        public static readonly FacebookField Icon = new FacebookField("icon");

        /// <summary>
        /// The different stored representations of the photo. Can vary in number based upon the size of the original
        /// photo.
        /// </summary>
        public static readonly FacebookField Images = new FacebookField("images");

        /// <summary>
        /// A link to the photo on Facebook.
        /// </summary>
        public static readonly FacebookField Link = new FacebookField("link");

        /// <summary>
        /// The user-provided caption given to this photo. Corresponds to <c>caption</c> when creating photos.
        /// </summary>
        public static readonly FacebookField Name = new FacebookField("name");

        /// <summary>
        /// An array containing an array of objects mentioned in the name field which contain the id, name, and type of
        /// each object as well as the offset and length which can be used to match it up with its corresponding string
        /// in the name field.
        /// </summary>
        public static readonly FacebookField NameTags = new FacebookField("name_tags");

        /// <summary>
        /// ID of the page story this corresponds to. May not be on all photos. Applies only to published photos.
        /// </summary>
        public static readonly FacebookField PageStoryId = new FacebookField("page_story_id");

        /// <summary>
        /// Link to the 100px wide representation of this photo.
        /// </summary>
        public static readonly FacebookField Picture = new FacebookField("picture");

        /// <summary>
        /// Location associated with the photo, if any.
        /// </summary>
        public static readonly FacebookField Place = new FacebookField("place");

        /// <summary>
        /// Deprecated. Returns 0.
        /// </summary>
        public static readonly FacebookField Position = new FacebookField("position");

        /// <summary>
        /// Deprecated. Use <c>images</c> instead.
        /// </summary>
        public static readonly FacebookField Source = new FacebookField("source");

        /// <summary>
        /// The target this photo is published to.
        /// </summary>
        public static readonly FacebookField Target = new FacebookField("target");

        /// <summary>
        /// The last time the photo was updated.
        /// </summary>
        public static readonly FacebookField UpdatedTime = new FacebookField("updated_time");

        /// <summary>
        /// The different stored representations of the photo in webp format. Can vary in number based upon the size of
        /// the original photo.
        /// </summary>
        public static readonly FacebookField WebpImages = new FacebookField("webp_images");

        /// <summary>
        /// The width of this photo in pixels.
        /// </summary>
        public static readonly FacebookField Width = new FacebookField("width");

        #endregion

        /// <summary>
        /// Gets an array of all known fields available for a Facebook photo.
        /// </summary>
        public static readonly FacebookField[] All = {
            Id, Album, BackdatedTime, BackdatedTimeGranularity, CanBackdate, CanDelete, CanTag, CreatedTime, Event, From,
            Height, Icon, Images, Link, Name, NameTags, PageStoryId, Picture, Place, Position, Source, Target, UpdatedTime,
            WebpImages, Width
        };

    }

}