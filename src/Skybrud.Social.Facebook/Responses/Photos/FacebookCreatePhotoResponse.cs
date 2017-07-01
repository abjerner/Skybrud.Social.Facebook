using Skybrud.Social.Facebook.Models.Photos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Photos {

    /// <summary>
    /// Class representing a response of a request to create a photo.
    /// </summary>
    public class FacebookCreatePhotoResponse : FacebookResponse<FacebookCreatePhotoSummary> {

        #region Constructors

        private FacebookCreatePhotoResponse(SocialHttpResponse response) : base(response) {

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
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookCreatePhotoResponse"/> representing the response.</returns>
        public static FacebookCreatePhotoResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookCreatePhotoResponse(response);
        }

        #endregion

    }

}