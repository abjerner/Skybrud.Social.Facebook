using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;
using Skybrud.Social.Facebook.Fields;

namespace Skybrud.Social.Facebook.Options.User {
    
    /// <summary>
    /// Class representing the options for a call to the Facebook Graph API to get information about a single user.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/user#Reading</cref>
    /// </see>
    public class FacebookGetUserOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID) of the user.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public FacebookFieldsCollection Fields { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public FacebookGetUserOptions() {
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the user.</param>
        public FacebookGetUserOptions(string identifier) : this() {
            Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the user.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetUserOptions(string identifier, FacebookFieldsCollection fields) {
            Identifier = identifier;
            Fields = fields ?? new FacebookFieldsCollection();
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public IHttpQueryString GetQueryString() {

            // Convert the collection of fields to a string
            string fields = (Fields == null ? string.Empty : Fields.ToString()).Trim();

            // Construct the query string
            HttpQueryString query = new HttpQueryString();
            if (string.IsNullOrWhiteSpace(fields) == false) query.Set("fields", fields);

            return query;

        }

        #endregion
    
    }

}