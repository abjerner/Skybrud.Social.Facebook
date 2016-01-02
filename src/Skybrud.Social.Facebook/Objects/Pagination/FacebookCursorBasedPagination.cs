using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Pagination {

    public class FacebookCursorBasedPagination : FacebookObject {

        #region Properties

        public FacebookCursors Cursors { get; private set; }

        public string Previous { get; private set; }

        public string Next { get; private set; }

        #endregion

        #region Constructor

        public FacebookCursorBasedPagination(JObject obj) : base(obj) {
            Cursors = obj.GetObject("cursors", FacebookCursors.Parse);
            Previous = obj.GetString("previous");
            Next = obj.GetString("next");
        }

        #endregion

        #region Static methods

        public static FacebookCursorBasedPagination Parse(JObject obj) {
            return obj == null ? null : new FacebookCursorBasedPagination(obj);
        }

        #endregion

    }

}