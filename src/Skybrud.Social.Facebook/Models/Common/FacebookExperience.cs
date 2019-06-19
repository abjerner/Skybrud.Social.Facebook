using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Facebook.Models.Users;

namespace Skybrud.Social.Facebook.Models.Common {

    /// <summary>
    /// Class representing an  experience of a Facebook user.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/experience/#Reading</cref>
    /// </see>
    public class FacebookExperience : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the experience.
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
        /// From.
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
        /// Gets an array of the tagged users.
        /// </summary>
        public FacebookUser[] With { get; }

        /// <summary>
        /// Gets whether the <see cref="With"/> property was included in the response.
        /// </summary>
        public bool HasWith => With.Any();

        #endregion

        #region Constructors

        private FacebookExperience(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Description = obj.GetString("description");
            From = obj.GetObject("from", FacebookUser.Parse);
            Name = obj.GetString("name");
            With = obj.GetArrayItems("with", FacebookUser.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookExperience"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookExperience"/>.</returns>
        public static FacebookExperience Parse(JObject obj) {
            return obj == null ? null : new FacebookExperience(obj);
        }

        #endregion

    }

}