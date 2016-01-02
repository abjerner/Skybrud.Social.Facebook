using Skybrud.Social.Facebook.Objects.Albums;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Albums {

    public class FacebookGetAlbumsResponse : FacebookResponse<FacebookAlbumsCollection> {

        #region Constructors

        private FacebookGetAlbumsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookAlbumsCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookGetAlbumsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetAlbumsResponse(response);
        }

        #endregion

    }

}