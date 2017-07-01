using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Pagination {
    
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

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookCursors"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookCursors"/>.</returns>
        public static FacebookCursors Parse(JObject obj) {
            return obj == null ? null : new FacebookCursors(obj);
        }

        #endregion

    }

}