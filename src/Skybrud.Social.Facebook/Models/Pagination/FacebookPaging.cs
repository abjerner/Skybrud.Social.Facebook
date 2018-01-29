using System;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Http;

namespace Skybrud.Social.Facebook.Models.Pagination {
    
    public class FacebookPaging : FacebookObject {

        #region Properties

        /// <summary>
        /// A link to the previous page.
        /// </summary>
        public string Previous { get; private set; }

        /// <summary>
        /// A link to the next page.
        /// </summary>
        public string Next { get; private set; }

        /// <summary>
        /// The timestamp used for the <see cref="Previous"/> link.
        /// </summary>
        public int Since {
            get {
                if (Previous != null) {
                    SocialHttpQueryString response = SocialHttpQueryString.ParseQueryString(Previous);
                    if (response["since"] != null) return Int32.Parse(response["since"]);
                }
                return 0;
            }
        }

        /// <summary>
        /// The timestamp used for the <see cref="Next"/> link.
        /// </summary>
        public int Until {
            get {
                if (Next != null) {
                    SocialHttpQueryString response = SocialHttpQueryString.ParseQueryString(Next);
                    if (response["until"] != null) return Int32.Parse(response["until"]);
                }
                return 0;
            }
        }

        #endregion

        #region Constructors

        private FacebookPaging(JObject obj) : base(obj) {
            Previous = obj.GetString("previous");
            Next = obj.GetString("next");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookPaging"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPaging"/>.</returns>
        public static FacebookPaging Parse(JObject obj) {
            return obj == null ? null : new FacebookPaging(obj);
        }

        #endregion

    }

}