using System;
using Skybrud.Social.Facebook.OAuth;
using Skybrud.Social.Facebook.Options.Photos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw implementation of the photos endpoint.
    /// </summary>
    public class FacebookPhotosRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference of the OAuth client.
        /// </summary>
        public FacebookOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal FacebookPhotosRawEndpoint(FacebookOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Methods
        
        /// <summary>
        /// Gets information about the photo with the specified <code>photoId</code>.
        /// </summary>
        /// <param name="photoId">The ID of the photo.</param>
        public SocialHttpResponse GetPhoto(string photoId) {
            return Client.DoHttpGetRequest("/" + photoId);
        }

        /// <summary>
        /// Gets information about the photo matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public SocialHttpResponse GetPhoto(FacebookGetPhotoOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("/" + options.Identifier, options);
        }

        /// <summary>
        /// Gets a list of photos of the album, user or page matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public SocialHttpResponse GetPhotos(FacebookGetPhotosOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("/" + options.Identifier + "/photos", options);
        }

        /// <summary>
        /// Posts a new photo to the feed of the user matching the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public SocialHttpResponse PostPhoto(FacebookPostUserPhotoOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpPostRequest("/" + options.Identifier + "/photos", options);
        }

        #endregion

    }

}