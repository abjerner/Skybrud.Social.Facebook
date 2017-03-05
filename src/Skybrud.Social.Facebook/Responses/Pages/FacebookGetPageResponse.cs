using Skybrud.Social.Facebook.Objects.Pages;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Pages {

    /// <summary>
    /// Class representing a response of a request to get information about a single <see cref="FacebookPage"/>.
    /// </summary>
    public class FacebookGetPageResponse : FacebookResponse<FacebookPage> {

        #region Constructors

        private FacebookGetPageResponse(SocialHttpResponse response) : base(response) {

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
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetPageResponse"/> representing the response.</returns>
        public static FacebookGetPageResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetPageResponse(response);
        }

        #endregion

    }

}