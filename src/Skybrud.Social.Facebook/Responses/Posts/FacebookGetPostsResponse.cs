using Skybrud.Social.Facebook.Objects.Posts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Posts {

    /// <summary>
    /// Class representing the response of a call to get a collection of Facebook posts.
    /// </summary>
    public class FacebookGetPostsResponse : FacebookResponse<FacebookPostsCollection> {

        #region Constructors

        private FacebookGetPostsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPostsCollection.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookGetPostsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetPostsResponse(response);
        }

        #endregion

    }

}