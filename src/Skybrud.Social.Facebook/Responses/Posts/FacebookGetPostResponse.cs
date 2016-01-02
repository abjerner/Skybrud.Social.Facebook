using Skybrud.Social.Facebook.Objects.Posts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Posts {

    /// <summary>
    /// Class representing the response of a call to get information about a single Facebook post.
    /// </summary>
    public class FacebookGetPostResponse : FacebookResponse<FacebookPost> {

        #region Constructors

        private FacebookGetPostResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPost.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookGetPostResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetPostResponse(response);
        }

        #endregion

    }

}