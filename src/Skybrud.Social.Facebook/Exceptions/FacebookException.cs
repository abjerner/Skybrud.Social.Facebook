using System;
using Skybrud.Essentials.Http;

namespace Skybrud.Social.Facebook.Exceptions {

    /// <summary>
    /// Class representing an exception based on an error from the Facebook Graph API.
    /// </summary>
    public class FacebookException : Exception {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <see cref="IHttpResponse"/>.
        /// </summary>
        public IHttpResponse Response { get; private set; }

        /// <summary>
        /// Gets the error code received from the Facebook API.
        /// </summary>
        public int Code { get; private set; }

        /// <summary>
        /// Gets the type of the error received from the Facebook API.
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// Gets the sub error code received from the Facebook API. If a sub error code isn't specified in the
        /// response, <code>0</code> will be returned.
        /// </summary>
        public int Subcode { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new exception based on the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The instance of <see cref="IHttpResponse"/> representing the response.</param>
        /// <param name="code">The error code.</param>
        /// <param name="type">The error type.</param>
        /// <param name="message">The error message.</param>
        /// <param name="subcode">The error subcode.</param>
        public FacebookException(IHttpResponse response, int code, string type, string message, int subcode = 0) : base(message) {
            Response = response;
            Code = code;
            Type = type;
            Subcode = subcode;
        }

        #endregion

    }

}