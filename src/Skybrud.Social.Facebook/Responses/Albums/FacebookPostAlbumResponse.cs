using Skybrud.Social.Facebook.Objects.Albums;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Albums {

    /// <summary>
    /// Class representing a response of a call to post (create) a new Facebook album.
    /// </summary>
    public class FacebookPostAlbumResponse : FacebookResponse<FacebookPostAlbumSummary> {

        #region Constructors

        private FacebookPostAlbumResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPostAlbumSummary.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookPostAlbumResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookPostAlbumResponse"/> representing the response.</returns>
        public static FacebookPostAlbumResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookPostAlbumResponse(response);
        }

        #endregion

    }

}