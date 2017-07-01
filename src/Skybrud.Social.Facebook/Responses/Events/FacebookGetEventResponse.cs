using Skybrud.Social.Facebook.Models.Events;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Events {

    /// <summary>
    /// Class representing a response for a single <see cref="FacebookEvent"/>.
    /// </summary>
    public class FacebookGetEventResponse : FacebookResponse<FacebookEvent> {

        #region Constructors

        private FacebookGetEventResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookEvent.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookGetEventResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookGetEventResponse"/> representing the response.</returns>
        public static FacebookGetEventResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetEventResponse(response);
        }

        #endregion

    }

}