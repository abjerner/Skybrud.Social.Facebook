using System.Diagnostics.CodeAnalysis;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;
using Skybrud.Social.Facebook.Fields;

namespace Skybrud.Social.Facebook.Options.Pages {

    /// <summary>
    /// Class representing the options for a call to the Facebook Graph API to get information about a single page.
    /// </summary>
    public class FacebookGetPageOptions : IHttpRequestOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID or alias) of the page.
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

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public FacebookGetPageOptions() {
            Fields = new FacebookFieldList();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the page.</param>
#if NET7_0_OR_GREATER
        [SetsRequiredMembers]
#endif
        public FacebookGetPageOptions(string identifier) : this() {
            Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/> and <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
#if NET7_0_OR_GREATER
        [SetsRequiredMembers]
#endif
        public FacebookGetPageOptions(string identifier, FacebookFieldList? fields) {
            Identifier = identifier;
            Fields = fields ?? new FacebookFieldList();
        }

        #endregion

        #region Member methods

        /// <inheritdoc />
        public IHttpRequest GetRequest() {

            // Validate required properties
            if (string.IsNullOrWhiteSpace(Identifier)) throw new PropertyNotSetException(nameof(Identifier));

            // Initialize the query string
            HttpQueryString query = new();
            if (Fields is { Count: > 0 }) query.Set("fields", Fields);

            // Initialize a new GET request
            return HttpRequest.Get($"/{Identifier}", query);

        }

        #endregion

    }

}