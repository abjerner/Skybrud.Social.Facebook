using System.Net;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Http;
using Skybrud.Social.Facebook.Exceptions;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Responses {

    /// <summary>
    /// Class representing a response from the Facebook Graph API.
    /// </summary>
    public class FacebookResponse : HttpResponseBase {

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        protected FacebookResponse(IHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Validates the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        public static void ValidateResponse(IHttpResponse response) {

            // Skip error checking if the server responds with an OK status code
            if (response.StatusCode == HttpStatusCode.OK) return;

            // Parse the response body
            JObject obj = ParseJsonObject(response.Body);

            // Throw an exception based on the error message from the API
            JObject error = obj.GetObject("error");
            int code = error.GetInt32("code");
            string type = error.GetString("type");
            string message = error.GetString("message");
            int subcode = error.GetInt32("error_subcode");
            throw new FacebookException(response, code, type, message, subcode);

        }

        #endregion

    }

    /// <summary>
    /// Class representing a response from the Facebook Graph API.
    /// </summary>
    public class FacebookResponse<T> : FacebookResponse {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="response"/>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the raw response.</param>
        protected FacebookResponse(IHttpResponse response) : base(response) { }

        #endregion

    }

}