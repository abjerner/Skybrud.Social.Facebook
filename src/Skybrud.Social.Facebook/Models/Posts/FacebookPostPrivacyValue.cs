using Skybrud.Social.Facebook.Models.Posts;

namespace Skybrud.Social.Facebook.Models.Posts {

    /// <summary>
    /// Enum class representing the privacy setting of a <see cref="FacebookPost"/>.
    /// </summary>
    public enum FacebookPostPrivacyValue {

        /// <summary>
        /// Indicates that everyone can see the post.
        /// </summary>
        Everyone,

        /// <summary>
        /// Indicates that all friends of the poster can see the post.
        /// </summary>
        AllFriends,

        /// <summary>
        /// Indicatrs that all friends of friends of the poster can see the post.
        /// </summary>
        FriendsOfFriends,

        /// <summary>
        /// Indicates that only the poster can see the post.
        /// </summary>
        Self,

        /// <summary>
        /// Indicates that a custom list of users are either allowed to or denied from seeing the post.
        /// </summary>
        Custom

    }

}