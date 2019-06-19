using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Common.Pagination;

namespace Skybrud.Social.Facebook.Options.Posts {

    /// <summary>
    /// Class representing the options for a call to the Facebook Graph API to get a list of posts.
    /// </summary>
    public class FacebookGetPostsOptions : FacebookTimeBasedPaginationOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID) of the page or user.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public FacebookFieldsCollection Fields { get; set; }

        /// <summary>
        /// Gets or sets whether or not to include any posts that were hidden by the Page. Defaults to
        /// <c>false</c>.
        /// </summary>
        public bool IncludeHidden { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an instance with default options.
        /// </summary>
        public FacebookGetPostsOptions() {
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the page or user.</param>
        public FacebookGetPostsOptions(string identifier) : this() {
            Identifier = identifier;
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="identifier"/> and collection of
        /// <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the page or user.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetPostsOptions(string identifier, FacebookFieldsCollection fields) : this() {
            Identifier = identifier;
            Fields = fields ?? new FacebookFieldsCollection();
        }
        
        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="identifier"/> and
        /// <paramref name="limit"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the page or user.</param>
        /// <param name="limit">The maximum amount of items to be returned per page.</param>
        public FacebookGetPostsOptions(string identifier, int limit) {
            Identifier = identifier;
            Limit = limit;
            Fields = new FacebookFieldsCollection();
        }
        
        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="identifier"/>, <paramref name="limit"/>
        /// and <paramref name="until"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the page or user.</param>
        /// <param name="limit">The maximum amount of items to be returned per page.</param>
        /// <param name="until">The timestamp that points to the end of the range of time-based data.</param>
        public FacebookGetPostsOptions(string identifier, int limit, EssentialsTime until) {
            Identifier = identifier;
            Limit = limit;
            Until = until;
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="identifier"/>, <paramref name="limit"/>
        /// and collection of <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the page or user.</param>
        /// <param name="limit">The maximum amount of items to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetPostsOptions(string identifier, int limit, FacebookFieldsCollection fields) : this() {
            Identifier = identifier;
            Limit = limit;
            Fields = fields ?? new FacebookFieldsCollection();
        }
        
        /// <summary>
        /// Initializes an instance with the specified <paramref name="identifier"/>, <paramref name="limit"/>,
        /// <paramref name="until"/> and collection of <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the page or user.</param>
        /// <param name="limit">The maximum amount of items to be returned per page.</param>
        /// <param name="until">The timestamp that points to the end of the range of time-based data.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetPostsOptions(string identifier, int limit, EssentialsTime until, FacebookFieldsCollection fields) : this() {
            Identifier = identifier;
            Limit = limit;
            Until = until;
            Fields = fields ?? new FacebookFieldsCollection();
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public override IHttpQueryString GetQueryString() {

            // Get the query string
            IHttpQueryString query = base.GetQueryString();

            // Convert the collection of fields to a string
            string fields = (Fields == null ? string.Empty : Fields.ToString()).Trim();

            // Update the query string
            if (string.IsNullOrWhiteSpace(fields) == false) query.Set("fields", fields);
            if (IncludeHidden) query.Add("include_hidden", "true");

            return query;

        }

        #endregion

    }

}