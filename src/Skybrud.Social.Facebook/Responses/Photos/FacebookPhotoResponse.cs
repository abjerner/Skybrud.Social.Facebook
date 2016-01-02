using Skybrud.Social.Facebook.Objects.Photos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Photos {

    public class FacebookPhotoResponse : FacebookResponse<FacebookPhoto> {

        #region Constructors

        private FacebookPhotoResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPhoto.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookPhotoResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookPhotoResponse(response);
        }

        #endregion

    }

}