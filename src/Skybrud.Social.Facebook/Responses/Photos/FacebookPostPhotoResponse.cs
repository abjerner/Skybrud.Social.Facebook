using Skybrud.Social.Facebook.Objects.Photos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Photos {

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

        public static FacebookPostPhotoResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookPostPhotoResponse(response);
        }

        #endregion

    }

}