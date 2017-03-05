using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Objects.Pages;
using Skybrud.Social.Facebook.Objects.Users;

namespace Skybrud.Social.Facebook.Objects.Common {
    
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
        public string Id { get; internal set; }

        /// <summary>
        /// Gets the description about the experience.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Description"/> property was included in the response.
        /// </summary>
        public bool HasDescription {
            get { return !String.IsNullOrWhiteSpace(Description); }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public FacebookPage Employer { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Description"/> property was included in the response.
        /// </summary>
        public bool HasEmployer {
            get { return Employer != null; }
        }

        /// <summary>
        /// 
        /// </summary>
        public EssentialsDateTime EndDate { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="EndDate"/> property was included in the response.
        /// </summary>
        public bool HasEndDate {
            get { return EndDate != null; }
        }

        /// <summary>
        /// 
        /// </summary>
        public FacebookUser From { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="From"/> property was included in the response.
        /// </summary>
        public bool HasFrom {
            get { return From != null; }
        }

        /// <summary>
        /// 
        /// </summary>
        public FacebookPage Location { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Location"/> property was included in the response.
        /// </summary>
        public bool HasLocation {
            get { return Location != null; }
        }

        /// <summary>
        /// 
        /// </summary>
        public FacebookPage Position { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Position"/> property was included in the response.
        /// </summary>
        public bool HasPosition {
            get { return Position != null; }
        }

        /// <summary>
        /// Gets an array of projects the person has worked on.
        /// </summary>
        public FacebookProjectExperience[] Projects { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Projects"/> property was included in the response.
        /// </summary>
        public bool HasProjects {
            get { return Projects.Any(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public EssentialsDateTime StartDate { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="StartDate"/> property was included in the response.
        /// </summary>
        public bool HasStartDate {
            get { return StartDate != null; }
        }

        /// <summary>
        /// 
        /// </summary>
        public FacebookUser[] With { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="With"/> property was included in the response.
        /// </summary>
        public bool HasWith {
            get { return With.Any(); }
        }

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