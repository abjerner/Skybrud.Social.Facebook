using Skybrud.Social.Facebook.Options.Common.Pagination;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Facebook.Options.Likes {

    public class FacebookGetLikesOptions : FacebookCursorBasedPaginationOptions {

        #region Properties

        /// <summary>
        /// Gets or sets whether a summary of metadata about the likes on the object should be included in the
        /// response. The summary will contain the total count of likes.
        /// </summary>
        public bool IncludeSummary { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public override IHttpQueryString GetQueryString() {
            IHttpQueryString query = base.GetQueryString();
            if (IncludeSummary) query.Set("summary", "true");
            return query;
        }

        #endregion

    }

}
