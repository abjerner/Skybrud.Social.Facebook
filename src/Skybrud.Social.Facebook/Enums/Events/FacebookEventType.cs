namespace Skybrud.Social.Facebook.Enums.Events {

    /// <summary>
    /// Enum class representing the type of an event.
    /// </summary>
    public enum FacebookEventType {

        /// <summary>
        /// Indicates that the type wasn't included in the response from the Graph API.
        /// </summary>
        NotIncluded,
        
        Private,
        
        Public,
        
        Group,
        
        Community

    }

}