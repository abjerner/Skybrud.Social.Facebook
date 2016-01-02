using Skybrud.Social.Facebook.Objects.Users;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Users {

    public class FacebookGetUserResponse : FacebookResponse<FacebookUser> {

        #region Constructors

        private FacebookGetUserResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookUser.Parse);

        }

        #endregion

        #region Static methods

        public static FacebookGetUserResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetUserResponse(response);
        }

        #endregion

    }

}