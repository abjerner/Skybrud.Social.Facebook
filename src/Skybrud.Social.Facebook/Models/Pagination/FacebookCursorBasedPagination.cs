using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Pagination {

    public class FacebookCursorBasedPagination : FacebookObject {

        #region Properties

        public FacebookCursors Cursors { get; private set; }

        public string Previous { get; private set; }

        public string Next { get; private set; }

        #endregion

        #region Constructor

        private FacebookCursorBasedPagination(JObject obj) : base(obj) {
            Cursors = obj.GetObject("cursors", FacebookCursors.Parse);
            Previous = obj.GetString("previous");
            Next = obj.GetString("next");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookCursorBasedPagination"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookCursorBasedPagination"/>.</returns>
        public static FacebookCursorBasedPagination Parse(JObject obj) {
            return obj == null ? null : new FacebookCursorBasedPagination(obj);
        }

        #endregion

    }

}