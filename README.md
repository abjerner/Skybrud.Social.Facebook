# Facebook

Facebook exposes a Graph API that lets developers access data in the Facebook ecosystem. To protect the privacy of their users, not all data accessible via Facebook.com will be accessible via the Graph API - eg. getting the friends list of a user.

Most methods in the Graph API require an access token. Access tokens are what identifies you as a user, or if you access the API on behalf of your application. If you don't already have an access token, the page about [authentication](./authentication.md) will help you out.

The Graph API has [multiple versions](./versioning.md). What version of the API that you're using may affect how you should use Skybrud.Social - eg. co control which [fields](./fields.md) that are returned by the API.

Although it can be a bit comprehensive, I can also recommend reading at least parts of the [Graph API documentation](https://developers.facebook.com/docs).

It's also worth mentioning that the Facebook examples  throughout this site are based on the `Skybrud.Social.Facebook` package. Most of the implementation is the same for the older `Skybrud.Social` package, but there are some differences.



## Installation

{{installation}}



## Structure

While the Facebook API has a somewhat flat URL structure, the implementation in Skybrud.Social is divided into an endpoint for each type of data. You can see a list of these endpoints below:

{{endpoints}}



## Raw communication

Similar to the other services supported in Skybrud.Social, there is a `FacebookOAuthClient` class for handling the authentication as well as the raw communication with the API. If you already have a valid access token, you can get your posts similar to this:

```csharp
// Initialize an instance of FacebookOAuthClient from a specified access token
FacebookOAuthClient client = new FacebookOAuthClient(accessToken);

// Get posts for "me"
IHttpResponse response = client.Posts.GetPosts("me");

// Get the raw response body
string responseBody = response.Body;
```



## Object-oriented communication

Since you're probably not interested in working with the raw JSON, the `FacebookService` class builds on top of `FacebookOAuthClient` to give an object-oriented approach so you don't have to worry about parsing. The `FacebookService` class can be used similar to this:

```csharp
// Initialize an instance of FacebookService from a specified access token
FacebookService service = FacebookService.CreateFromAccessToken(accessToken);

// Get posts for "me"
FacebookPostsResponse response = service.Posts.GetPosts("me");

// Iterate through the posts
foreach (FacebookPost post in response.Body.Data) {

    // Do something with the post  

}
```