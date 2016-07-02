using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Facebook.Objects.Common {

    /// <summary>
    /// Class with information on how many times a given object has been shared.
    /// </summary>
    public class FacebookShares : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the amount of shares the object has received.
        /// </summary>
        public int Count { get; private set; }

        #endregion

        #region Constructors

        private FacebookShares(JObject obj) : base(obj) {
            Count = obj.GetInt32("count");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="FacebookShares"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="FacebookShares"/>.</returns>
        public static FacebookShares Parse(JObject obj) {
            return obj == null ? null : new FacebookShares(obj);
        }

        #endregion

    }

}