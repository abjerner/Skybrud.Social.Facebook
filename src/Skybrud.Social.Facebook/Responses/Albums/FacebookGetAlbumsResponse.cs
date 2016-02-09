using Skybrud.Social.Facebook.Objects.Albums;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Albums {

    /// <summary>
    /// Class representing a response for a collection of Facebook albums.
    /// </summary>
    public class FacebookGetAlbumsResponse : FacebookResponse<FacebookAlbumsCollection> {

        #region Constructors

        private FacebookGetAlbumsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookAlbumsCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetAlbumsResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetAlbumsResponse"/> representing the response.</returns>
        public static FacebookGetAlbumsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetAlbumsResponse(response);
        }

        #endregion

    }

}