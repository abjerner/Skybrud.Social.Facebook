using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Facebook.Models.Albums {

    /// <summary>
    /// Class representing the cover photo of an album.
    /// </summary>
    public class FacebookAlbumCoverPhoto : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the cover photo.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets a timestamp representing the creation time of the cover photo.
        /// </summary>
        public EssentialsDateTime CreatedTime { get; }

        /// <summary>
        /// Gets the name of the cover photo, or <code>null</code> if not specified.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets whether the album has a name.
        /// </summary>
        public bool HasName => !String.IsNullOrWhiteSpace(Name);

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookAlbumCoverPhoto(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            CreatedTime = obj.GetString("created_time", EssentialsDateTime.Parse);
            Name = obj.GetString("name");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookAlbumCoverPhoto"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="FacebookAlbumCoverPhoto"/>.</returns>
        public static FacebookAlbumCoverPhoto Parse(JObject obj) {
            return obj == null ? null : new FacebookAlbumCoverPhoto(obj);
        }

        #endregion

    }

}