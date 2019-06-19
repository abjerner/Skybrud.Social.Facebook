using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;
using Skybrud.Social.Facebook.Fields;

namespace Skybrud.Social.Facebook.Options.Posts {
    
    /// <summary>
    /// Class representing the options for a call to the Facebook Graph API to get information about a single post.
    /// </summary>
    public class FacebookGetPostOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID) of the post.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public FacebookFieldsCollection Fields { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an instance with default options.
        /// </summary>
        public FacebookGetPostOptions() {
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes an instance with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the post.</param>
        public FacebookGetPostOptions(string identifier) : this() {
            Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="identifier"/> and collection of
        /// <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the post.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetPostOptions(string identifier, FacebookFieldsCollection fields) : this() {
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