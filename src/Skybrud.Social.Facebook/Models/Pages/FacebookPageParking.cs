using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Pages {

    public class FacebookPageParking : FacebookObject {

        #region Properties

        /// <summary>
        /// Indicates street parking is available.
        /// </summary>
        public bool Street { get; }

        /// <summary>
        /// Indicates a parking lot is available.
        /// </summary>
        public bool Lot { get; }

        /// <summary>
        /// Indicates a valet is available.
        /// </summary>
        public bool Valet { get; }

        #endregion

        #region Constructor

        private FacebookPageParking(JObject obj) : base(obj) {
            Street = obj.GetBoolean("street");
            Lot = obj.GetBoolean("lot");
            Valet = obj.GetBoolean("valet");
        }

        #endregion

        #region Static methods

        public static FacebookPageParking Parse(JObject obj) {
            return obj == null ? null : new FacebookPageParking(obj);
        }

        #endregion

    }

}