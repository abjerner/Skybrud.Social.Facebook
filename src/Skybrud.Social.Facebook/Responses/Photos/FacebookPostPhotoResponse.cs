using Skybrud.Social.Facebook.Objects.Photos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Photos {

    /// <summary>
    /// Class representing a response of a call to post a photo.
    /// </summary>
    public class FacebookPostPhotoResponse : FacebookResponse<FacebookPostPhotoSummary> {

        #region Constructors

        private FacebookPostPhotoResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPostPhotoSummary.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookPostPhotoResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookPostPhotoResponse"/> representing the response.</returns>
        public static FacebookPostPhotoResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookPostPhotoResponse(response);
        }

        #endregion

    }

}