using Skybrud.Social.Facebook.Objects.Events;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Events {

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

        public static FacebookGetEventResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetEventResponse(response);
        }

        #endregion

    }

}