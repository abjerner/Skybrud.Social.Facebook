using Skybrud.Social.Facebook.Objects.Comments;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Comments {

    /// <summary>
    /// Class representing a response of a call to get a collection of comments of a given Facebook object.
    /// </summary>
    public class FacebookGetCommentsResponse : FacebookResponse<FacebookCommentsCollection> {

        #region Constructors

        private FacebookGetCommentsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookCommentsCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetCommentsResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetCommentsResponse"/> representing the response.</returns>
        public static FacebookGetCommentsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetCommentsResponse(response);
        }

        #endregion

    }

}