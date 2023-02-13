﻿using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Models.Users;

namespace Skybrud.Social.Facebook.Models.Common {

    /// <summary>
    /// Class representing a project experience of a Facebook user.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/project-experience/#Reading</cref>
    /// </see>
    public class FacebookProjectExperience : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the description about the experience.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets whether the <see cref="Description"/> property was included in the response.
        /// </summary>
        public bool HasDescription => string.IsNullOrWhiteSpace(Description) == false;

        /// <summary>
        /// Gets the end date of the project experience.
        /// </summary>
        public EssentialsTime EndDate { get; }

        /// <summary>
        /// Gets whether the <see cref="EndDate"/> property was included in the response.
        /// </summary>
        public bool HasEndDate => EndDate != null;

        /// <summary>
        ///
        /// </summary>
        public FacebookUser From { get; }

        /// <summary>
        /// Gets whether the <see cref="From"/> property was included in the response.
        /// </summary>
        public bool HasFrom => From != null;

        /// <summary>
        /// Gets the name of the experience.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets whether the <see cref="Name"/> property was included in the response.
        /// </summary>
        public bool HasName => string.IsNullOrWhiteSpace(Name) == false;

        /// <summary>
        /// Gets the start date of the project experience.
        /// </summary>
        public EssentialsTime StartDate { get; }

        /// <summary>
        /// Gets whether the <see cref="StartDate"/> property was included in the response.
        /// </summary>
        public bool HasStartDate => StartDate != null;

        /// <summary>
        /// Gets an array of users tagged in the experience.
        /// </summary>
        public FacebookUser[] With { get; }

        /// <summary>
        /// Gets whether the <see cref="With"/> property was included in the response.
        /// </summary>
        public bool HasWith => With.Any();

        #endregion

        #region Constructors

        private FacebookProjectExperience(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Description = obj.GetString("description");
            EndDate = obj.GetString("end_date", EssentialsTime.Parse);
            From = obj.GetObject("from", FacebookUser.Parse);
            Name = obj.GetString("name");
            StartDate = obj.GetString("start_date", EssentialsTime.Parse);
            With = obj.GetArrayItems("with", FacebookUser.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookProjectExperience"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookProjectExperience"/>.</returns>
        public static FacebookProjectExperience Parse(JObject obj) {
            return obj == null ? null : new FacebookProjectExperience(obj);
        }

        #endregion

    }

}