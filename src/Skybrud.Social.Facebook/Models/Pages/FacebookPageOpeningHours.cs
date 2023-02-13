using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Pages {

    public class FacebookPageOpeningHours : FacebookObject {

        #region Properties

        public FacebookPageOpeningRange[] Monday { get; }
        public FacebookPageOpeningRange[] Tuesday { get; }
        public FacebookPageOpeningRange[] Wednesday { get; }
        public FacebookPageOpeningRange[] Thursday { get; }
        public FacebookPageOpeningRange[] Friday { get; }
        public FacebookPageOpeningRange[] Saturday { get; }
        public FacebookPageOpeningRange[] Sunday { get; }

        #endregion

        #region Constructor

        private FacebookPageOpeningHours(JObject obj) : base(obj) {

            var items = (
                from property in obj.Properties()
                let pieces = property.Name.Split('_')
                select new {
                    Day = pieces[0],
                    Number = Int32.Parse(pieces[1]),
                    Status = pieces[2],
                    Value = obj.GetString(property.Name)
                }
            ).ToArray();

            List<FacebookPageOpeningRange> monday = new List<FacebookPageOpeningRange>();
            List<FacebookPageOpeningRange> tuesday = new List<FacebookPageOpeningRange>();
            List<FacebookPageOpeningRange> wednesday = new List<FacebookPageOpeningRange>();
            List<FacebookPageOpeningRange> thursday = new List<FacebookPageOpeningRange>();
            List<FacebookPageOpeningRange> friday = new List<FacebookPageOpeningRange>();
            List<FacebookPageOpeningRange> saturday = new List<FacebookPageOpeningRange>();
            List<FacebookPageOpeningRange> sunday = new List<FacebookPageOpeningRange>();

            for (int i = 0; i < items.Length; i++) {
                if (items[i].Status != "open") continue;
                FacebookPageOpeningRange range = new FacebookPageOpeningRange {
                    Number = items[i].Number,
                    Open = items[i].Value,
                    Close = items[i + 1].Value
                };
                switch (items[i].Day) {
                    case "mon": monday.Add(range); break;
                    case "tue": tuesday.Add(range); break;
                    case "wed": wednesday.Add(range); break;
                    case "thu": thursday.Add(range); break;
                    case "fri": friday.Add(range); break;
                    case "sat": saturday.Add(range); break;
                    case "sun": sunday.Add(range); break;
                }
            }

            Monday = monday.ToArray();
            Tuesday = tuesday.ToArray();
            Wednesday = wednesday.ToArray();
            Thursday = thursday.ToArray();
            Friday = friday.ToArray();
            Saturday = saturday.ToArray();
            Sunday = sunday.ToArray();

        }

        #endregion

        #region Static methods

        public static FacebookPageOpeningHours Parse(JObject obj) {
            return obj == null ? null : new FacebookPageOpeningHours(obj);
        }

        #endregion

    }

}