using Skybrud.Social.Facebook.Objects.Debug;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Debug {

    /// <summary>
    /// Class representing a response for getting information about a given access token.
    /// </summary>
    public class FacebookGetDebugTokenResponse : FacebookResponse<FacebookDebugToken> {

        #region Constructors

        private FacebookGetDebugTokenResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookDebugToken.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetDebugTokenResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetDebugTokenResponse"/> representing the response.</returns>
        public static FacebookGetDebugTokenResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetDebugTokenResponse(response);
        }

        #endregion

    }

}