using Skybrud.Social.Facebook.Objects.Links;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Links {

    /// <summary>
    /// Class representing a response of a call to post a link.
    /// </summary>
    public class FacebookPostLinkResponse : FacebookResponse<FacebookPostLinkSummary> {

        #region Constructors

        private FacebookPostLinkResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookPostLinkSummary.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookPostLinkResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookPostLinkResponse"/> representing the response.</returns>
        public static FacebookPostLinkResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookPostLinkResponse(response);
        }

        #endregion

    }

}