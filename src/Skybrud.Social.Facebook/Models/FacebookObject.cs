using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Facebook.Models {

    /// <summary>
    /// Class representing a basic object from the Facebook Graph API derived from an instance of <see cref="JObject"/>.
    /// </summary>
    public class FacebookObject : JsonObjectBase {

        #region Properties

        /// <summary>
        /// Gets the internal Newtonsoft.Json.Linq.JObject the object was created from.
        /// </summary>
        [JsonIgnore]
        public new JObject JObject => base.JObject!;

        #endregion

        #region Constructor

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="FacebookObject"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookObject"/>.</returns>
        protected FacebookObject(JObject json) : base(json) { }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets whether the underlying JSON object has a property with the specified <paramref name="propertyName"/>.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns><c>true</c> if the property exists, otherwise <c>false</c>.</returns>
        protected bool HasJsonProperty(string propertyName) {
            return JObject.Property(propertyName) != null;
        }

        /// <summary>
        /// Parses the Unix timestamp at <paramref name="path"/>.
        ///
        /// In some cases, the Graph APi may return <c>0</c> indicating no value - if this is the case, this method will return <c>null</c> instead of <see cref="EssentialsTime.Zero"/>.
        /// </summary>
        /// <param name="obj">The parent object.</param>
        /// <param name="path">A <see cref="string"/> that contains a JPath expression.</param>
        /// <returns></returns>
        protected EssentialsTime? ParseUnixTimestamp(JObject? obj, string path) {
            return obj.TryGetInt32ByPath(path, out int value) ? EssentialsTime.FromUnixTimeSeconds(value) : null;
        }

        #endregion

    }

}