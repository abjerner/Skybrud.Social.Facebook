using Skybrud.Social.Facebook.Objects.Links;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Links {

    /// <summary>
    /// Class representing a response of a call to get a collection of Facebook photos.
    /// </summary>
    public class FacebookGetLinksResponse : FacebookResponse<FacebookLinksCollection> {

        #region Constructors

        private FacebookGetLinksResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, FacebookLinksCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="FacebookGetLinksResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>Returns an instance of <see cref="FacebookGetLinksResponse"/> representing the response.</returns>
        public static FacebookGetLinksResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookGetLinksResponse(response);
        }

        #endregion

    }

}