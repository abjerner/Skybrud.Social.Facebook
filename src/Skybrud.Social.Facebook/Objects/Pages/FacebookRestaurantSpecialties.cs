using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Pages {
    
    public class FacebookRestaurantSpecialties : FacebookObject {

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

        private FacebookRestaurantSpecialties(JObject obj) : base(obj) {
            Coffee = obj.GetBoolean("coffee");
            Drinks = obj.GetBoolean("drinks");
            Breakfast = obj.GetBoolean("breakfast");
            Dinner = obj.GetBoolean("dinner");
            Lunch = obj.GetBoolean("lunch");
        }

        #endregion

        #region Static methods

        public static FacebookRestaurantSpecialties Parse(JObject obj) {
            return obj == null ? null : new FacebookRestaurantSpecialties(obj);
        }

        #endregion

    }

}