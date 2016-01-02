using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects.Pages {
    
    public class FacebookOpeningHours : FacebookObject {

        #region Properties

        public FacebookOpeningRange[] Monday { get; private set; }
        public FacebookOpeningRange[] Tuesday { get; private set; }
        public FacebookOpeningRange[] Wednesday { get; private set; }
        public FacebookOpeningRange[] Thursday { get; private set; }
        public FacebookOpeningRange[] Friday { get; private set; }
        public FacebookOpeningRange[] Saturday { get; private set; }
        public FacebookOpeningRange[] Sunday { get; private set; }

        #endregion

        #region Constructor

        private FacebookOpeningHours(JObject obj) : base(obj) {

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

            List<FacebookOpeningRange> monday = new List<FacebookOpeningRange>();
            List<FacebookOpeningRange> tuesday = new List<FacebookOpeningRange>();
            List<FacebookOpeningRange> wednesday = new List<FacebookOpeningRange>();
            List<FacebookOpeningRange> thursday = new List<FacebookOpeningRange>();
            List<FacebookOpeningRange> friday = new List<FacebookOpeningRange>();
            List<FacebookOpeningRange> saturday = new List<FacebookOpeningRange>();
            List<FacebookOpeningRange> sunday = new List<FacebookOpeningRange>();

            for (int i = 0; i < items.Length; i++) {
                if (items[i].Status != "open") continue;
                FacebookOpeningRange range = new FacebookOpeningRange {
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

        public static FacebookOpeningHours Parse(JObject obj) {
            return obj == null ? null : new FacebookOpeningHours(obj);
        }

        #endregion

    }

}