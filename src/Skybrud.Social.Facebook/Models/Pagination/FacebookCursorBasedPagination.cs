using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Pagination {

    /// <summary>
    /// Class with information about the pagination of a response with cursor based pagination.
    /// </summary>
    public class FacebookCursorBasedPagination : FacebookObject {

        #region Properties

        /// <summary>
        /// Get a reference to the cursors.
        /// </summary>
        public FacebookCursors Cursors { get; }

        public string? Previous { get; }

        public string? Next { get; }

        #endregion

        #region Constructor

        private FacebookCursorBasedPagination(JObject json) : base(json) {
            Cursors = json.GetObject("cursors", FacebookCursors.Parse)!;
            Previous = json.GetString("previous");
            Next = json.GetString("next");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="FacebookCursorBasedPagination"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookCursorBasedPagination"/>.</returns>
        [return: NotNullIfNotNull("json")]
        public static FacebookCursorBasedPagination? Parse(JObject? json) {
            return json == null ? null : new FacebookCursorBasedPagination(json);
        }

        #endregion

    }

}