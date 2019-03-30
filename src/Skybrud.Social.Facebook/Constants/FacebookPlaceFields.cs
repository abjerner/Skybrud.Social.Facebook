using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Models.Places;

namespace Skybrud.Social.Facebook.Constants {

    /// <summary>
    ///  Static class with constants for the fields available for a Facebook place (<see cref="FacebookPlace" />).
    ///  
    ///  The class is auto-generated and based on the fields listed in the Facebook Graph API documentation. Not all
    ///  fields may have been mapped for the implementation in Skybrud.Social.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.12/place</cref>
    /// </see>
    public static class FacebookPlaceFields {

        #region Individial fields

        /// <summary>
        /// ID.
        /// </summary>
        public static readonly FacebookField Id = new FacebookField("id");

        /// <summary>
        /// Location of Place.
        /// </summary>
        public static readonly FacebookField Location = new FacebookField("location");

        /// <summary>
        /// Name.
        /// </summary>
        public static readonly FacebookField Name = new FacebookField("name");

        /// <summary>
        /// Overall Rating of Place, on a 5-star scale. 0 means not enough data to get a combined rating.
        /// </summary>
        public static readonly FacebookField OverallRating = new FacebookField("overall_rating");

        #endregion

        /// <summary>
        /// Gets an array of all known fields available for a Facebook place.
        /// </summary>
        public static readonly FacebookField[] All = {
            Id, Location, Name, OverallRating
        };

    }

}