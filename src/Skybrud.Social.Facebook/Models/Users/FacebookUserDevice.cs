using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Users {
    
    /// <summary>
    /// Class with information a device of a Facebook user.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user-device/#Reading</cref>
    /// </see>
    public class FacebookUserDevice : FacebookObject {

        #region Properties
        
        /// <summary>
        /// Gets information about the hardware of the device.
        /// </summary>
        public string Hardware { get; }

        /// <summary>
        /// Gets whether the <see cref="Hardware"/> property was included in the response.
        /// </summary>
        public bool HasHardware => !String.IsNullOrWhiteSpace(Hardware);

        /// <summary>
        /// Gets information about the OS of the device.
        /// </summary>
        public string Os { get; }

        /// <summary>
        /// Gets whether the <see cref="Os"/> property was included in the response.
        /// </summary>
        public bool HasOs => !String.IsNullOrWhiteSpace(Os);

        #endregion

        #region Constructors

        private FacebookUserDevice(JObject obj) : base(obj) {
            Hardware = obj.GetString("hardware");
            Os = obj.GetString("os");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookUserDevice"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookUserDevice"/>.</returns>
        public static FacebookUserDevice Parse(JObject obj) {
            return obj == null ? null : new FacebookUserDevice(obj);
        }

        #endregion

    }

}