using Skybrud.Social.Facebook.Objects.Albums;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Albums {

    public class FacebookAlbumsResponse : FacebookResponse<FacebookAlbumsCollection> {

        #region Constructors

        private FacebookAlbumsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookAlbumsCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookAlbumsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookAlbumsResponse(response);
        }

        #endregion

    }

}