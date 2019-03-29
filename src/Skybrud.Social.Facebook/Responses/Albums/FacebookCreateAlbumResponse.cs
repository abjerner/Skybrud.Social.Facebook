using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Albums;

namespace Skybrud.Social.Facebook.Responses.Albums {

    /// <summary>
    /// Class representing a response of a request to create a new <see cref="FacebookAlbum"/>.
    /// </summary>
    public class FacebookCreateAlbumResponse : FacebookResponse<FacebookCreateAlbumSummary> {

        #region Constructors

        private FacebookCreateAlbumResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookCreateAlbumSummary.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookCreateAlbumResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookCreateAlbumResponse"/> representing the response.</returns>
        public static FacebookCreateAlbumResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new FacebookCreateAlbumResponse(response);
        }

        #endregion

    }

}