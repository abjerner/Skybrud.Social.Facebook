using Skybrud.Social.Facebook.Objects.Users;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Users {

    public class FacebookUserResponse : FacebookResponse<FacebookUser> {

        #region Constructors

        private FacebookUserResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookUser.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookUserResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookUserResponse(response);
        }

        #endregion

    }

}