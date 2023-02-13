using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Common.Tags {

    /// <summary>
    /// Class representing a tag referencing a Facebook profile (user, page or group).
    /// </summary>
    public class FacebookProfileTag : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the profile that was tagged.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the text used to tag the profile.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the tagged profile's type.
        /// </summary>
        public FacebookProfileTagType Type { get; }

        /// <summary>
        /// Gets the location in unicode code points of the first character of the tag text.
        /// </summary>
        public int Offset { get; }

        /// <summary>
        /// Gets the length of the tag text, in unicode code points.
        /// </summary>
        public int Length { get; }

        #endregion

        #region Constructors

        private FacebookProfileTag(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
            Type = obj.GetEnum<FacebookProfileTagType>("type");
            Offset = obj.GetInt32("offset");
            Length = obj.GetInt32("length");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookProfileTag"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookProfileTag"/>.</returns>
        public static FacebookProfileTag Parse(JObject obj) {
            return obj == null ? null : new FacebookProfileTag(obj);
        }

        #endregion

    }

}