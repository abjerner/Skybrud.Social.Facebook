using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Posts;

namespace Skybrud.Social.Facebook.Responses.Posts {

    /// <summary>
    /// Class representing a response for getting a collection of <see cref="FacebookPost"/>.
    /// </summary>
    public class FacebookPostListResponse : FacebookResponse<FacebookPostList> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public FacebookPostListResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPostList.Parse);

        }

    }

}