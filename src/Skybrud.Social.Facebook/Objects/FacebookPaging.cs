using System;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects {
    
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
        public int? Since {
            get {
                if (Previous != null) {
                    NameValueCollection response = SocialUtils.ParseQueryString(Previous);
                    if (response["since"] != null) return Int32.Parse(response["since"]);
                }
                return null;
            }
        }

        /// <summary>
        /// The timestamp used for the <see cref="Next"/> link.
        /// </summary>
        public int? Until {
            get {
                if (Next != null) {
                    NameValueCollection response = SocialUtils.ParseQueryString(Next);
                    if (response["until"] != null) return Int32.Parse(response["until"]);
                }
                return null;
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
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookPaging"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="FacebookPaging"/>.</returns>
        public static FacebookPaging Parse(JObject obj) {
            return obj == null ? null : new FacebookPaging(obj);
        }

        #endregion

    }

}