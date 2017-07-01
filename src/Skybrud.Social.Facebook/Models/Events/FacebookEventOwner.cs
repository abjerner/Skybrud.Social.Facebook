using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Events {

    /// <summary>
    /// Class representing the owner of an event.
    /// </summary>
    public class FacebookEventOwner : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the user or page.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the user or page.
        /// </summary>
        public string Name { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookEventOwner(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookEventOwner"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookEventOwner"/>.</returns>
        public static FacebookEventOwner Parse(JObject obj) {
            return obj == null ? null : new FacebookEventOwner(obj);
        }

        #endregion

    }

}