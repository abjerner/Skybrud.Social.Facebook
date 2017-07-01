using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Enums.Albums;
using Skybrud.Social.Facebook.Models.Common;
using Skybrud.Social.Facebook.Models.Events;
using Skybrud.Social.Facebook.Models.Places;

namespace Skybrud.Social.Facebook.Models.Albums {
    
    /// <summary>
    /// Class representing an album as returned by the Facebook Graph API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/album</cref>
    /// </see>
    public class FacebookAlbum : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the album.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets whether the authenticated user or page can upload photos to this album.
        /// </summary>
        public bool CanUpload { get; private set; }
        
        /// <summary>
        /// Gets whether the <see cref="CanUpload"/> property was included in the response.
        /// </summary>
        public bool HasCanUpload {
            get { return HasJsonProperty("can_upload"); }
        }

        /// <summary>
        /// Ghe approximate number of photos in the album. This is not necessarily an exact count.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Count"/> property was included in the response.
        /// </summary>
        public bool HasCount {
            get { return HasJsonProperty("count"); }
        }

        /// <summary>
        /// Gets a summary of the album's cover photo.
        /// </summary>
        public FacebookAlbumCoverPhoto CoverPhoto { get; private set; }

        /// <summary>
        /// Gets whether the the album has a cover photo and whether it was included in the response.
        /// </summary>
        public bool HasCoverPhoto {
            get { return CoverPhoto != null; }
        }

        /// <summary>
        /// Gets the time the album was initially created.
        /// </summary>
        public EssentialsDateTime CreatedTime { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="CreatedTime"/> property was included in the response.
        /// </summary>
        public bool HasCreatedTime {
            get { return CreatedTime != null; }
        }

        /// <summary>
        /// Gets the description of the album.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets whether the description of the album has been specified and was included in the response.
        /// </summary>
        public bool HasDescription {
            get { return !String.IsNullOrWhiteSpace(Description); }
        }

        /// <summary>
        /// Gets a reference to the event associated with this album.
        /// </summary>
        public FacebookEvent Event { get; private set; }

        /// <summary>
        /// Gets whether the album has been associated with an event and whether the property was included in the
        /// response.
        /// </summary>
        public bool HasEvent {
            get { return Event != null; }
        }
        
        /// <summary>
        /// Gets the profile that created the album.
        /// </summary>
        public FacebookFrom From { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="From"/> property was included in the response.
        /// </summary>
        public bool HasFrom {
            get { return From != null; }
        }

        /// <summary>
        /// Gets the link to this album on Facebook.
        /// </summary>
        public string Link { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Link"/> property was included in the response.
        /// </summary>
        public bool HasLink {
            get { return !String.IsNullOrWhiteSpace(Link); }
        }

        /// <summary>
        /// Gets the textual location of the album.
        /// </summary>
        public string Location { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Location"/> property of the the album has been specified and was included in
        /// the response.
        /// </summary>
        public bool HasLocation {
            get { return !String.IsNullOrWhiteSpace(Location); }
        }

        /// <summary>
        /// Gets the title of the album.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Name"/> property was included in the response.
        /// </summary>
        public bool HasName {
            get { return !String.IsNullOrWhiteSpace(Name); }
        }

        /// <summary>
        /// Gets a reference to the place associated with this album.
        /// </summary>
        public FacebookPlace Place { get; private set; }

        /// <summary>
        /// Gets whether the album has been associated with a place and whether the property was included in the
        /// response.
        /// </summary>
        public bool HasPlace {
            get { return Place != null; }
        }

        /// <summary>
        /// Gets the privacy settings for the album.
        /// </summary>
        public string Privacy { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Privacy"/> property was included in the response.
        /// </summary>
        public bool HasPrivacy {
            get { return !String.IsNullOrWhiteSpace(Privacy); }
        }

        /// <summary>
        /// Gets the type of the album.
        /// </summary>
        public FacebookAlbumType Type { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Type"/> property was included in the response.
        /// </summary>
        public bool HasType {
            get { return Type != FacebookAlbumType.Unspecified; }
        }

        /// <summary>
        /// Gets the last time the album was updated.
        /// </summary>
        public EssentialsDateTime UpdatedTime { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="UpdatedTime"/> property was included in the response.
        /// </summary>
        public bool HasUpdatedTime {
            get { return UpdatedTime != null; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private FacebookAlbum(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            CanUpload = obj.GetBoolean("can_upload");
            Count = obj.GetInt32("count");
            CoverPhoto = obj.GetObject("cover_photo", FacebookAlbumCoverPhoto.Parse);
            CreatedTime = obj.GetString("created_time", EssentialsDateTime.Parse);
            Description = obj.GetString("description");
            Event = obj.GetObject("event", FacebookEvent.Parse);
            From = obj.GetObject("from", FacebookFrom.Parse);
            Link = obj.GetString("link");
            Location = obj.GetString("location");
            Name = obj.GetString("name");
            Place = obj.GetObject("place", FacebookPlace.Parse);
            Privacy = obj.GetString("privacy");
            Type = obj.GetEnum("type", FacebookAlbumType.Unspecified);
            UpdatedTime = obj.GetString("updated_time", EssentialsDateTime.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookAlbum"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookAlbum"/>.</returns>
        public static FacebookAlbum Parse(JObject obj) {
            return obj == null ? null : new FacebookAlbum(obj);
        }

        #endregion

    }

}