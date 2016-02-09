using Skybrud.Social.Facebook.Objects.Albums;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Albums {

    /// <summary>
    /// Class representing a response for a single Facebook album.
    /// </summary>
    public class FacebookGetAlbumResponse : FacebookResponse<FacebookAlbum> {

        #region Constructors

        private FacebookGetAlbumResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookAlbum.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetAlbumResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetAlbumResponse"/> representing the response.</returns>
        public static FacebookGetAlbumResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetAlbumResponse(response);
        }

        #endregion

    }

}