using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Photos;

namespace Skybrud.Social.Facebook.Responses.Photos {

    /// <summary>
    /// Class representing a response of a request to create a photo.
    /// </summary>
    public class FacebookCreatePhotoResponse : FacebookResponse<FacebookCreatePhotoSummary> {

        #region Constructors

        private FacebookCreatePhotoResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookCreatePhotoSummary.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookCreatePhotoResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookCreatePhotoResponse"/> representing the response.</returns>
        public static FacebookCreatePhotoResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new FacebookCreatePhotoResponse(response);
        }

        #endregion

    }

}