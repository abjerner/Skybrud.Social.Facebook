using System;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Common.Pagination;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Facebook.Options.Likes {
    
    /// <summary>
    /// Class representing the options for getting a list of likes.
    /// </summary>
    public class FacebookGetLikesOptions : FacebookCursorBasedPaginationOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID) of the parent object.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets whether a summary of metadata about the likes on the object should be included in the
        /// response. The summary will contain the total count of likes.
        /// </summary>
        public bool IncludeSummary { get; set; }

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public FacebookFieldsCollection Fields { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public FacebookGetLikesOptions() {
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the parent object.</param>
        public FacebookGetLikesOptions(string identifier) {
            Identifier = identifier;
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/> and <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetLikesOptions(string identifier, FacebookFieldsCollection fields) {
            Identifier = identifier;
            Fields = fields ?? new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/> and <paramref name="limit"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        public FacebookGetLikesOptions(string identifier, int limit) {
            Identifier = identifier;
            Limit = limit;
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/>, <paramref name="limit"/> and
        /// <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetLikesOptions(string identifier, int limit, FacebookFieldsCollection fields) {
            Identifier = identifier;
            Limit = limit;
            Fields = fields ?? new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/>, <paramref name="limit"/>,
        /// <paramref name="after"/> cursor and <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the parent object.</param>
        /// <param name="limit">The maximum amount of likes to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetLikesOptions(string identifier, int limit, string after, FacebookFieldsCollection fields) {
            Identifier = identifier;
            Limit = limit;
            After = after;
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
            string fields = (Fields == null ? "" : Fields.ToString()).Trim();

            // Update the query string
            if (!String.IsNullOrWhiteSpace(fields)) query.Set("fields", fields);

            return query;

        }

        #endregion

    }

}