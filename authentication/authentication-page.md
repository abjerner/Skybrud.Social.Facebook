---
order: 3
---

# Setting up an authentication page

In the **Skybrud.Social.Facebook** package, the <code type="Skybrud.Social.Facebook.OAuth.FacebookClient, Skybrud.Social.Facebook">FacebookClient</code> class is primarily responsible for the raw communication with the Facebook Graph API. It does however also contain relevant logic for handling authentication with the Graph API - eg. so you can set up your own authentication.

An authentication will allow your users to login with their Facebook API, which in return will give you a [user access token](./user-access-token.md) that you can use to access the Graph API on their behalf.

The examples below will show you how to set up an authentication - using a ASP.NET MVC view specifically. To get started, you need to initialize an instance of the <code type="Skybrud.Social.Facebook.OAuth.FacebookClient, Skybrud.Social.Facebook">FacebookClient</code> class with some information about your <a href="https://developers.facebook.com/apps/" target="_blank" rel="noopener">Facebook app</a>.

```csharp
// Initialize and configure the OAuth client
FacebookOAuthClient client = new FacebookOAuthClient {
    ClientId = "Insert your app/client ID here",
    ClientSecret = "Insert your app/client secret",
    RedirectUri = "http://social.abjerner/facebook/oauth/"
};
```



## Generating the authorization URL

Authentication starts by redirecting the user to a page at Facebook.com where the user will grant (or refuse) that your app can gain access to make API calls on their behalf. In OAuth terminology, the URL of this page is called the *authorization URL*. The client instance from the example above can help you generate this URL:

```csharp
// Generate the authorization URL (with default scope)
string authorizationUrl = client.GetAuthorizationUrl(state);
```

For this method, you must specify a state parameter, which is a random generated value that you will later need to approve the user once he/she is redirected back to your site. You can store the state in a session or similar. It is part of the OAuth 2.0 security to validate the user once Facebook redirects the user back to your authentication page.

When a user grants your app access to their Facebook account, you don't just have access to everything on their account. Like most OAuth-based API, Facebook uses scopes to determine what your app will have access to. A single scope can be described as permission to some kind of resource or property - eg. the `email` scope will let your app read the corresponding `email` property of the authenticated user.

By not passing any additional parameters to the <code method="Skybrud.Social.Facebook.OAuth.FacebookClient.GetAuthorizationUrl, Skybrud.Social.Facebook">FacebookClient.GetAuthorizationUrl</code> method, as shown in the example above, your app will not be granted any permissions, other than getting very basic information about the authenticated user - eg. their name.

If you need any additional scopes or permissions, you can request them during the authentication process:

```csharp
// Generate the authorization URL
string authorizationUrl = client.GetAuthorizationUrl(state, FacebookScopes.Email + FacebookScopes.PublishActions);
```

By specifying a second parameter - in this case with the added value of `FacebookScopes.Email` and `FacebookScopes.PublishActions` - you request the user to grant your app access to the `email` and `publish_actions` scopes. The user will be informed about this once redirected to the authorization page at Facebook.com.

It is however worth mentioning, that if a user has already granted your app access to the specified scopes, they will simply be redirected back to your authentication page.



## Obtaining an access token

The access token can be obtained using the <code method="Skybrud.Social.Facebook.OAuth.FacebookClient.GetAccessTokenFromAuthCode, Skybrud.Social.Facebook">FacebookClient.GetAccessTokenFromAuthCode</code> method, where the response body will expose the access token.

For the example below, the parameter for the method is the authorization code received when the user has successfully logged in through the Facebook authorization dialog, and been redirected back to your site. At this point, the `code` parameter in the query string will contain the authorization code.

The code for exchanging the authorization code for the access token will look like:

```csharp
// Exchange the authorization code for an access token
FacebookTokenResponse response = client.GetAccessTokenFromAuthCode(code);
        
// Get the access token from the response body
string accessToken = response.Body.AccessToken;
```

A user access token obtained this way will expire after 60 days, in which case the user will have to authenticate again to keep their access to the API.



## Initializing an instance of FacebookService

Once you have obtained an access token, you can initialize a new instance of the <code type="Skybrud.Social.Facebook.FacebookService, Skybrud.Social.Facebook">FacebookService</code> class as shown in the example below:

```csharp
// Initialize a new service instance from an access token
FacebookService service = FacebookService.CreateFromAccessToken("Insert your access token here");
```

The FacebookService class serves as your starting point to making calls to the Facebook Graph API.



## Complete example

In the example below, I've tried to demonstrate how an authentication page can be implemented (involving the steps explained above).

Notice that the example generates a `state` value that is saved to the user's session. When redirecting the user to Facebook's authorization page, we supply the state, and once the user confirms (or cancels) the authorization, the same state is specified in the URL the user is redirected back to (at your site). We can then check whether the state is saved in the user session to make sure it's still the same user making the request.

```cshtml
@using Skybrud.Social.Facebook
@using Skybrud.Social.Facebook.OAuth
@using Skybrud.Social.Facebook.Responses.Authentication
@using Skybrud.Social.Facebook.Scopes

@{

    // Initialize and configure the OAuth client
    FacebookOAuthClient client = new FacebookOAuthClient {
        ClientId = "Insert your app/client ID here",
        ClientSecret = "Insert your app/client secret",
        RedirectUri = "http://social.abjerner/facebook/oauth/"
    };

    if (Request.QueryString["do"] == "login") {

        // Generate a random scope
        string state = Guid.NewGuid().ToString();

        // Generate the session key for the state
        string stateKey = "FacebookOAuthState_" + state;

        // Store the state in the session of the user
        Session[stateKey] = Request.RawUrl;

        // Generate the authorization URL
        string authorizationUrl = client.GetAuthorizationUrl(state, FacebookScopes.Email + FacebookScopes.PublishActions);

        // Redirect the user
        Response.Redirect(authorizationUrl);

    } else if (Request.QueryString["code"] != null) {

        // Get the state from the query string
        string state = Request.QueryString["state"];

        // Get the code from the query string
        string code = Request.QueryString["code"];

        // Generate the session key for the state
        string stateKey = "FacebookOAuthState_" + state;

        if (Session[stateKey] == null) {
            <p>Has your session expired?</p>
            <p>
                <a class="btn btn-default" href="@Url.Action("OAuth")?do=login">Re-try login</a>
            </p>
            return;
        }

        // Exchange the authorization code for an access token
        FacebookTokenResponse response = client.GetAccessTokenFromAuthCode(code);

        // Initialize a new service instance from an access token
        FacebookService service = FacebookService.CreateFromAccessToken(response.Body.AccessToken);

        <div>Access Token:</div>
        <pre>@response.Body.AccessToken</pre>

        <div>Expires in:</div>
        <pre>@response.Body.ExpiresIn</pre>

        <div>Token type:</div>
        <pre>@response.Body.TokenType</pre>

        return;

    }

    <p>
        <a class="btn btn-default" href="@Url.Action("OAuth")?do=login">Login with Facebook</a>
    </p>

}
```