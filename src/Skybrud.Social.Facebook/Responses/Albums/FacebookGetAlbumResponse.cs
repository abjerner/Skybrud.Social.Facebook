using Skybrud.Social.Facebook.Objects.Albums;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Albums {

    public class FacebookGetAlbumResponse : FacebookResponse<FacebookAlbum> {

        #region Constructors

        private FacebookGetAlbumResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookAlbum.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookGetAlbumResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetAlbumResponse(response);
        }

        #endregion

    }

}