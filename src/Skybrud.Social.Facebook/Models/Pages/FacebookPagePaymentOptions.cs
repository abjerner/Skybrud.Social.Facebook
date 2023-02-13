using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Pages {

    public class FacebookPagePaymentOptions : FacebookObject {

        #region Properties

        /// <summary>
        /// Indicates American Express is accepted.
        /// </summary>
        public bool AmericanExpress { get; }

        /// <summary>
        /// Indicates cash is accepted.
        /// </summary>
        public bool CashOnly { get; }

        /// <summary>
        /// Indicates Discover accepted.
        /// </summary>
        public bool Discover { get; }

        /// <summary>
        /// Indicates MasterCard is accepted.
        /// </summary>
        public bool MasterCard { get; }

        /// <summary>
        /// Indicates Visa is accepted.
        /// </summary>
        public bool Visa { get; }

        #endregion

        #region Constructor

        private FacebookPagePaymentOptions(JObject obj) : base(obj) {
            AmericanExpress = obj.GetBoolean("amex");
            CashOnly = obj.GetBoolean("cash_only");
            Discover = obj.GetBoolean("discover");
            MasterCard = obj.GetBoolean("mastercard");
            Visa = obj.GetBoolean("visa");
        }

        #endregion

        #region Static methods

        public static FacebookPagePaymentOptions Parse(JObject obj) {
            return obj == null ? null : new FacebookPagePaymentOptions(obj);
        }

        #endregion

    }

}