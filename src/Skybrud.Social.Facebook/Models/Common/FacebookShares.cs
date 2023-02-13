﻿using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;

namespace Skybrud.Social.Facebook.Models.Common {

    /// <summary>
    /// Class with information on how many times a given object has been shared.
    /// </summary>
    public class FacebookShares : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the amount of shares the object has received.
        /// </summary>
        public int Count { get; }

        #endregion

        #region Constructors

        private FacebookShares(JObject obj) : base(obj) {
            Count = obj.GetInt32("count");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookShares"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookShares"/>.</returns>
        public static FacebookShares Parse(JObject obj) {
            return obj == null ? null : new FacebookShares(obj);
        }

        #endregion

    }

}