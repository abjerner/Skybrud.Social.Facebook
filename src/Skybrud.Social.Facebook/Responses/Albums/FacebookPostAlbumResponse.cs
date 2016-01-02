using Skybrud.Social.Facebook.Objects.Albums;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Albums {

    public class FacebookPostAlbumResponse : FacebookResponse<FacebookPostAlbumSummary> {

        #region Constructors

        private FacebookPostAlbumResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPostAlbumSummary.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookPostAlbumResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookPostAlbumResponse(response);
        }

        #endregion

    }

}