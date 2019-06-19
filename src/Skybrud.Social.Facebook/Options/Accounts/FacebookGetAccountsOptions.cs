using Skybrud.Essentials.Http.Collections;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Models.Common;
using Skybrud.Social.Facebook.Options.Common.Pagination;

namespace Skybrud.Social.Facebook.Options.Accounts {
    
    /// <summary>
    /// Class representing the options for a call to the Facebook Graph API to get accounts of the authenticated user.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/accounts/</cref>
    /// </see>
    public class FacebookGetAccountsOptions : FacebookCursorBasedPaginationOptions {

        #region Properties
        
        /// <summary>
        /// Gets or sets a specific business ID that the returned accounts should match.
        /// </summary>
        public string BusinessId { get; set; }

        /// <summary>
        /// If specified, pages are filtered based on whether they are associated with a Business manager or not.
        /// </summary>
        public FacebookBoolean IsBusiness { get; set; }

        /// <summary>
        /// If specified, pages are filtered based on whether they are places or not.
        /// </summary>
        public FacebookBoolean IsPlace { get; set; }

        /// <summary>
        /// If specified, pages are filtered based on whether they can be promoted or not.
        /// </summary>
        public FacebookBoolean IsPromotable { get; set; }

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public FacebookFieldsCollection Fields { get; set; }

        /// <summary>
        /// Gets or sets whether a summary should be included in the response. Default is <c>false</c>.
        /// </summary>
        public bool IncludeSummary { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an instance with default options.
        /// </summary>
        public FacebookGetAccountsOptions() {
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="fields"/>.
        /// </summary>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetAccountsOptions(FacebookFieldsCollection fields) {
            Fields = fields ?? new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="limit"/>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        public FacebookGetAccountsOptions(int limit) {
            Limit = limit;
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="limit"/> and <paramref name="fields"/>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetAccountsOptions(int limit, FacebookFieldsCollection fields) {
            Limit = limit;
            Fields = fields ?? new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="limit"/> and <paramref name="after"/> cursor.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        public FacebookGetAccountsOptions(int limit, string after) {
            Limit = limit;
            After = after;
            Fields = new FacebookFieldsCollection();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="limit"/>, <paramref name="after"/> cursor and <paramref name="fields"/>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetAccountsOptions(int limit, string after, FacebookFieldsCollection fields) {
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

            // Convert the collection of fields to a string
            string fields = (Fields == null ? string.Empty : Fields.ToString()).Trim();

            // Construct the query string
            IHttpQueryString query = base.GetQueryString();
            if (string.IsNullOrWhiteSpace(BusinessId) == false) query.Set("business_id", BusinessId);
            if (IsBusiness != FacebookBoolean.Unspecified) query.Set("is_business", IsBusiness);
            if (IsPlace != FacebookBoolean.Unspecified) query.Set("is_place", IsPlace);
            if (IsPromotable != FacebookBoolean.Unspecified) query.Set("is_promotable", IsPromotable);
            if (string.IsNullOrWhiteSpace(fields) == false) query.Set("fields", fields);
            if (IncludeSummary) query.Add("summary", "true");

            return query;

        }

        #endregion
    
    }

}