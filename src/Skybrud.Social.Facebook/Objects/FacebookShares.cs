using Newtonsoft.Json.Linq;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Facebook.Objects {

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
        /// Parses the specified <code>JObject</code> into an instance of <code>FacebookShares</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to be parsed.</param>
        public static FacebookShares Parse(JObject obj) {
            return obj == null ? null : new FacebookShares(obj);
        }

        #endregion

    }

}