namespace Skybrud.Social.Facebook.Enums.Posts {
    
    /// <summary>
    /// Enum class indicating the type of a Facebook post.
    /// </summary>
    public enum FacebookPostType {

        /// <summary>
        /// Indicates that the <code>type</code> property wasn't part of the response from the Facebook Graph API.
        /// </summary>
        NotSpecified,

        Link,
        Status,
        Photo,
        Video,
        Offer

    }

}