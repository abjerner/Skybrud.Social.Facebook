using System;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Common.Pagination;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Facebook.Options.Comments {
    
    /// <summary>
    /// Class representing the options for getting a list of comments.
    /// </summary>
    public class FacebookGetCommentsOptions : FacebookCursorBasedPaginationOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID) of the parent object.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public FacebookFieldsCollection Fields { get; set; }

        /// <summary>
        /// Gets or sets whether a summary of metadata about the comments on the object should be included in the
        /// response. The summary will contain the total count of comments and how the comments are sorted (either
        /// <code>ranked</code> or <code>chronological</code>).
        /// </summary>
        public bool IncludeSummary { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes the class with default options.
        /// </summary>
        public FacebookGetCommentsOptions() { }

        /// <summary>
        /// Initializes the class with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        public FacebookGetCommentsOptions(string identifier) {
            Identifier = identifier;
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes the class with the specified <paramref name="identifier"/> and <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetCommentsOptions(string identifier, FacebookFieldsCollection fields) {
            Identifier = identifier;
            Fields = fields ?? new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes the class with the specified <paramref name="identifier"/> and <paramref name="limit"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The limit.</param>
        public FacebookGetCommentsOptions(string identifier, int limit) {
            Identifier = identifier;
            Limit = limit;
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes the class with the specified <paramref name="identifier"/>, <paramref name="limit"/> and
        /// <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetCommentsOptions(string identifier, int limit, FacebookFieldsCollection fields) {
            Identifier = identifier;
            Limit = limit;
            Fields = fields ?? new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes the class with the specified <paramref name="identifier"/>, <paramref name="limit"/> and
        /// <paramref name="after"/> cursor.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="after">The after cursor.</param>
        public FacebookGetCommentsOptions(string identifier, int limit, string after) {
            Identifier = identifier;
            Limit = limit;
            After = after;
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes the class with the specified <paramref name="identifier"/>, <paramref name="limit"/>,
        /// <paramref name="after"/> cursor and <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="after">The after cursor.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetCommentsOptions(string identifier, int limit, string after, FacebookFieldsCollection fields) {
            Identifier = identifier;
            Limit = limit;
            After = after;
            Fields = fields ?? new FacebookFieldsCollection();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public override IHttpQueryString GetQueryString() {
            
            IHttpQueryString query = base.GetQueryString();

            // Convert the collection of fields to a string
            string fields = (Fields == null ? "" : Fields.ToString()).Trim();

            // Construct the query string
            if (!String.IsNullOrWhiteSpace(fields)) query.Set("fields", fields);
            if (IncludeSummary) query.Set("summary", "true");
            
            // TODO: Implement the "filter" modifier
            
            return query;
        
        }

        #endregion

    }

}