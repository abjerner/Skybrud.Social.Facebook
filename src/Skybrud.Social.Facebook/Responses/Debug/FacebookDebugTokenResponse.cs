using Skybrud.Social.Facebook.Models.Debug;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Debug {

    /// <summary>
    /// Class representing a response for getting information about a given access token.
    /// </summary>
    public class FacebookDebugTokenResponse : FacebookResponse<FacebookDebugToken> {

        #region Constructors

        private FacebookDebugTokenResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookDebugToken.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookDebugTokenResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookDebugTokenResponse"/> representing the response.</returns>
        public static FacebookDebugTokenResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookDebugTokenResponse(response);
        }

        #endregion

    }

}