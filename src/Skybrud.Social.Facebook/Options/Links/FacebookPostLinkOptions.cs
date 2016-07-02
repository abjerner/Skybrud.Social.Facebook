using System;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Facebook.Options.Links {

    public class FacebookPostLinkOptions : IHttpPostOptions {

        public string Link { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public IHttpQueryString GetQueryString() {
            return new SocialHttpQueryString();
        }

        /// <summary>
        /// Gets an instance of <see cref="IHttpPostData"/> representing the POST parameters.
        /// </summary>
        public IHttpPostData GetPostData() {
            SocialHttpPostData postData = new SocialHttpPostData();
            if (!String.IsNullOrWhiteSpace(Link)) postData.Add("link", Link);
            if (!String.IsNullOrWhiteSpace(Description)) postData.Add("description", Description);
            if (!String.IsNullOrWhiteSpace(Message)) postData.Add("message", Message);
            if (!String.IsNullOrWhiteSpace(Name)) postData.Add("name", Name);
            if (!String.IsNullOrWhiteSpace(Caption)) postData.Add("caption", Caption);
            return postData;
        }
    
    }

}