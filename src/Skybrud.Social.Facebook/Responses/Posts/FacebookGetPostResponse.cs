using Skybrud.Social.Facebook.Objects.Posts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Posts {

    /// <summary>
    /// Class representing a response of a request to get information about a single <see cref="FacebookPost"/>.
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

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookGetPostResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetPostResponse"/> representing the response.</returns>
        public static FacebookGetPostResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetPostResponse(response);
        }

        #endregion

    }

}