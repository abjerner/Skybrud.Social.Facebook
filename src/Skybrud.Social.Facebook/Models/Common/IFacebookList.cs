using System.Collections.Generic;

namespace Skybrud.Social.Facebook.Models.Common {

    /// <summary>
    /// Interface describing a list of items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IFacebookList<out T> {

        /// <summary>
        /// Gets an array of the <typeparamref name="T"/> returned in the response.
        /// </summary>
        public abstract IReadOnlyCollection<T> Data { get; }

    }

}