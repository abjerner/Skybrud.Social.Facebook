using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Common {

    public class FacebookImage : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the width of the image.
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// Gets the height of the image.
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Gets the URL of the image.
        /// </summary>
        public string Source { get; private set; }

        #endregion

        #region Constructors

        private FacebookImage(JObject obj) : base(obj) {
            Width = obj.GetInt32("width");
            Height = obj.GetInt32("height");
            Source = obj.GetString("source");
        }

        #endregion

        #region Static methods

        public static FacebookImage Parse(JObject obj) {
            return obj == null ? null : new FacebookImage(obj);
        }

        #endregion

    }

}