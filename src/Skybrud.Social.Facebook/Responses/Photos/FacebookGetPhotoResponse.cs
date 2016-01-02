using Skybrud.Social.Facebook.Objects.Photos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Photos {

    /// <summary>
    /// Class representing the response of a call to get information about a single Facebook photo.
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

        public static FacebookGetPhotoResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetPhotoResponse(response);
        }

        #endregion

    }

}