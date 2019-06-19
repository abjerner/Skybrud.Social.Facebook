using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Strings;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Models.Events;
using Skybrud.Social.Facebook.Options.Common.Pagination;

namespace Skybrud.Social.Facebook.Options.Events {
    
    /// <summary>
    /// Class representing the options for a call to the Facebook Graph API to get a list of events.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/page/events/#Reading</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/events/#Reading</cref>
    /// </see>
    public class FacebookGetEventsOptions : FacebookCursorBasedPaginationOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier of the parent page or user.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets whether canceled events should be included in the response. Default is <c>false</c>.
        /// </summary>
        public bool IncludeCanceled { get; set; }

        /// <summary>
        /// Gets or sets the RSVP status of the events to be returned. Default is <see cref="FacebookEventRsvpStatus.All"/>.
        /// </summary>
        public FacebookEventRsvpStatus Type { get; set; }

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public FacebookFieldsCollection Fields { get; set; }

        #endregion
        
        #region Constructors

        /// <summary>
        /// Initializes an instance with default options.
        /// </summary>
        public FacebookGetEventsOptions() {
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes an instance with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID) of the user.</param>
        public FacebookGetEventsOptions(string identifier) : this() {
            Identifier = identifier;
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
            if (IncludeCanceled) query.Add("include_canceled", "true");
            if (Type != FacebookEventRsvpStatus.All) query.Add("type", StringUtils.ToUnderscore(Type));
            if (string.IsNullOrWhiteSpace(fields) == false) query.Set("fields", fields);

            return query;

        }

        #endregion

    }

}