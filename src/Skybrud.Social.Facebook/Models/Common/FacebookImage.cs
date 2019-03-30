using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Common {
    
    /// <summary>
    /// Class with information about the image source and dimensions of Facebook photo.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/platform-image-source/</cref>
    /// </see>
    public class FacebookImage : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the width of the image.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Gets the height of the image.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Gets the URL of the image.
        /// </summary>
        public string Source { get; }

        #endregion

        #region Constructors

        private FacebookImage(JObject obj) : base(obj) {
            Width = obj.GetInt32("width");
            Height = obj.GetInt32("height");
            Source = obj.GetString("source");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookImage"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookImage"/>.</returns>
        public static FacebookImage Parse(JObject obj) {
            return obj == null ? null : new FacebookImage(obj);
        }

        #endregion

    }

}