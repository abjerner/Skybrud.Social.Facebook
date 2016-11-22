using Newtonsoft.Json.Linq;
using Skybrud.Social.Facebook.Objects.Pagination;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Events {

    public class FacebookEventsCollection : FacebookObject {

        #region Properties

        public FacebookEvent[] Data { get; private set; }

        public FacebookCursorBasedPagination Paging { get; private set; }

        #endregion

        #region Constructors

        private FacebookEventsCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookEvent.Parse);
            Paging = obj.GetObject("paging", FacebookCursorBasedPagination.Parse);
        }

        #endregion

        #region Static methods

        public static FacebookEventsCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookEventsCollection(obj);
        }

        #endregion

    }

}