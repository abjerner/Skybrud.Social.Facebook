using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Likes {

    /// <summary>
    /// Class representing a single like.
    /// </summary>
    public class FacebookLike : FacebookObject {

        #region Properties

        /// <summary>
        /// The ID of the person.
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        /// The name of the person.
        /// </summary>
        public string Name { get; internal set; }

        #endregion

        #region Constructors

        private FacebookLike(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookLike"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="FacebookLike"/>.</returns>
        public static FacebookLike Parse(JObject obj) {
            return obj == null ? null : new FacebookLike(obj);
        }

        #endregion

    }

}