using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters.Enums;
using Skybrud.Essentials.Strings;

namespace Skybrud.Social.Facebook.Models.Pages {

    /// <summary>
    /// Class describing the attire (dress code) of a Facebook page (business).
    /// </summary>
    [JsonConverter(typeof(EnumStringConverter), TextCasing.Underscore)]
    public enum FacebookPageAttire {

        /// <summary>
        /// Indiciates an attire that is currently not supported by this package.
        /// </summary>
        Unknown,

        /// <summary>
        /// Indicates a casual attire.
        /// </summary>
        Casual,

        /// <summary>
        /// Indicates a dressy attire.
        /// </summary>
        Dressy

    }

}