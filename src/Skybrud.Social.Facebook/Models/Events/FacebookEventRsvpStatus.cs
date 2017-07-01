namespace Skybrud.Social.Facebook.Models.Events {
    
    /// <summary>
    /// Enum class representing the type of an event.
    /// </summary>
    public enum FacebookEventRsvpStatus {

        /// <summary>
        /// When used for a filter, indicates that events of all types should be returned.
        /// </summary>
        All,

        /// <summary>
        /// Indicates that the authenticated user is attending a specific event.
        /// </summary>
        Attending,

        /// <summary>
        /// Indicates that the authenticatedhas created a specific event.
        /// </summary>
        Created,

        /// <summary>
        /// Indicates that the authenticated user has declined a specific event.
        /// </summary>
        Declined,

        /// <summary>
        /// Indicates that the authenticated user maybe is attending a specific event.
        /// </summary>
        Maybe,

        /// <summary>
        /// Indicates that the authenticated user hasn't replied to specific event.
        /// </summary>
        NotReplied

    }

}