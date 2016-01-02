using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Pagination {
    
    public class FacebookCursors : FacebookObject {

        #region Properties

        public string After { get; private set; }

        public string Before { get; private set; }

        #endregion

        #region Constructor

        public FacebookCursors(JObject obj) : base(obj) {
            After = obj.GetString("after");
            Before = obj.GetString("before");
        }

        #endregion

        #region Static methods

        public static FacebookCursors Parse(JObject obj) {
            return obj == null ? null : new FacebookCursors(obj);
        }

        #endregion

    }

}