using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Posts {
    
    /// <summary>
    /// Class representing a property of a Facebook post.
    /// </summary>
    public class FacebookPostProperty : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the textual value of the property.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Gets the link associated with the property.
        /// </summary>
        public string Href { get; }

        /// <summary>
        /// Gets whether the <see cref="Href"/> property was included in the response.
        /// </summary>
        public bool HasHref => string.IsNullOrWhiteSpace(Href) == false;

        #endregion

        #region Constructors

        private FacebookPostProperty(JObject obj) : base(obj) {
            Name = obj.GetString("name");
            Text = obj.GetString("text");
            Href = obj.GetString("href");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookPostProperty"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPostProperty"/>.</returns>
        public static FacebookPostProperty Parse(JObject obj) {
            return obj == null ? null : new FacebookPostProperty(obj);
        }

        #endregion

    }

}