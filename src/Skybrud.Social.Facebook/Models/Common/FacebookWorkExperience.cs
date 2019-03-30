using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Models.Pages;
using Skybrud.Social.Facebook.Models.Users;

namespace Skybrud.Social.Facebook.Models.Common {
    
    /// <summary>
    /// Class representing a work experience of a Facebook user.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/work-experience/#Reading</cref>
    /// </see>
    public class FacebookWorkExperience : FacebookObject {

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
        public bool HasDescription => !String.IsNullOrWhiteSpace(Description);

        /// <summary>
        /// 
        /// </summary>
        public FacebookPage Employer { get; }

        /// <summary>
        /// Gets whether the <see cref="Description"/> property was included in the response.
        /// </summary>
        public bool HasEmployer => Employer != null;

        /// <summary>
        /// 
        /// </summary>
        public EssentialsDateTime EndDate { get; }

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
        /// 
        /// </summary>
        public FacebookPage Location { get; }

        /// <summary>
        /// Gets whether the <see cref="Location"/> property was included in the response.
        /// </summary>
        public bool HasLocation => Location != null;

        /// <summary>
        /// 
        /// </summary>
        public FacebookPage Position { get; }

        /// <summary>
        /// Gets whether the <see cref="Position"/> property was included in the response.
        /// </summary>
        public bool HasPosition => Position != null;

        /// <summary>
        /// Gets an array of projects the person has worked on.
        /// </summary>
        public FacebookProjectExperience[] Projects { get; }

        /// <summary>
        /// Gets whether the <see cref="Projects"/> property was included in the response.
        /// </summary>
        public bool HasProjects => Projects.Any();

        /// <summary>
        /// 
        /// </summary>
        public EssentialsDateTime StartDate { get; }

        /// <summary>
        /// Gets whether the <see cref="StartDate"/> property was included in the response.
        /// </summary>
        public bool HasStartDate => StartDate != null;

        /// <summary>
        /// 
        /// </summary>
        public FacebookUser[] With { get; }

        /// <summary>
        /// Gets whether the <see cref="With"/> property was included in the response.
        /// </summary>
        public bool HasWith => With.Any();

        #endregion

        #region Constructors

        private FacebookWorkExperience(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Description = obj.GetString("description");
            Employer = obj.GetObject("employer", FacebookPage.Parse);
            EndDate = obj.GetString("end_date", EssentialsDateTime.Parse);
            From = obj.GetObject("from", FacebookUser.Parse);
            Location = obj.GetObject("location", FacebookPage.Parse);
            Position = obj.GetObject("position", FacebookPage.Parse);
            Projects = obj.GetArrayItems("projects", FacebookProjectExperience.Parse);
            StartDate = obj.GetString("start_date", EssentialsDateTime.Parse);
            With = obj.GetArrayItems("with", FacebookUser.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookWorkExperience"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookWorkExperience"/>.</returns>
        public static FacebookWorkExperience Parse(JObject obj) {
            return obj == null ? null : new FacebookWorkExperience(obj);
        }

        #endregion

    }

}