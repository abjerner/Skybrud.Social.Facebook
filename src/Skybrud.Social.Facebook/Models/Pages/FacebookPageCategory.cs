using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Pages {

    /// <summary>
    /// Class representing the category of a <see cref="FacebookPage"/>.
    /// </summary>
    public class FacebookPageCategory : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the category.
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        /// Gets the name of the category.
        /// </summary>
        public string Name { get; internal set; }

        #endregion

        #region Constructors

        private FacebookPageCategory(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookPageCategory"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPageCategory"/>.</returns>
        public static FacebookPageCategory Parse(JObject obj) {
            return obj == null ? null : new FacebookPageCategory(obj);
        }

        #endregion

    }

}