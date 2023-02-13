using Skybrud.Social.Facebook.Models.Albums;

namespace Skybrud.Social.Facebook.Fields {

    /// <summary>
    ///  Static class with constants for the fields available for a Facebook album (<see cref="FacebookAlbum" />).
    ///
    ///  The class is auto-generated and based on the fields listed in the Facebook Graph API documentation. Not all
    ///  fields may have been mapped for the implementation in Skybrud.Social.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.12/album</cref>
    /// </see>
    public static class FacebookAlbumFields {

        #region Individial fields

        /// <summary>
        /// The album ID.
        /// </summary>
        public static readonly FacebookField Id = new FacebookField("id");

        /// <summary>
        /// Whether the viewer can upload photos to this album.
        /// </summary>
        public static readonly FacebookField CanUpload = new FacebookField("can_upload");

        /// <summary>
        /// The approximate number of photos in the album. This is not necessarily an exact count.
        /// </summary>
        public static readonly FacebookField Count = new FacebookField("count");

        /// <summary>
        /// The ID of the album's cover photo.
        /// </summary>
        public static readonly FacebookField CoverPhoto = new FacebookField("cover_photo");

        /// <summary>
        /// The time the album was initially created.
        /// </summary>
        public static readonly FacebookField CreatedTime = new FacebookField("created_time");

        /// <summary>
        /// The description of the album.
        /// </summary>
        public static readonly FacebookField Description = new FacebookField("description");

        /// <summary>
        /// The event associated with this album.
        /// </summary>
        public static readonly FacebookField Event = new FacebookField("event");

        /// <summary>
        /// The profile that created the album.
        /// </summary>
        public static readonly FacebookField From = new FacebookField("from");

        /// <summary>
        /// A link to this album on Facebook.
        /// </summary>
        public static readonly FacebookField Link = new FacebookField("link");

        /// <summary>
        /// The textual location of the album.
        /// </summary>
        public static readonly FacebookField Location = new FacebookField("location");

        /// <summary>
        /// The title of the album.
        /// </summary>
        public static readonly FacebookField Name = new FacebookField("name");

        /// <summary>
        /// The place associated with this album.
        /// </summary>
        public static readonly FacebookField Place = new FacebookField("place");

        /// <summary>
        /// The privacy settings for the album.
        /// </summary>
        public static readonly FacebookField Privacy = new FacebookField("privacy");

        /// <summary>
        /// The type of the album.
        /// </summary>
        public static readonly FacebookField Type = new FacebookField("type");

        /// <summary>
        /// The last time the album was updated.
        /// </summary>
        public static readonly FacebookField UpdatedTime = new FacebookField("updated_time");

        #endregion

        /// <summary>
        /// Gets an array of all known fields available for a Facebook album.
        /// </summary>
        public static readonly FacebookField[] All = {
            Id, CanUpload, Count, CoverPhoto, CreatedTime, Description, Event, From, Link, Location, Name, Place, Privacy,
            Type, UpdatedTime
        };

    }

}