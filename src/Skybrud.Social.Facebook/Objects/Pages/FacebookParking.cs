using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Pages {
    
    public class FacebookParking : FacebookObject {

        #region Properties

        /// <summary>
        /// Indicates street parking is available.
        /// </summary>
        public bool Street { get; private set; }

        /// <summary>
        /// Indicates a parking lot is available.
        /// </summary>
        public bool Lot { get; private set; }

        /// <summary>
        /// Indicates a valet is available.
        /// </summary>
        public bool Valet { get; private set; }

        #endregion

        #region Constructor

        private FacebookParking(JObject obj) : base(obj) {
            Street = obj.GetBoolean("street");
            Lot = obj.GetBoolean("lot");
            Valet = obj.GetBoolean("valet");
        }

        #endregion

        #region Static methods

        public static FacebookParking Parse(JObject obj) {
            return obj == null ? null : new FacebookParking(obj);
        }

        #endregion

    }

}