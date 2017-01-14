using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Common;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Facebook.Objects.Places;

namespace Skybrud.Social.Facebook.Objects.Photos {
    
    public class FacebookPhoto : FacebookObject {

        #region Properties

        public string Id { get; private set; }
        public FacebookEntity From { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public string Icon { get; private set; }
        public string Link { get; private set; }
        public string Picture { get; private set; }
        public string Source { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }
        public FacebookImage[] Images { get; private set; }

        /// <summary>
        /// Gets the place the photo was taken. It is possible to upload photos to Facebook without
        /// specifying a place, and in such cases the property will be <code>null</code>.
        /// </summary>
        public FacebookPlace Place { get; private set; }

        #endregion

        #region Constructors

        private FacebookPhoto(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            From = obj.GetObject("from", FacebookEntity.Parse);
            Width = obj.GetInt32("width");
            Height = obj.GetInt32("height");
            Icon = obj.GetString("icon");
            Link = obj.GetString("link");
            Picture = obj.GetString("picture");
            Source = obj.GetString("source");
            Place = obj.GetObject("place", FacebookPlace.Parse);
            Created = obj.GetDateTime("created_time");
            Updated = obj.GetDateTime("updated_time");
            Images = obj.GetArray("images", FacebookImage.Parse);
        }

        #endregion

        #region Member methods

        public FacebookImage GetImageGreaterThanOrEqualTo(int width, int height) {
            return Images.Reverse().FirstOrDefault(x => x.Width >= width && x.Height != height);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookPhoto"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="FacebookPhoto"/>.</returns>
        public static FacebookPhoto Parse(JObject obj) {
            return obj == null ? null : new FacebookPhoto(obj);
        }

        #endregion

    }

}