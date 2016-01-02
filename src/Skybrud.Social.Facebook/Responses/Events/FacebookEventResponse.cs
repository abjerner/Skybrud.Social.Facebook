using Skybrud.Social.Facebook.Objects.Events;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Events {

    public class FacebookEventResponse : FacebookResponse<FacebookEvent> {

        #region Constructors

        private FacebookEventResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookEvent.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookEventResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookEventResponse(response);
        }

        #endregion

    }

}