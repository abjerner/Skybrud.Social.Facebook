using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects {

    /// <summary>
    /// Class representing an object with limited information about either a user or a page.
    /// </summary>
    public class FacebookFrom : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the user or page.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the user or page.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the primary category of a page. Is <code>null</code> for users.
        /// </summary>
        public string Category { get; private set; }

        /// <summary>
        /// Gets list of sub categories of a page. Is <code>null</code> for users.
        /// </summary>
        public FacebookEntity[] CategoryList { get; private set; }

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
        /// Parses the specified <code>JObject</code> into an instance of <code>FacebookFrom</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        public static FacebookFrom Parse(JObject obj) {
            return obj == null ? null : new FacebookFrom(obj);
        }

        #endregion

    }

}