using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Models.Pages;

namespace Skybrud.Social.Facebook.Responses.Pages {

    /// <summary>
    /// Class representing a response of a request to get information about a single <see cref="FacebookPage"/>.
    /// </summary>
    public class FacebookGetPageResponse : FacebookResponse<FacebookPage> {

        #region Constructors

        private FacebookGetPageResponse(IHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPage.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookGetPageResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetPageResponse"/> representing the response.</returns>
        public static FacebookGetPageResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new FacebookGetPageResponse(response);
        }

        #endregion

    }

}