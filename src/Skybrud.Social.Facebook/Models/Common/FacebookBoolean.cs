namespace Skybrud.Social.Facebook.Models.Common {
    
    /// <summary>
    /// Enum class representing a boolean value
    /// </summary>
    public enum FacebookBoolean {

        /// <summary>
        /// This means that the property was missing in the JSON returned by the Facebook Graph API.
        /// </summary>
        Unspecified,

        /// <summary>
        /// Indicates that a boolean value is <c>false</c>.
        /// </summary>
        False,
 
        /// <summary>
        /// Indicates that a boolean value is <c>true</c>.
        /// </summary>
        True

    }

}