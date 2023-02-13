using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Pages;

namespace Skybrud.Social.Facebook.Responses.Pages {

    /// <summary>
    /// Class representing a response for a collection of <see cref="FacebookPage"/>.
    /// </summary>
    public class FacebookPageListResponse : FacebookResponse<FacebookPageList> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public FacebookPageListResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPageList.Parse)!;

        }

    }

}