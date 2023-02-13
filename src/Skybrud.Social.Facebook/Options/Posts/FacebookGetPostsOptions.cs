using System.Diagnostics.CodeAnalysis;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Common.Pagination;

namespace Skybrud.Social.Facebook.Options.Posts {

    /// <summary>
    /// Class representing the options for a call to the Facebook Graph API to get a list of posts.
    /// </summary>
    public class FacebookGetPostsOptions : FacebookCursorBasedPaginationOptions, IHttpRequestOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID) of the page or user.
        /// </summary>
#if NET7_0_OR_GREATER
        public required string Identifier { get; set; }
#else
        public string? Identifier { get; set; }
#endif

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public FacebookFieldList Fields { get; set; }

        /// <summary>
        /// Gets or sets whether or not to include any posts that were hidden by the Page. Defaults to
        /// <c>false</c>.
        /// </summary>
        public bool? IncludeHidden { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an instance with default options.
        /// </summary>
        public FacebookGetPostsOptions() {
            Fields = new FacebookFieldList();
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the page or user.</param>
#if NET7_0_OR_GREATER
        [SetsRequiredMembers]
#endif
        public FacebookGetPostsOptions(string identifier) {
            Identifier = identifier;
            Fields = new FacebookFieldList();
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="identifier"/> and collection of
        /// <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the page or user.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
#if NET7_0_OR_GREATER
        [SetsRequiredMembers]
#endif
        public FacebookGetPostsOptions(string identifier, FacebookFieldList? fields)  {
            Identifier = identifier;
            Fields = fields ?? new FacebookFieldList();
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="identifier"/> and
        /// <paramref name="limit"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the page or user.</param>
        /// <param name="limit">The maximum amount of items to be returned per page.</param>
#if NET7_0_OR_GREATER
        [SetsRequiredMembers]
#endif
        public FacebookGetPostsOptions(string identifier, int? limit) {
            Identifier = identifier;
            Limit = limit;
            Fields = new FacebookFieldList();
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="identifier"/>, <paramref name="limit"/>
        /// and collection of <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the page or user.</param>
        /// <param name="limit">The maximum amount of items to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
#if NET7_0_OR_GREATER
        [SetsRequiredMembers]
#endif
        public FacebookGetPostsOptions(string identifier, int? limit, FacebookFieldList? fields) {
            Identifier = identifier;
            Limit = limit;
            Fields = fields ?? new FacebookFieldList();
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public override IHttpQueryString GetQueryString() {

            // Get the query string
            IHttpQueryString query = base.GetQueryString();

            // Update the query string
            if (Fields is { Count: > 0 }) query.Set("fields", Fields);
            if (IncludeHidden is not null) query.Add("include_hidden", IncludeHidden);

            return query;

        }

        /// <inheritdoc />
        public IHttpRequest GetRequest() {

            // Validate required properties
            if (string.IsNullOrWhiteSpace(Identifier)) throw new PropertyNotSetException(nameof(Identifier));

            // Initialize the query string
            IHttpQueryString query = GetQueryString();

            // Initialize a new GET request
            return HttpRequest.Get($"/{Identifier}/posts", query);

        }

        #endregion

    }

}