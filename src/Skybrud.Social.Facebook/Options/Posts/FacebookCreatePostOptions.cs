using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Http;
using Skybrud.Essentials.Http.Collections;
using Skybrud.Essentials.Http.Options;
using Skybrud.Social.Facebook.Fields;

namespace Skybrud.Social.Facebook.Options.Posts {

    /// <summary>
    /// Class representing the options for publishing a new post to the feed of a page, user or similar.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page/feed#publish</cref>
    /// </see>
    public class FacebookCreatePostOptions : IHttpRequestOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the identifier (ID or alias) of the page, user or similar.
        /// </summary>
#if NET7_0_OR_GREATER
        public required string Identifier { get; set; }
#else
        public string? Identifier { get; set; }
#endif

        /// <summary>
        /// Gets or sets the main body of the post, otherwise called the status message. Either <see cref="Link"/> or
        /// <see cref="Message"/> must be supplied. The message can contain mentions of Facebook Pages using the
        /// following syntax: <c>@[page-id]</c>
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Gets or sets the URL of a link to attach to the post. Either <see cref="Link"/> or <see cref="Message"/>
        /// must be supplied.
        /// </summary>
        public string? Link { get; set; }

        /// <summary>
        /// Gets or sets the preview image associated with the link.
        /// </summary>
        public string? Picture { get; set; }

        /// <summary>
        /// Gets or sets the title of the link preview.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the caption under the title in the link preview.
        /// </summary>
        public string? Caption { get; set; }

        /// <summary>
        /// Gets or sets the description in the link preview.
        /// </summary>
        public string? Description { get; set; }

        // TODO: Add support for the "actions" parameter

        /// <summary>
        /// Gets or sets the page ID of a location associated with this post.
        /// </summary>
        public string? Place { get; set; }

        /// <summary>
        /// Gets or sets an array of user IDs of people tagged in this post. You cannot specify this field without also
        /// specifying a <see cref="Place"/>.
        /// </summary>
        public List<string> Tags { get; set; } = new();

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

        /// <summary>
        /// Gets or sets the fields to be returned.
        /// </summary>
        public FacebookFieldList Fields { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public FacebookCreatePostOptions() {
            Fields = new FacebookFieldList();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the page.</param>
#if NET7_0_OR_GREATER
        [SetsRequiredMembers]
#endif
        public FacebookCreatePostOptions(string identifier) : this() {
            Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="identifier"/> and <paramref name="fields"/>.
        /// </summary>
        /// <param name="identifier">The identifier (ID or alias) of the page.</param>
        /// <param name="fields">A collection of the fields that should be returned by the API.</param>
#if NET7_0_OR_GREATER
        [SetsRequiredMembers]
#endif
        public FacebookCreatePostOptions(string identifier, FacebookFieldList? fields) {
            Identifier = identifier;
            Fields = fields ?? new FacebookFieldList();
        }

        #endregion

        #region Member methods

        /// <inheritdoc />
        public IHttpRequest GetRequest() {

            // Validate required properties
            if (string.IsNullOrWhiteSpace(Identifier)) throw new PropertyNotSetException(nameof(Identifier));

            // Initialize the POST data
            IHttpPostData postData = new HttpPostData();
            if (!string.IsNullOrWhiteSpace(Message)) postData.Add("message", Message!);
            if (!string.IsNullOrWhiteSpace(Link)) postData.Add("link", Link!);
            if (!string.IsNullOrWhiteSpace(Picture)) postData.Add("picture", Picture!);
            if (!string.IsNullOrWhiteSpace(Name)) postData.Add("name", Name!);
            if (!string.IsNullOrWhiteSpace(Caption)) postData.Add("caption", Caption!);
            if (!string.IsNullOrWhiteSpace(Description)) postData.Add("description", Description!);
            if (!string.IsNullOrWhiteSpace(Place)) postData.Add("place", Place!);
            if (Tags is {Count: > 0}) postData.Add("tags", string.Join(",", Tags));

            // Initialize a new GET request
            return HttpRequest.Post($"/{Identifier}/feed", postData);

        }

        #endregion

    }

}