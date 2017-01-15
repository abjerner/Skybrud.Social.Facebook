namespace Skybrud.Social.Facebook.Enums {
    
    /// <summary>
    /// Enum class representing a boolean value
    /// </summary>
    public enum FacebookBoolean {

        /// <summary>
        /// When used for a value returned by the Graph API, this will indicate that the property wasn't included in
        /// the response.
        /// 
        /// When used as a filter for a request to the Graph API, this will indicate that the filter should not be
        /// applied.
        /// </summary>
        Undefined,

        /// <summary>
        /// Indicates that a boolean value is <code>false</code>.
        /// </summary>
        False,
 
        /// <summary>
        /// Indicates that a boolean value is <code>true</code>.
        /// </summary>
        True

    }

}