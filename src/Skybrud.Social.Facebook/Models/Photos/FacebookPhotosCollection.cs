using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Social.Facebook.Models.Pagination;

namespace Skybrud.Social.Facebook.Models.Photos {

    /// <summary>
    /// Class representing a collection of photos as returned by the Facebook Graph API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/album/photos#read</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page/photos/#Reading</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/user/photos/#Reading</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/group/photos#Reading</cref>
    /// </see>
    public class FacebookPhotosCollection : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets an array of the <see cref="FacebookPhoto"/> returned in the response.
        /// </summary>
        public FacebookPhoto[] Data { get; }

        /// <summary>
        /// Gets pagination information about the response.
        /// </summary>
        public FacebookCursorBasedPagination Paging { get; }

        #endregion

        #region Constructors

        private FacebookPhotosCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookPhoto.Parse);
            Paging = obj.GetObject("paging", FacebookCursorBasedPagination.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookPhotosCollection"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPhotosCollection"/>.</returns>
        public static FacebookPhotosCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookPhotosCollection(obj);
        }

        #endregion

    }

}