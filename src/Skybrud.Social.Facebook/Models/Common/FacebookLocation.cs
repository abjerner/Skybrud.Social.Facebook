using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Essentials.Locations;

namespace Skybrud.Social.Facebook.Models.Common {

    /// <summary>
    /// Class representing the location of a Facebook place.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/location/</cref>
    /// </see>
    public class FacebookLocation : FacebookObject, ILocation {

        #region Properties

        /// <summary>
        /// Gets the city of the location.
        /// </summary>
        public string City { get; }

        /// <summary>
        /// Gets the country of the location.
        /// </summary>
        public string Country { get; }

        /// <summary>
        /// Gets the latitude of the location.
        /// </summary>
        public double Latitude { get; }

        /// <summary>
        /// Gets the longitude of the location.
        /// </summary>
        public double Longitude { get; }

        /// <summary>
        /// Gets the name of the location.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the state of the location.
        /// </summary>
        public string State { get; }

        /// <summary>
        /// Gets the street of the location.
        /// </summary>
        public string Street { get; }

        /// <summary>
        /// Gets the zip code of the location.
        /// </summary>
        public string Zip { get; }

        #endregion

        #region Constructors

        private FacebookLocation(JObject obj) : base(obj) {
            City = obj.GetString("city");
            // TODO: Add support for the "city_id" property
            Country = obj.GetString("country");
            // TODO: Add support for the "country_code" property
            Latitude = obj.GetDouble("latitude");
            // TODO: Add support for the "located_in" property
            Longitude = obj.GetDouble("longitude");
            Name = obj.GetString("name");
            // TODO: Add support for the "region" property
            // TODO: Add support for the "region_id" property
            State = obj.GetString("state");
            Street = obj.GetString("street");
            Zip = obj.GetString("zip");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookLocation"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookLocation"/>.</returns>
        public static FacebookLocation Parse(JObject obj) {
            return obj == null ? null : new FacebookLocation(obj);
        }

        #endregion

    }

}