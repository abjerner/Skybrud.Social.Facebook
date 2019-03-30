using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Facebook.Models.Pagination;

namespace Skybrud.Social.Facebook.Models.Albums {

    /// <summary>
    /// Class representing a collection of albums as returned by the Facebook Graph API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page/albums/#Reading</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/user/albums/#Reading</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/group/albums#Reading</cref>
    /// </see>
    public class FacebookAlbumsCollection : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets an array of the <see cref="FacebookAlbum"/> returned in the response.
        /// </summary>
        public FacebookAlbum[] Data { get; }

        /// <summary>
        /// Gets pagination information about the response.
        /// </summary>
        public FacebookCursorBasedPagination Paging { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookAlbumsCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookAlbum.Parse);
            Paging = obj.GetObject("paging", FacebookCursorBasedPagination.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookAlbumsCollection"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookAlbumsCollection"/>.</returns>
        public static FacebookAlbumsCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookAlbumsCollection(obj);
        }

        #endregion
    
    }

}