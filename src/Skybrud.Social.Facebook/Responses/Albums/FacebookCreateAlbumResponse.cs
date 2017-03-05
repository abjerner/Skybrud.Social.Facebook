using Skybrud.Social.Facebook.Objects.Albums;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Albums {

    /// <summary>
    /// Class representing a response of a call to post (create) a new Facebook album.
    /// </summary>
    public class FacebookCreateAlbumResponse : FacebookResponse<FacebookCreateAlbumSummary> {

        #region Constructors

        private FacebookCreateAlbumResponse(SocialHttpResponse response) : base(response) {

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
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookCreateAlbumResponse"/> representing the response.</returns>
        public static FacebookCreateAlbumResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookCreateAlbumResponse(response);
        }

        #endregion

    }

}