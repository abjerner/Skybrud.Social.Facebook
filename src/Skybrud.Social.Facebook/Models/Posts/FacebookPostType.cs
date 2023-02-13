using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters.Enums;
using Skybrud.Essentials.Strings;

#pragma warning disable CS1591

namespace Skybrud.Social.Facebook.Models.Posts {

    /// <summary>
    /// Enum class indicating the type of a Facebook post.
    /// </summary>
    [JsonConverter(typeof(EnumStringConverter), TextCasing.Underscore)]
    public enum FacebookPostType {

        /// <summary>
        /// Indiciates a value that is currently not supported by this package.
        /// </summary>
        Unknown,

        Link,

        Status,

        Photo,

        Video,

        Offer

    }

}