using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Facebook.Objects.Common;

namespace Skybrud.Social.Facebook.Objects.Places {

    /// <summary>
    /// Class representing a Facebook place.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/place/</cref>
    /// </see>
    public class FacebookPlace : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the place.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets whether the place has an ID.
        /// </summary>
        public bool HasId {
            get { return !String.IsNullOrWhiteSpace(Id); }
        }

        /// <summary>
        /// Gets the name of place.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets information about the location of the place.
        /// </summary>
        public FacebookLocation Location { get; private set; }

        /// <summary>
        /// Gets whether a location has been specified for the place.
        /// </summary>
        public bool HasLocation {
            get { return Location != null; }
        }

        #endregion

        #region Constructor

        private FacebookPlace(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
            Location = obj.GetObject("location", FacebookLocation.Parse);
            // TODO: Add support for the "overall_rating" property
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookPlace"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPlace"/>.</returns>
        public static FacebookPlace Parse(JObject obj) {
            return obj == null ? null : new FacebookPlace(obj);
        }

        #endregion

    }

}