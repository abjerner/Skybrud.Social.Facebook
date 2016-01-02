using Skybrud.Social.Facebook.Objects.Photos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Photos {

    /// <summary>
    /// Class representing the response of a call to get a collection of Facebook photos.
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

        public static FacebookGetPhotosResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetPhotosResponse(response);
        }

        #endregion

    }

}