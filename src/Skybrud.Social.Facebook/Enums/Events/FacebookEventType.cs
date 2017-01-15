namespace Skybrud.Social.Facebook.Enums.Events {

    /// <summary>
    /// Enum class representing the type of an event.
    /// </summary>
    public enum FacebookEventType {

        /// <summary>
        /// Indicates that the type of the event wasn't specified. This means that the <code>type</code> property was
        /// missing in the JSON returned by the Facebook Graph API.
        /// </summary>
        Unspecified,
        
        Private,
        
        Public,
        
        Group,
        
        Community

    }

}