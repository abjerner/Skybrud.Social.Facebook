using Skybrud.Social.Facebook.Models.Albums;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Albums {

    /// <summary>
    /// Class representing a response for getting information about a single <see cref="FacebookAlbum"/>.
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
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookGetAlbumResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetAlbumResponse"/> representing the response.</returns>
        public static FacebookGetAlbumResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetAlbumResponse(response);
        }

        #endregion

    }

}