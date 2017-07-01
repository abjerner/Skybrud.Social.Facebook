using Skybrud.Social.Facebook.Models.Photos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Photos {

    /// <summary>
    /// Class representing a response of a request to get information about a single <see cref="FacebookPhoto"/>.
    /// </summary>
    public class FacebookGetPhotoResponse : FacebookResponse<FacebookPhoto> {

        #region Constructors

        private FacebookGetPhotoResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPhoto.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookGetPhotoResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotoResponse"/> representing the response.</returns>
        public static FacebookGetPhotoResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetPhotoResponse(response);
        }

        #endregion

    }

}