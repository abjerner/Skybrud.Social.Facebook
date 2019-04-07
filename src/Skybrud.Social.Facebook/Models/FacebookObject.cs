using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;

namespace Skybrud.Social.Facebook.Models {

    /// <summary>
    /// Class representing a basic object from the Facebook Graph API derived from an instance of <see cref="JObject"/>.
    /// </summary>
    public class FacebookObject : JsonObjectBase {

        #region Constructor

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookObject"/>.</returns>
        protected FacebookObject(JObject obj) : base(obj) { }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets whether the underlying JSON object has a property with the specified <paramref name="propertyName"/>.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns><c>true</c> if the property exists, otherwise <c>false</c>.</returns>
        protected bool HasJsonProperty(string propertyName) {
            return JObject?.Property(propertyName) != null;
        }

        #endregion

    }

}