using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Facebook.Objects.Pages;
using Skybrud.Social.Facebook.Objects.Users;

namespace Skybrud.Social.Facebook.Objects.Common {
    
    /// <summary>
    /// Class representing a work experience of a Facebook user.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/education-experience/#Reading</cref>
    /// </see>
    public class FacebookEducationExperience : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID.
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        /// Gets an array of the classes taken.
        /// </summary>
        public FacebookExperience[] Classes { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Classes"/> property was included in the response.
        /// </summary>
        public bool HasClasses {
            get { return Classes.Any(); }
        }

        /// <summary>
        /// Gets an array of the Facebook pages representing subjects studied.
        /// </summary>
        public FacebookPage[] Concentration { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Classes"/> property was included in the response.
        /// </summary>
        public bool HasConcentration {
            get { return Concentration.Any(); }
        }

        /// <summary>
        /// Gets the Facebook Page for the degree obtained
        /// </summary>
        public FacebookPage Degree { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Degree"/> property was included in the response.
        /// </summary>
        public bool HasDegree {
            get { return Degree != null; }
        }

        /// <summary>
        /// Gets the Facebook page for this school.
        /// </summary>
        public FacebookPage School { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="School"/> property was included in the response.
        /// </summary>
        public bool HasSchool {
            get { return School != null; }
        }

        /// <summary>
        /// Gets the type of educational institution.
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Type"/> property was included in the response.
        /// </summary>
        public bool HasType {
            get { return !String.IsNullOrWhiteSpace(Type); }
        }

        /// <summary>
        /// Gets an array of the people tagged who went to school with this person.
        /// </summary>
        public FacebookUser[] With { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="With"/> property was included in the response.
        /// </summary>
        public bool HasWith {
            get { return With.Any(); }
        }

        /// <summary>
        /// Gets the Facebook page for the year this person graduated.
        /// </summary>
        public FacebookPage Year { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Year"/> property was included in the response.
        /// </summary>
        public bool HasYear {
            get { return Year != null; }
        }

        #endregion

        #region Constructors

        private FacebookEducationExperience(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Classes = obj.GetArrayItems("classes", FacebookExperience.Parse);
            Concentration = obj.GetArrayItems("concentration", FacebookPage.Parse);
            Degree = obj.GetObject("degree", FacebookPage.Parse);
            School = obj.GetObject("school", FacebookPage.Parse);
            Type = obj.GetString("type");
            With = obj.GetArrayItems("with", FacebookUser.Parse);
            Year = obj.GetObject("year", FacebookPage.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookEducationExperience"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookEducationExperience"/>.</returns>
        public static FacebookEducationExperience Parse(JObject obj) {
            return obj == null ? null : new FacebookEducationExperience(obj);
        }

        #endregion

    }

}