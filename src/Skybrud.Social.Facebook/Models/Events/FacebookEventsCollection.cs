using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Social.Facebook.Models.Pagination;

namespace Skybrud.Social.Facebook.Models.Events {

    /// <summary>
    /// Class representing a collection of events as returned by the Facebook Graph API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/event#read</cref>
    /// </see>
    public class FacebookEventsCollection : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets an array of the <see cref="FacebookEvent"/> returned in the response.
        /// </summary>
        public FacebookEvent[] Data { get; }

        /// <summary>
        /// Gets pagination information about the response.
        /// </summary>
        public FacebookCursorBasedPagination Paging { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        private FacebookEventsCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookEvent.Parse);
            Paging = obj.GetObject("paging", FacebookCursorBasedPagination.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookEventsCollection"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookEventsCollection"/>.</returns>
        public static FacebookEventsCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookEventsCollection(obj);
        }

        #endregion

    }

}