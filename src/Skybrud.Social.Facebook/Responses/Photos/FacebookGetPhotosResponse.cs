using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Photos;

namespace Skybrud.Social.Facebook.Responses.Photos {

    /// <summary>
    /// Class representing a response of for getting a collection of <see cref="FacebookPhoto"/>.
    /// </summary>
    public class FacebookGetPhotosResponse : FacebookResponse<FacebookPhotosCollection> {

        #region Constructors

        private FacebookGetPhotosResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPhotosCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookGetPhotosResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetPhotosResponse"/> representing the response.</returns>
        public static FacebookGetPhotosResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new FacebookGetPhotosResponse(response);
        }

        #endregion

    }

}