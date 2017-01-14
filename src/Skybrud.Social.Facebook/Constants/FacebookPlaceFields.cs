using Skybrud.Social.Facebook.Fields;

namespace Skybrud.Social.Facebook.Constants {

    /// <summary>
    /// Static class with constants for the fields available for a Facebook place. The class is auto-generated and
    /// based on the fields listed in the Facebook Graph API documentation. Not all fields may have been mapped for the
    /// implementation in Skybrud.Social.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/place/</cref>
    /// </see>
    public static class FacebookPlaceFields {

        /// <summary>
        /// The place ID.
        /// </summary>
        public static readonly FacebookField Id = new FacebookField("id");

        /// <summary>
        /// The location of the place.
        /// </summary>
        public static readonly FacebookField Location = new FacebookField("location");

        /// <summary>
        /// The name of the place.
        /// </summary>
        public static readonly FacebookField Name = new FacebookField("name");

        /// <summary>
        /// The overall rating of the place.
        /// </summary>
        public static readonly FacebookField OverallRating = new FacebookField("overall_rating");

    }

}