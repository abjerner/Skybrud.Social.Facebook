using System.Diagnostics.CodeAnalysis;
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
        public string Id { get; }

        /// <summary>
        /// Gets the name of the category.
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructors

        private FacebookPageCategory(JObject json) : base(json) {
            Id = json.GetString("id")!;
            Name = json.GetString("name")!;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> into an instance of <see cref="FacebookPageCategory"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPageCategory"/>.</returns>
        [return: NotNullIfNotNull("json")]
        public static FacebookPageCategory? Parse(JObject? json) {
            return json == null ? null : new FacebookPageCategory(json);
        }

        #endregion

    }

}