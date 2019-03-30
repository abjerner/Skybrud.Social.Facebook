using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Facebook.Models.Applications;
using Skybrud.Social.Facebook.Models.Events;
using Skybrud.Social.Facebook.Models.Pages;
using Skybrud.Social.Facebook.Models.Users;

namespace Skybrud.Social.Facebook.Models.Common {

    /// <summary>
    /// Class representing a Facebook profile. 
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/profile</cref>
    /// </see>
    public class FacebookProfile : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the profile.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the name of the profile.
        /// </summary>
        public string Name { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookProfile"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookProfile"/>.</returns>
        protected FacebookProfile(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the profile as a Facebook user.
        /// </summary>
        /// <returns>An instance of <see cref="FacebookUser"/>.</returns>
        public FacebookUser AsUser() {
            return FacebookUser.Parse(JObject);
        }

        /// <summary>
        /// Gets the profile as a Facebook page.
        /// </summary>
        /// <returns>An instance of <see cref="FacebookPage"/>.</returns>
        public FacebookPage AsPage() {
            return FacebookPage.Parse(JObject);
        }

        // TODO: Implement "AsGroup"

        /// <summary>
        /// Gets the profile as a Facebook event.
        /// </summary>
        /// <returns>An instance of <see cref="FacebookEvent"/>.</returns>
        public FacebookEvent AsEvent() {
            return FacebookEvent.Parse(JObject);
        }

        /// <summary>
        /// Gets the profile as a Facebook application.
        /// </summary>
        /// <returns>An instance of <see cref="FacebookEvent"/>.</returns>
        public FacebookApplication AsApplication() {
            return FacebookApplication.Parse(JObject);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookProfile"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookProfile"/>.</returns>
        public static FacebookProfile Parse(JObject obj) {
            return obj == null ? null : new FacebookProfile(obj);
        }

        #endregion

    }

}