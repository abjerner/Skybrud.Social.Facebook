using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Apps {
    
    public class FacebookApp : FacebookObject {

        #region Properties

        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Category { get; private set; }
        public string SubCategory { get; private set; }
        public string Link { get; private set; }
        public string Namespace { get; private set; }
        public string IconUrl { get; private set; }
        public string LogoUrl { get; private set; }
        public int? DailyActiveUsers { get; private set; }
        public int? WeeklyActiveUsers { get; private set; }
        public int? MonthlyActiveUsers { get; private set; }
        public int? DailyActiveUserRank { get; private set; }
        public int? MontlyActiveUserRank { get; private set; }

        #endregion

        #region Constructors

        private FacebookApp(JObject obj) : base(obj) {
            Id = obj.GetInt64("id");
            Name = obj.GetString("name");
            Description = obj.GetString("description");
            Category = obj.GetString("category");
            SubCategory = obj.GetString("subcategory");
            Link = obj.GetString("link");
            Namespace = obj.GetString("namespace");
            IconUrl = obj.GetString("icon_url");
            LogoUrl = obj.GetString("logo_url");
            DailyActiveUsers = obj.HasValue("weekly_active_users") ? (int?) obj.GetInt32("weekly_active_users") : null;
            WeeklyActiveUsers = obj.HasValue("weekly_active_users") ? (int?) obj.GetInt32("weekly_active_users") : null;
            MonthlyActiveUsers = obj.HasValue("monthly_active_users") ? (int?) obj.GetInt32("monthly_active_users") : null;
            DailyActiveUserRank = obj.HasValue("daily_active_users_rank") ? (int?) obj.GetInt32("daily_active_users_rank") : null;
            MontlyActiveUserRank = obj.HasValue("monthly_active_users_rank") ? (int?) obj.GetInt32("monthly_active_users_rank") : null;
        }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookApp"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="FacebookApp"/>.</returns>
        public static FacebookApp Parse(JObject obj) {
            return obj == null ? null : new FacebookApp(obj);
        }

        #endregion

    }

}