using Skybrud.Social.Facebook.Objects.Photos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Photos {

    public class FacebookPhotosResponse : FacebookResponse<FacebookPhotosCollection> {

        #region Constructors

        private FacebookPhotosResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPhotosCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookPhotosResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookPhotosResponse(response);
        }

        #endregion

    }

}