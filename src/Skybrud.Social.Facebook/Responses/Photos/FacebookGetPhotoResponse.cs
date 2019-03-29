using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Photos;

namespace Skybrud.Social.Facebook.Responses.Photos {

    /// <summary>
    /// Class representing a response of a request to get information about a single <see cref="FacebookPhoto"/>.
    /// </summary>
    public class FacebookGetPhotoResponse : FacebookResponse<FacebookPhoto> {

        #region Constructors

        private FacebookGetPhotoResponse(IHttpResponse response) : base(response) {

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
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotoResponse"/> representing the response.</returns>
        public static FacebookGetPhotoResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new FacebookGetPhotoResponse(response);
        }

        #endregion

    }

}