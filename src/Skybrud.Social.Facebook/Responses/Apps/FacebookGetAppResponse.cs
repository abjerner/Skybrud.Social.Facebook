using Skybrud.Social.Facebook.Objects.Apps;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Apps {

    /// <summary>
    /// Class representing a response of a call to get information about a Facebook app.
    /// </summary>
    public class FacebookGetAppResponse : FacebookResponse<FacebookApp> {

        #region Constructors

        private FacebookGetAppResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookApp.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetAppResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetAppResponse"/> representing the response.</returns>
        public static FacebookGetAppResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetAppResponse(response);
        }

        #endregion

    }

}