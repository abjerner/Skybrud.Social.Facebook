using Skybrud.Social.Facebook.Objects.Albums;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Albums {

    public class FacebookAlbumResponse : FacebookResponse<FacebookAlbum> {

        #region Constructors

        private FacebookAlbumResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookAlbum.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookAlbumResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookAlbumResponse(response);
        }

        #endregion

    }

}