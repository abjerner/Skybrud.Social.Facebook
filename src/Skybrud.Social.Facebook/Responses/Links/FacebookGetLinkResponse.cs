using Skybrud.Social.Facebook.Objects.Links;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Links {

    /// <summary>
    /// Class representing a response of a request to get information about a single <see cref="FacebookLink"/>.
    /// </summary>
    public class FacebookGetLinkResponse : FacebookResponse<FacebookLink> {

        #region Constructors

        private FacebookGetLinkResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookLink.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookGetLinkResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetLinkResponse"/> representing the response.</returns>
        public static FacebookGetLinkResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetLinkResponse(response);
        }

        #endregion

    }

}