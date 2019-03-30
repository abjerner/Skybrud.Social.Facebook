using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Facebook.Models.Pagination;

namespace Skybrud.Social.Facebook.Models.Posts {
    
    /// <summary>
    /// Class representing a collection of Facebook posts.
    /// </summary>
    public class FacebookPostsCollection : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets an array of <see cref="FacebookPost"/> representing the posts.
        /// </summary>
        public FacebookPost[] Data { get; }

        /// <summary>
        /// Gets pagination information about the response.
        /// </summary>
        public FacebookPaging Paging { get; }

        #endregion

        #region Constructors

        private FacebookPostsCollection(JObject obj) : base(obj) {
            Data = obj.GetArray("data", FacebookPost.Parse);
            Paging = obj.GetObject("paging", FacebookPaging.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookPostsCollection"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPostsCollection"/>.</returns>
        public static FacebookPostsCollection Parse(JObject obj) {
            return obj == null ? null : new FacebookPostsCollection(obj);
        }

        #endregion
    
    }

}