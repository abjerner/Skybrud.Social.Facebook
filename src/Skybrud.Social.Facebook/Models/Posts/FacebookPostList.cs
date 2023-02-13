using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Social.Facebook.Models.Common;
using Skybrud.Social.Facebook.Models.Pagination;

namespace Skybrud.Social.Facebook.Models.Posts {

    /// <summary>
    /// Class representing a collection of Facebook posts.
    /// </summary>
    public class FacebookPostList : FacebookObject, IFacebookList<FacebookPost> {

        #region Properties

        /// <summary>
        /// Gets an array of <see cref="FacebookPost"/> representing the posts.
        /// </summary>
        public IReadOnlyList<FacebookPost> Data { get; }

        /// <summary>
        /// Gets pagination information about the response.
        /// </summary>
        public FacebookCursorBasedPagination Paging { get; }

        #endregion

        #region Constructors

        private FacebookPostList(JObject obj) : base(obj) {
            Data = obj.GetArrayItems("data", FacebookPost.Parse);
            Paging = obj.GetObject("paging", FacebookCursorBasedPagination.Parse)!;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="FacebookPostList"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPostList"/>.</returns>
        [return: NotNullIfNotNull("json")]
        public static FacebookPostList? Parse(JObject? json) {
            return json == null ? null : new FacebookPostList(json);
        }

        #endregion

    }

}