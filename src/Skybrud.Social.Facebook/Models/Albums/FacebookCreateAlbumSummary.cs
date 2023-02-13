using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Albums {

    /// <summary>
    /// Class representing a summary about a created album.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page/albums#Creating</cref>
    /// </see>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/user/albums#Creating</cref>
    /// </see>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/group/albums#publish</cref>
    /// </see>
    public class FacebookCreateAlbumSummary : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the album.
        /// </summary>
        public string Id { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookCreateAlbumSummary(JObject obj) : base(obj) {
            Id = obj.GetString("id");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookCreateAlbumSummary"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookCreateAlbumSummary"/>.</returns>
        public static FacebookCreateAlbumSummary Parse(JObject obj) {
            return obj == null ? null : new FacebookCreateAlbumSummary(obj);
        }

        #endregion

    }

}