using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Pages {
    
    public class FacebookPageRestaurantSpecialties : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets whether the restaurant serves coffee.
        /// </summary>
        public bool Coffee { get; private set; }

        /// <summary>
        /// Gets whether the restaurant serves drinks.
        /// </summary>
        public bool Drinks { get; private set; }

        /// <summary>
        /// Gets whether the restaurant serves breakfast.
        /// </summary>
        public bool Breakfast { get; private set; }

        /// <summary>
        /// Gets whether the restaurant serves dinner.
        /// </summary>
        public bool Dinner { get; private set; }

        /// <summary>
        /// Gets whether the restaurant serves lunch.
        /// </summary>
        public bool Lunch { get; private set; }

        #endregion

        #region Constructor

        private FacebookPageRestaurantSpecialties(JObject obj) : base(obj) {
            Coffee = obj.GetBoolean("coffee");
            Drinks = obj.GetBoolean("drinks");
            Breakfast = obj.GetBoolean("breakfast");
            Dinner = obj.GetBoolean("dinner");
            Lunch = obj.GetBoolean("lunch");
        }

        #endregion

        #region Static methods

        public static FacebookPageRestaurantSpecialties Parse(JObject obj) {
            return obj == null ? null : new FacebookPageRestaurantSpecialties(obj);
        }

        #endregion

    }

}