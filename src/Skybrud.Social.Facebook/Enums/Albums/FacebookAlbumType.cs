namespace Skybrud.Social.Facebook.Enums.Albums {
    
    /// <summary>
    /// Enumeration describing the type of an album.
    /// </summary>
    public enum FacebookAlbumType {

        /// <summary>
        /// Indicates that the type of the album wasn't specified. This means that the <code>type</code> property was missing in
        /// the JSON returned by the Facebook Graph API.
        /// </summary>
        Unspecified,

        /// <summary>
        /// Indicates that the album was created by an app.
        /// </summary>
        App,

        /// <summary>
        /// Indicates that the album is used for cover photos.
        /// </summary>
        Cover,

        /// <summary>
        /// Indicates that the album is used for profile photos.
        /// </summary>
        Profile,

        /// <summary>
        /// Indicates that the album is used for mobile uploads.
        /// </summary>
        Mobile,

        /// <summary>
        /// Indicates that the album is used for timeline photos.
        /// </summary>
        Wall,

        /// <summary>
        /// Indicates that the album is a normal album.
        /// </summary>
        Normal,

        Album
    
    }

}