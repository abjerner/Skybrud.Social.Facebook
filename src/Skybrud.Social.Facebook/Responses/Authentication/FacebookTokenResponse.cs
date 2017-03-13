using Skybrud.Social.Facebook.Objects.Authentication;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Responses.Authentication {

    /// <summary>
    /// Class representing a response with information about an access token.
    /// </summary>
    public class FacebookTokenResponse : FacebookResponse<FacebookToken> {

        #region Properties

        /// <summary>
        /// Gets the value of the <code>X-FB-Trace-ID</code> header.
        /// </summary>
        public string FacebookTraceId { get; private set; }
        
        /// <summary>
        /// Gets the value of the <code>X-FB-Rev</code> header.
        /// </summary>
        public string FacebookRevision { get; private set; }
        
        /// <summary>
        /// Gets the value of the <code>Facebook-API-Version</code> header.
        /// </summary>
        public string FacebookApiVersion { get; private set; }
        
        /// <summary>
        /// Gets the value of the <code>X-FB-Stats-Contexts</code> header.
        /// </summary>
        public string FacebookStatsContext { get; private set; }
        
        /// <summary>
        /// Gets the value of the <code>X-FB-Debug</code> header.
        /// </summary>
        public string FacebookDebug { get; private set; }

        #endregion

        #region Constructors

        private FacebookTokenResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse headers from the response
            FacebookTraceId = response.Headers["X-FB-Trace-ID"];
            FacebookRevision = response.Headers["X-FB-Rev"];
            FacebookApiVersion = response.Headers["Facebook-API-Version"];
            FacebookStatsContext = response.Headers["X-FB-Stats-Contexts"];
            FacebookDebug = response.Headers["X-FB-Debug"];

            // Parse the response body
            Body = FacebookToken.Parse(response.Body);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="FacebookTokenResponse"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="SocialHttpResponse"/> representing the raw response.</param>
        /// <returns>An instance of <see cref="FacebookTokenResponse"/> representing the response.</returns>
        public static FacebookTokenResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new FacebookTokenResponse(response);
        }

        #endregion

    }

}