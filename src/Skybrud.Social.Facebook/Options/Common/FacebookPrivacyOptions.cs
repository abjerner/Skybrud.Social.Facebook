using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Models.Common;

namespace Skybrud.Social.Facebook.Options.Common {

    public class FacebookPrivacyOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the value of the privacy setting.
        /// </summary>
        public FacebookPrivacy Value { get; set; }

        /// <summary>
        /// When <see cref="Value"/> is <see cref="FacebookPrivacy.Custom"/>, this is a comma-separated list of user
        /// IDs and friend list IDs that <strong>can</strong> see the post. This can also be <c>ALL_FRIENDS</c>
        /// or <c>FRIENDS_OF_FRIENDS</c> to include all members of those sets.
        /// </summary>
        public string[] Allow { get; set; }

        /// <summary>
        /// When <see cref="Value"/> is <see cref="FacebookPrivacy.Custom"/>, this is a comma-separated list of user
        /// IDs and friend list IDs that cannot see the post.
        /// </summary>
        public string[] Deny { get; set; }

        #endregion

        #region Member methods

        public override string ToString() {

            // If set to "Default", the privacy shouldn't be specified
            if (Value == FacebookPrivacy.Default) return string.Empty;

            // Initialize an instance of JObject
            JObject json = new JObject();

            // Add the "Value" property
            string value = string.Empty;
            foreach (char chr in Value.ToString()) {
                if (chr >= 65 && chr <= 90) {
                    value += "_" + chr;
                } else if (chr >= 97 && chr <= 122) {
                    value += (char) (chr - 32);
                } else {
                    value += chr;
                }
            }
            json.Add("value", value.Trim('_'));

            // Add the "Allow" and/or "Deny" properties
            if (Value == FacebookPrivacy.Custom) {
                if (Allow != null && Allow.Length > 0) json.Add("allow", string.Join(",", Allow));
                if (Deny != null && Deny.Length > 0) json.Add("deny", string.Join(",", Deny));
            }

            // Serialize to a JSON string
            return json.ToString(Formatting.None);

        }

        #endregion

    }

}
