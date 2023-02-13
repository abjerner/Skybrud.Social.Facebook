using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Pages;

namespace Skybrud.Social.Facebook.Responses.Pages {

    /// <summary>
    /// Class representing a response of a request to get information about a single <see cref="FacebookPage"/>.
    /// </summary>
    public class FacebookPageResponse : FacebookResponse<FacebookPage> {

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The raw response the instance should be based on.</param>
        public FacebookPageResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPage.Parse)!;

        }

    }

}