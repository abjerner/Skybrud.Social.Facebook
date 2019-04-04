using System;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;

namespace Skybrud.Social.Facebook.Options.Posts {
    
    /// <summary>
    /// Class representing the options for publishing a new post to the feed of a page, user or similar.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page/feed#publish</cref>
    /// </see>
    public class FacebookCreatePostOptions : IHttpPostOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID or alias) of the page, user or similar.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the main body of the post, otherwise called the status message. Either <see cref="Link"/> or
        /// <see cref="Message"/> must be supplied. The message can contain mentions of Facebook Pages using the
        /// following syntax: <c>@[page-id]</c>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the URL of a link to attach to the post. Either <see cref="Link"/> or <see cref="Message"/>
        /// must be supplied.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the preview image associated with the link.
        /// </summary>
        public string Picture { get; set; }
        
        /// <summary>
        /// Gets or sets the title of the link preview.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the caption under the title in the link preview.
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// Gets or sets the description in the link preview.
        /// </summary>
        public string Description { get; set; }

        // TODO: Add support for the "actions" parameter

        /// <summary>
        /// Gets or sets the page ID of a location associated with this post.
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// Gets or sets an array of user IDs of people tagged in this post. You cannot specify this field without also
        /// specifying a <see cref="Place"/>.
        /// </summary>
        public string[] Tags { get; set; }

        // TODO: Add support for the "object_attachment" parameter

        // TODO: Add support for the "targeting" parameter

        // TODO: Add support for the "feed_targeting" parameter

        // TODO: Add support for the "published" parameter

        // TODO: Add support for the "scheduled_publish_time" parameter

        // TODO: Add support for the "backdated_time" parameter

        // TODO: Add support for the "backdated_time_granularity" parameter

        // TODO: Add support for the "child_attachments" parameter

        // TODO: Add support for the "multi_share_optimized" parameter

        // TODO: Add support for the "multi_share_end_card" parameter

        #endregion

        #region Member methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public IHttpQueryString GetQueryString() {
            return new HttpQueryString();
        }

        /// <summary>
        /// Gets an instance of <see cref="IHttpPostData"/> representing the POST parameters.
        /// </summary>
        public IHttpPostData GetPostData() {
            IHttpPostData postData = new HttpPostData();
            if (!String.IsNullOrWhiteSpace(Message)) postData.Add("message", Message);
            if (!String.IsNullOrWhiteSpace(Link)) postData.Add("link", Link);
            if (!String.IsNullOrWhiteSpace(Picture)) postData.Add("picture", Picture);
            if (!String.IsNullOrWhiteSpace(Name)) postData.Add("name", Name);
            if (!String.IsNullOrWhiteSpace(Caption)) postData.Add("caption", Caption);
            if (!String.IsNullOrWhiteSpace(Description)) postData.Add("description", Description);
            if (!String.IsNullOrWhiteSpace(Place)) postData.Add("place", Place);
            if (Tags != null && Tags.Length > 0) postData.Add("tags", String.Join(",", Tags));
            return postData;
        }

        #endregion

    }

}