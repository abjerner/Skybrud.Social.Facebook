using System;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Facebook.Options.Albums {
    
    /// <summary>
    /// Class representing the options for a call to the Facebook Graph API to get information about a single album.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/album#read</cref>
    /// </see>
    public class FacebookGetAlbumOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID) of the album.
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
        public FacebookGetAlbumOptions() {
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the album.</param>
        public FacebookGetAlbumOptions(string identifier) : this() {
            Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/> and <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the album.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetAlbumOptions(string identifier, FacebookFieldsCollection fields) {
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
            string fields = (Fields == null ? "" : Fields.ToString()).Trim();

            // Construct the query string
            IHttpQueryString query = new SocialHttpQueryString();
            if (!String.IsNullOrWhiteSpace(fields)) query.Set("fields", fields);

            return query;

        }

        #endregion

    }

}