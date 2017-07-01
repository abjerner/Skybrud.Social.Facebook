using Skybrud.Social.Facebook.Models.Posts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Posts {

    /// <summary>
    /// Class representing the options for creating a Facebook post.
    /// </summary>
    public class FacebookCreatePostResponse : FacebookResponse<FacebookCreatePostSummary> {

        #region Constructors

        private FacebookCreatePostResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookCreatePostSummary.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookCreatePostResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookCreatePostResponse"/> representing the response.</returns>
        public static FacebookCreatePostResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookCreatePostResponse(response);
        }

        #endregion

    }

}