using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;
using Skybrud.Social.Facebook.Models.Common;
using Skybrud.Social.Facebook.Options.Common;

namespace Skybrud.Social.Facebook.Options.Albums {
    
    /// <summary>
    /// Class representing the options for creating a Facebook album.
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
    public class FacebookCreateAlbumOptions : IHttpPostOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID or alias) of the user or page.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets whether the request will create an application specific album. Default is <c>false</c>.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets the text location of the album for non-page.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the album's caption. This appears below the title of the album in the album view.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The name given to the album. This field is required.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ID of a location page to tag the album with.
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// Privacy settings for the album. If not supplied, this defaults to the privacy level granted to the app in
        /// the Login Dialog. This field cannot be used to set a more open privacy setting than the one granted.
        /// </summary>
        public FacebookPrivacyOptions Privacy { get; set; }
        
        #endregion

        #region Member methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public IHttpQueryString GetQueryString() {
            return new HttpQueryString();
        }

        /// <summary>
        /// Gets an instance of <see cref="IHttpPostData"/> representing the POST parameters.
        /// </summary>
        public IHttpPostData GetPostData() {
            IHttpPostData postData = new HttpPostData();
            if (IsDefault) postData.Add("is_default", "true");
            if (string.IsNullOrWhiteSpace(Location) == false) postData.Add("location", Location);
            if (string.IsNullOrWhiteSpace(Message) == false) postData.Add("message", Message);
            if (string.IsNullOrWhiteSpace(Name) == false) postData.Add("name", Name);
            if (string.IsNullOrWhiteSpace(Place) == false) postData.Add("place", Place);
            if (Privacy != null && Privacy.Value != FacebookPrivacy.Default) postData.Add("privacy", Privacy.ToString());
            return postData;
        }

        #endregion

    }

}