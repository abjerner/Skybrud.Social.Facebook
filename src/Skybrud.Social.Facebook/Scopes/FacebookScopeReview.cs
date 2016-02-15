namespace Skybrud.Social.Facebook.Scopes {

    /// <summary>
    /// Enum class describing whether a given scope requires your app to be reviewed by Facebook.
    /// </summary>
    public enum FacebookScopeReview {

        /// <summary>
        /// Indicates that it hasn't been specified whether a scope requires review by Facebook.
        /// </summary>
        Unspecified,

        /// <summary>
        /// Indicates that a given scope doesn't require review.
        /// </summary>
        No,

        /// <summary>
        /// Indicates that a given scope requires your app to be reviewed by Facebook.
        /// </summary>
        Yes,

    }

}