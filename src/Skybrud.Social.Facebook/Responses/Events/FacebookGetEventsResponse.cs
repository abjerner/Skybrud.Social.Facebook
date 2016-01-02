using Skybrud.Social.Facebook.Objects.Events;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Events {

    /// <summary>
    /// Class representing the response for getting a list of events.
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
        /// Parses the specified <code>response</code> into an instance of <code>FacebookGetEventsResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <code>FacebookGetEventsResponse</code> representing the response.</returns>
        public static FacebookGetEventsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetEventsResponse(response);
        }

        #endregion

    }

}