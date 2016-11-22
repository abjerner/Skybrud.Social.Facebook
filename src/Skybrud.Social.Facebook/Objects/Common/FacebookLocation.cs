using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Common {
    
    public class FacebookLocation : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the country of the location.
        /// </summary>
        public string Country { get; private set; }

        /// <summary>
        /// Gets the city of the location.
        /// </summary>
        public string City { get; private set; }

        /// <summary>
        /// Gets the latitude of the location.
        /// </summary>
        public double Latitude { get; private set; }

        /// <summary>
        /// Gets the longitude of the location.
        /// </summary>
        public double Longitude { get; private set; }

        /// <summary>
        /// Gets the zip code of the location.
        /// </summary>
        public string Zip { get; private set; }

        /// <summary>
        /// Gets the state of the location.
        /// </summary>
        public string State { get; private set; }

        /// <summary>
        /// Gets the street of the location.
        /// </summary>
        public string Street { get; private set; }

        #endregion

        #region Constructors

        private FacebookLocation(JObject obj) : base(obj) {
            Country = obj.GetString("country");
            City = obj.GetString("city");
            Latitude = obj.GetDouble("latitude");
            Longitude = obj.GetDouble("longitude");
            Zip = obj.GetString("zip");
            State = obj.GetString("state");
            Street = obj.GetString("street");
        }

        #endregion

        #region Static methods

        public static FacebookLocation Parse(JObject obj) {
            return obj == null ? null : new FacebookLocation(obj);
        }

        #endregion

    }

}