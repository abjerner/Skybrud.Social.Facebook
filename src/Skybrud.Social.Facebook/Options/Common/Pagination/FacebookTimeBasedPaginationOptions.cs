using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Facebook.Options.Common.Pagination {

    /// <summary>
    /// Description from Facebook: Time pagination is used to navigate through results data using Unix timestamps which
    /// point to specific times in a list of data.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/using-graph-api/v2.2#time</cref>
    /// </see>
    public class FacebookTimeBasedPaginationOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the number of individual objects that are returned in each page.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the timestamp that points to the start of the range of time-based data.
        /// </summary>
        public EssentialsTime Since { get; set; }

        /// <summary>
        /// Gets or sets the timestamp that points to the end of the range of time-based data.
        /// </summary>
        public EssentialsTime Until { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default values.
        /// </summary>
        protected FacebookTimeBasedPaginationOptions() {
            Limit = -1;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public virtual IHttpQueryString GetQueryString() {
            HttpQueryString query = new HttpQueryString();
            if (Limit >= 0) query.Set("limit", Limit);
            if (Since != null && Since.UnixTimestamp > 0) query.Set("since", Since.UnixTimestamp);
            if (Until != null && Until.UnixTimestamp > 0) query.Set("until", Until.UnixTimestamp);
            return query;
        }

        #endregion

    }

}