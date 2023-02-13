using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters.Enums;
using Skybrud.Essentials.Strings;

namespace Skybrud.Social.Facebook.Models.Posts {

    /// <summary>
    /// Enum class representing the privacy setting of a <see cref="FacebookPost"/>.
    /// </summary>
    [JsonConverter(typeof(EnumStringConverter), TextCasing.Underscore)]
    public enum FacebookPostPrivacyValue {

        /// <summary>
        /// Indiciates a value that is currently not supported by this package.
        /// </summary>
        Unknown,

        /// <summary>
        /// Indicates that everyone can see the post.
        /// </summary>
        Everyone,

        /// <summary>
        /// Indicates that all friends of the poster can see the post.
        /// </summary>
        AllFriends,

        /// <summary>
        /// Indicatrs that all friends of friends of the poster can see the post.
        /// </summary>
        FriendsOfFriends,

        /// <summary>
        /// Indicates that only the poster can see the post.
        /// </summary>
        Self,

        /// <summary>
        /// Indicates that a custom list of users are either allowed to or denied from seeing the post.
        /// </summary>
        Custom

    }

}