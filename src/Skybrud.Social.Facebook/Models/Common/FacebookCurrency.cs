using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Facebook.Models.Common {

    /// <summary>
    /// Class with information about a currency.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/currency/#Reading</cref>
    /// </see>
    public class FacebookCurrency : FacebookObject {

        #region Properties

        /// <summary>
        /// Will return a number that describes the number of additional decimal places to include when displaying the
        /// person's currency. For example, the API will return <c>100</c> because <strong>USD</strong> is
        /// usually displayed with two decimal places. <strong>JPY</strong> does not use decimal places, so the API
        /// will return <c>1</c>.
        /// </summary>
        public int CurrencyOffset { get; }

        /// <summary>
        /// Gets the exchange rate between the person's preferred currency and US Dollars.
        /// </summary>
        public float UsdExchange { get; }

        /// <summary>
        /// Gets the inverse of <see cref="UsdExchange"/>.
        /// </summary>
        public float UsdExchangeInverse { get; }

        /// <summary>
        /// Gets the <strong>ISO-4217-3</strong> code for the person's preferred currency (defaulting to
        /// <strong>USD</strong> if the person hasn't set one).
        /// </summary>
        public string UserCurrency { get; }

        #endregion

        #region Constructors

        private FacebookCurrency(JObject obj) : base(obj) {
            CurrencyOffset = obj.GetInt32("currency_offset");
            UsdExchange = obj.GetFloat("usd_exchange");
            UsdExchangeInverse = obj.GetFloat("usd_exchange_inverse");
            UserCurrency = obj.GetString("user_currency");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookCurrency"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookCurrency"/>.</returns>
        public static FacebookCurrency Parse(JObject obj) {
            return obj == null ? null : new FacebookCurrency(obj);
        }

        #endregion

    }

}