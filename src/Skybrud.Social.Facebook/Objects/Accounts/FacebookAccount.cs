using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Common;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Accounts {

    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/accounts/</cref>
    /// </see>
    public class FacebookAccount : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the account.
        /// </summary>
        public string Id { get; internal set; }

        /// <summary>
        /// Gets the name of the account.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the category of the account.
        /// </summary>
        public string Category { get; internal set; }

        /// <summary>
        /// Gets a list of sub categories of the account.
        /// </summary>
        public FacebookEntity[] CategoryList { get; private set; }

        /// <summary>
        /// The access token associated with the current user and the account. The access token may be
        /// <code>null</code> depending on the permissions.
        /// </summary>
        public string AccessToken { get; internal set; }

        /// <summary>
        /// Gets the permissions given to manage the account. Permissions may not be
        /// specified for all types of accounts.
        /// </summary>
        public string[] Permissions { get; internal set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookAccount(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
            Category = obj.GetString("category");
            CategoryList = obj.GetArrayItems("category_list", FacebookEntity.Parse);
            AccessToken = obj.GetString("access_token");
            Permissions = obj.GetStringArray("perms");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookAccount"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookAccount"/>.</returns>
        public static FacebookAccount Parse(JObject obj) {
            return obj == null ? null : new FacebookAccount(obj);
        }

        #endregion

    }

}