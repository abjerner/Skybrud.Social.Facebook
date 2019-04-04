using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Common {

    /// <summary>
    /// Class representing an object with limited information about either a user or a page.
    /// </summary>
    public class FacebookFrom : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the user or page.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the name of the user or page.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the primary category of a page. Is <c>null</c> for users.
        /// </summary>
        public string Category { get; }

        /// <summary>
        /// Gets list of sub categories of a page. Is <c>null</c> for users.
        /// </summary>
        public FacebookEntity[] CategoryList { get; }

        #endregion

        #region Constructors

        private FacebookFrom(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
            Category = obj.GetString("category");
            CategoryList = obj.GetArray("category_list", FacebookEntity.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookFrom"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookFrom"/>.</returns>
        public static FacebookFrom Parse(JObject obj) {
            return obj == null ? null : new FacebookFrom(obj);
        }

        #endregion

    }

}