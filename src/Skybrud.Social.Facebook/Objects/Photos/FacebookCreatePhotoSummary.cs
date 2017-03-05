using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Photos {

    /// <summary>
    /// Class representing a summary about a created photo.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/album/photos#publish</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/page/photos/#Creating</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/user/photos/#Creating</cref>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/group/photos#publish</cref>
    /// </see>
    public class FacebookCreatePhotoSummary : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the photo.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the ID of the post about the photo.
        /// </summary>
        public string PostId { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="PostId"/> property was included in the response.
        /// </summary>
        public bool HasPostId {
            get { return !String.IsNullOrWhiteSpace(PostId); }
        }

        #endregion

        #region Constructors

        private FacebookCreatePhotoSummary(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            PostId = obj.GetString("post_id");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookCreatePhotoSummary"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookCreatePhotoSummary"/>.</returns>
        public static FacebookCreatePhotoSummary Parse(JObject obj) {
            return obj == null ? null : new FacebookCreatePhotoSummary(obj);
        }

        #endregion

    }

}