using Skybrud.Social.Facebook.Objects.Photos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Photos {

    /// <summary>
    /// Class representing a response of a call to get a collection of Facebook photos.
    /// </summary>
    public class FacebookGetPhotosResponse : FacebookResponse<FacebookPhotosCollection> {

        #region Constructors

        private FacebookGetPhotosResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPhotosCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetPhotosResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetPhotosResponse"/> representing the response.</returns>
        public static FacebookGetPhotosResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetPhotosResponse(response);
        }

        #endregion

    }

}