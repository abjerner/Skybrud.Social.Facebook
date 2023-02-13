namespace Skybrud.Social.Facebook.Models.Posts {

    /// <summary>
    /// Enum class indicating the type of a Facebook post.
    /// </summary>
    public enum FacebookPostType {

        /// <summary>
        /// Indicates that the <c>type</c> property wasn't part of the response from the Facebook Graph API.
        /// </summary>
        NotSpecified,

        Link,
        Status,
        Photo,
        Video,
        Offer

    }

}