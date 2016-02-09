using Skybrud.Social.Facebook.Objects.Events;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Events {

    /// <summary>
    /// Class representing a response for getting a list of events.
    /// </summary>
    public class FacebookGetEventsResponse : FacebookResponse<FacebookEventsCollection> {

        #region Constructors

        private FacebookGetEventsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookEventsCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetEventsResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetEventsResponse"/> representing the response.</returns>
        public static FacebookGetEventsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetEventsResponse(response);
        }

        #endregion

    }

}