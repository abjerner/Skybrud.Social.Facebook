using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Posts {

    /// <summary>
    /// Class representing a summary about a created post.
    /// </summary>
    public class FacebookCreatePostSummary : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the post.
        /// </summary>
        public string Id { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookCreatePostSummary(JObject obj) : base(obj) {
            Id = obj.GetString("id");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookCreatePostSummary"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookCreatePostSummary"/>.</returns>
        public static FacebookCreatePostSummary Parse(JObject obj) {
            return obj == null ? null : new FacebookCreatePostSummary(obj);
        }

        #endregion

    }

}