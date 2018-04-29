using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Strings;

namespace Skybrud.Social.Facebook.Models.Posts {

    /// <summary>
    /// Class representing the privacy settings of a <see cref="FacebookPost"/>.
    /// </summary>
    public class FacebookPostPrivacy : FacebookObject {

        #region Properties

        /// <summary>
        /// If <see cref="Value"/> is <see cref="FacebookPostPrivacyValue.Custom"/>, this is a comma-separated ID list of users and friendlists (if any) that can see the post.
        /// </summary>
        public string[] Allow { get; }

        /// <summary>
        /// If <see cref="Value"/> is <see cref="FacebookPostPrivacyValue.Custom"/>, this is a comma-separated ID list of users and friendlists (if any) that cannot see the post.
        /// </summary>
        public string[] Deny { get; }

        /// <summary>
        /// Gets the text that describes the privacy settings, as they would appear on Facebook.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// If <see cref="Value"/> is <see cref="FacebookPostPrivacyValue.Custom"/>, this indicates which group of friends can see the post.
        /// </summary>
        public string[] Friends { get; }

        /// <summary>
        /// Gets the actual privacy setting.
        /// </summary>
        public FacebookPostPrivacyValue Value { get; }

        #endregion

        #region Constructors

        private FacebookPostPrivacy(JObject obj) : base(obj) {
            Allow = obj.GetString("allow", StringUtils.ParseStringArray);
            Deny = obj.GetString("deny", StringUtils.ParseStringArray);
            Description = obj.GetString("description");
            Friends = obj.GetString("friends", StringUtils.ParseStringArray);
            Value = obj.GetEnum<FacebookPostPrivacyValue>("value");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookPostPrivacy"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPostPrivacy"/>.</returns>
        public static FacebookPostPrivacy Parse(JObject obj) {
            return obj == null ? null : new FacebookPostPrivacy(obj);
        }

        #endregion

    }

}