using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Facebook.Objects {

    /// <summary>
    /// Class representing a basic object from the Facebook Graph API derived from an instance of <see cref="JObject"/>.
    /// </summary>
    public class FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the internal <see cref="JObject"/> the object was created from.
        /// </summary>
        [JsonIgnore]
        public JObject JObject { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="FacebookObject"/>.</returns>
        protected FacebookObject(JObject obj) {
            JObject = obj;
        }

        #endregion

    }

}