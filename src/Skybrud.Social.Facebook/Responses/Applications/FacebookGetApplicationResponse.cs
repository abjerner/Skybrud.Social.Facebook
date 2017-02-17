using Skybrud.Social.Facebook.Objects.Applications;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Applications {

    /// <summary>
    /// Class representing a response of a call to get information about a Facebook application.
    /// </summary>
    public class FacebookGetApplicationResponse : FacebookResponse<FacebookApplication> {

        #region Constructors

        private FacebookGetApplicationResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookApplication.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetApplicationResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetApplicationResponse"/> representing the response.</returns>
        public static FacebookGetApplicationResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetApplicationResponse(response);
        }

        #endregion

    }

}