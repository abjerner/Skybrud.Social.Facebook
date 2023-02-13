using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters.Enums;
using Skybrud.Essentials.Strings;

#pragma warning disable CS1591

namespace Skybrud.Social.Facebook.Models.Posts {

    /// <summary>
    /// Enum class indicating the status type of a Facebook post.
    /// </summary>
    [JsonConverter(typeof(EnumStringConverter), TextCasing.Underscore)]
    public enum FacebookPostStatusType {

        /// <summary>
        /// Indiciates a value that is currently not supported by this package.
        /// </summary>
        Unknown,

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