using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Likes {

    /// <summary>
    /// Class representing a single like.
    /// </summary>
    public class FacebookLike : FacebookObject {

        #region Properties

        /// <summary>
        /// The ID of the person.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// The name of the person.
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructors

        private FacebookLike(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookLike"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="FacebookLike"/>.</returns>
        public static FacebookLike Parse(JObject obj) {
            return obj == null ? null : new FacebookLike(obj);
        }

        #endregion

    }

}