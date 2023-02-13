using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Pages {

    public class FacebookPageRestaurantServices : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets whether the restaurant is kids-friendly.
        /// </summary>
        public bool Kids { get; }

        /// <summary>
        /// Gets whether the restaurant has delivery service.
        /// </summary>
        public bool Delivery { get; }

        /// <summary>
        /// Gets whether the restaurant welcomes walkins.
        /// </summary>
        public bool Walkins { get; }

        /// <summary>
        /// Gets whether the restaurant has catering service.
        /// </summary>
        public bool Catering { get; }

        /// <summary>
        /// Gets whether the restaurant takes reservations.
        /// </summary>
        public bool Reserve { get; }

        /// <summary>
        /// Gets whether the restaurant is group-friendly.
        /// </summary>
        public bool Groups { get; }

        /// <summary>
        /// Gets whether the restaurant has waiters.
        /// </summary>
        public bool Waiter { get; }

        /// <summary>
        /// Gets whether the restaurant has outdoor seating.
        /// </summary>
        public bool Outdoor { get; }

        /// <summary>
        /// Gets whether the restaurant has takeout service.
        /// </summary>
        public bool Takeout { get; }

        #endregion

        #region Constructor

        private FacebookPageRestaurantServices(JObject obj) : base(obj) {
            Kids = obj.GetBoolean("kids");
            Delivery = obj.GetBoolean("delivery");
            Walkins = obj.GetBoolean("walkins");
            Catering = obj.GetBoolean("catering");
            Reserve = obj.GetBoolean("reserve");
            Groups = obj.GetBoolean("groups");
            Waiter = obj.GetBoolean("waiter");
            Outdoor = obj.GetBoolean("outdoor");
            Takeout = obj.GetBoolean("takeout");
        }

        #endregion

        #region Static methods

        public static FacebookPageRestaurantServices Parse(JObject obj) {
            return obj == null ? null : new FacebookPageRestaurantServices(obj);
        }

        #endregion

    }

}