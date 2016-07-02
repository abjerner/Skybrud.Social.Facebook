using System;
using Skybrud.Social.Facebook.Enums;
using Skybrud.Social.Facebook.Options.Common;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Facebook.Options.Albums {
    
    public class FacebookPostAlbumOptions : IHttpPostOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID or alias) of the user or page.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// The name given to the album. This field is required.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description of the album, which will show up in news feed stories as the status message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Privacy settings for the album. If not supplied, this defaults to the privacy level granted to the app in
        /// the Login Dialog. This field cannot be used to set a more open privacy setting than the one granted. This
        /// property only applies when creating a user album, and should therefore not be specified for page albums.
        /// </summary>
        public FacebookPrivacyOptions Privacy { get; set; }
        
        #endregion

        #region Member methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public IHttpQueryString GetQueryString() {
            return new SocialHttpQueryString();
        }

        /// <summary>
        /// Gets an instance of <see cref="IHttpPostData"/> representing the POST parameters.
        /// </summary>
        public IHttpPostData GetPostData() {
            SocialHttpPostData postData = new SocialHttpPostData();
            if (!String.IsNullOrWhiteSpace(Name)) postData.Add("name", Name);
            if (!String.IsNullOrWhiteSpace(Message)) postData.Add("message", Message);
            if (Privacy != null && Privacy.Value != FacebookPrivacy.Default) postData.Add("privacy", Privacy.ToString());
            return postData;
        }

        #endregion

    }

}