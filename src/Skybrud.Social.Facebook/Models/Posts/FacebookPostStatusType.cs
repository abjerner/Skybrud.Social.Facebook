namespace Skybrud.Social.Facebook.Models.Posts {
    
    /// <summary>
    /// Enum class indicating the status type of a Facebook post.
    /// </summary>
    public enum FacebookPostStatusType {

        /// <summary>
        /// Indicates that the <code>status_type</code> property wasn't part of the response from the Facebook Graph API.
        /// </summary>
        NotSpecified,

        MobileStatusUpdate,
        CreatedNote,
        AddedPhotos,
        AddedVideo,
        SharedStory,
        CreatedGroup,
        CreatedEvent,
        WallPost,
        AppCreatedStory,
        PublishedStory,
        TaggedInPhoto,
        ApprovedFriend

    }

}