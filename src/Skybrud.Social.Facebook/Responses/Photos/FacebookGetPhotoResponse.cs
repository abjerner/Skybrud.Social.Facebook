using Skybrud.Social.Facebook.Objects.Photos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Photos {

    /// <summary>
    /// Class representing a response of a call to get information about a single Facebook photo.
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
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetPhotoResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetPhotoResponse"/> representing the response.</returns>
        public static FacebookGetPhotoResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetPhotoResponse(response);
        }

        #endregion

    }

}