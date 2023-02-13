using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Posts;

namespace Skybrud.Social.Facebook.Responses.Feed {

    /// <summary>
    /// Class representing a response of a request to get a collection of <see cref="FacebookPost"/> of a Facebook
    /// feed.
    /// </summary>
    public class FacebookGetFeedResponse : FacebookResponse<FacebookPostList> {

        #region Constructors

        private FacebookGetFeedResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPostList.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookGetFeedResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetFeedResponse"/> representing the response.</returns>
        public static FacebookGetFeedResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new FacebookGetFeedResponse(response);
        }

        #endregion

    }

}