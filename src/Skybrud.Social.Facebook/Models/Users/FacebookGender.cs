﻿namespace Skybrud.Social.Facebook.Models.Users {

    /// <summary>
    /// Enumeration describing the gender of a Facebook user.
    /// </summary>
    public enum FacebookGender {

        /// <summary>
        /// Indicates that the <c>gender</c> field wasn't specified in the response from the Graph API.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// Indicates that the user hasn't entered or shared it's gender.
        /// </summary>
        Unknown,

        /// <summary>
        /// Indicates that the user is a male.
        /// </summary>
        Male,

        /// <summary>
        /// Indicates that the user is a female.
        /// </summary>
        Female

    }

}