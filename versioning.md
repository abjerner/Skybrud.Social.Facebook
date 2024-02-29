---
order: 1
---

# Versioning

Facebook has multiple versions of their Graph API, and what version can use will ultimately come down to when you registered your app with Facebook. Your app is automatically configured to use the most recent version of the API at the time your app is created. So at the time writing this page, my app created years ago can still use `v2.0` of the Graph API, whereas a new app created will be forced to use `v2.4`.

![See what version your app is configured to use](https://cloud.githubusercontent.com/assets/3634580/9276935/442456de-42a7-11e5-93db-9f1a1f2abd61.png)

You should also notice that if the version of the API that your app is configured to use at some point no longer is supported, your app will be bumped to use the lowest supported version of the API instead. Eg. my app in the screenshot above was originally created when `v1.0` was the newest version, but since it is no longer supported, my app has been bumped to use `v2.0` instead.



## Explicit version

You can't change the configured version your self, but if you can explicitly tell the Graph API what version you want to use. When making calls directly to the API, you should then call `/v2.4/me` instead of just `/me`.

Facebook only allows you to use newer versions than what your app is configured to use by default, but you can't use older versions of the Graph API. So if your app is configured to use `v2.4`, and you make a call to `/v2.3/me/`, `v2.4` will still be used.

In Skybrud.Social, you can explicitly specify the API version to be used like in the example below (where `service` is an instance of `FacebookService`):

```csharp
service.Client.Version = "v2.9";
```

For more information, it is recommend to see Facebook's own documentation about [versioning](https://developers.facebook.com/docs/apps/versions/#versioning). Here you can see the latest version of their Graph API, the dates for when support for specific versions will end etc.