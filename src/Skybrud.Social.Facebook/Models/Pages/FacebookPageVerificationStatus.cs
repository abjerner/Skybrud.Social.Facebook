using Newtonsoft.Json;
using Skybrud.Essentials.Json.Converters.Enums;
using Skybrud.Essentials.Strings;

namespace Skybrud.Social.Facebook.Models.Pages {

    /// <summary>
    /// Enum class representing the verification status of a Facebook page.
    /// </summary>
    [JsonConverter(typeof(EnumStringConverter), TextCasing.Underscore)]
    public enum FacebookPageVerificationStatus {

        /// <summary>
        /// Indiciates a value that is currently not supported by this package.
        /// </summary>
        Unknown,

        /// <summary>
        /// Indicates that the page is not yet verified.
        /// </summary>
        NotVerified,

        /// <summary>
        /// Indicates that the page has been verified for beeing the page of a business or organisation.
        /// </summary>
        GreyVerified,

        /// <summary>
        /// Indicates that the page has been verified for beeing the page of a public figure, celebrity or brand.
        /// </summary>
        BlueVerified

    }

}