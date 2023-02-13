using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;
using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Options.Common.Pagination;

namespace Skybrud.Social.Facebook.Options.Accounts {

    /// <summary>
    /// Class representing the options for a call to the Facebook Graph API to get accounts of the authenticated user.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/accounts/</cref>
    /// </see>
    public class FacebookGetAccountsOptions : FacebookCursorBasedPaginationOptions, IHttpRequestOptions {

        #region Properties

        /// <summary>
        /// Gets or sets a specific business ID that the returned accounts should match.
        /// </summary>
        public string? BusinessId { get; set; }

        /// <summary>
        /// If specified, pages are filtered based on whether they are associated with a Business manager or not.
        /// </summary>
        public bool? IsBusiness { get; set; }

        /// <summary>
        /// If specified, pages are filtered based on whether they are places or not.
        /// </summary>
        public bool? IsPlace { get; set; }

        /// <summary>
        /// If specified, pages are filtered based on whether they can be promoted or not.
        /// </summary>
        public bool? IsPromotable { get; set; }

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public FacebookFieldList Fields { get; set; }

        /// <summary>
        /// Gets or sets whether a summary should be included in the response. Default is <c>false</c>.
        /// </summary>
        public bool? IncludeSummary { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an instance with default options.
        /// </summary>
        public FacebookGetAccountsOptions() {
            Fields = new FacebookFieldList();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="fields"/>.
        /// </summary>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetAccountsOptions(FacebookFieldList? fields) {
            Fields = fields ?? new FacebookFieldList();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="limit"/>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        public FacebookGetAccountsOptions(int? limit) {
            Limit = limit;
            Fields = new FacebookFieldList();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="limit"/> and <paramref name="fields"/>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetAccountsOptions(int? limit, FacebookFieldList? fields) {
            Limit = limit;
            Fields = fields ?? new FacebookFieldList();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="limit"/> and <paramref name="after"/> cursor.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        public FacebookGetAccountsOptions(int? limit, string? after) {
            Limit = limit;
            After = after;
            Fields = new FacebookFieldList();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="limit"/>, <paramref name="after"/> cursor and <paramref name="fields"/>.
        /// </summary>
        /// <param name="limit">The maximum amount of albums to be returned per page.</param>
        /// <param name="after">The cursor pointing to the last item on the previous page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
        public FacebookGetAccountsOptions(int? limit, string? after, FacebookFieldList? fields) {
            Limit = limit;
            After = after;
            Fields = fields ?? new FacebookFieldList();
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public override IHttpQueryString GetQueryString() {

            // Construct the query string
            IHttpQueryString query = base.GetQueryString();
            if (!string.IsNullOrWhiteSpace(BusinessId)) query.Set("business_id", BusinessId!);
            if (IsBusiness is not null) query.Set("is_business", IsBusiness);
            if (IsPlace is not null) query.Set("is_place", IsPlace);
            if (IsPromotable is not null) query.Set("is_promotable", IsPromotable);
            if (Fields is {Count: > 0}) query.Set("fields", Fields);
            if (IncludeSummary is not null) query.Add("summary", IncludeSummary);

            return query;

        }

        /// <inheritdoc />
        public IHttpRequest GetRequest() {
            return HttpRequest.Get("/me/accounts/", GetQueryString());
        }

        #endregion

    }

}