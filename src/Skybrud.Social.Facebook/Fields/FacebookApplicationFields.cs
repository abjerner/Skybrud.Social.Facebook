using Skybrud.Social.Facebook.Models.Applications;

namespace Skybrud.Social.Facebook.Fields {

    /// <summary>
    ///  Static class with constants for the fields available for a Facebook application (<see cref="FacebookApplication" />).
    ///
    ///  The class is auto-generated and based on the fields listed in the Facebook Graph API documentation. Not all
    ///  fields may have been mapped for the implementation in Skybrud.Social.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.12/application</cref>
    /// </see>
    public static class FacebookApplicationFields {

        #region Individial fields

        /// <summary>
        /// The app ID.
        /// </summary>
        public static readonly FacebookField Id = new FacebookField("id");

        /// <summary>
        /// The maximum number ofAd Spaces allowed for each Audience Network supported platform.
        /// </summary>
        public static readonly FacebookField AnAdSpaceLimit = new FacebookField("an_ad_space_limit");

        /// <summary>
        /// The platforms associated with the app in the Audience Network product. Not enforced, but when present, it
        /// can be used to provide the user with platform specific information for the app and its placements.
        /// </summary>
        public static readonly FacebookField AnPlatforms = new FacebookField("an_platforms");

        /// <summary>
        /// App ad related information to help debugging.
        /// </summary>
        public static readonly FacebookField AppAdDebugInfo = new FacebookField("app_ad_debug_info");

        /// <summary>
        /// Domains and subdomains this app can use.
        /// </summary>
        public static readonly FacebookField AppDomains = new FacebookField("app_domains");

        /// <summary>
        /// Whether the app install is trackable or not.
        /// </summary>
        public static readonly FacebookField AppInstallTracked = new FacebookField("app_install_tracked");

        /// <summary>
        /// App name.
        /// </summary>
        public static readonly FacebookField AppName = new FacebookField("app_name");

        /// <summary>
        /// App type.
        /// </summary>
        public static readonly FacebookField AppType = new FacebookField("app_type");

        /// <summary>
        /// The URL of a special landing page that helps people who are using an app begin publishing Open Graph
        /// activity.
        /// </summary>
        public static readonly FacebookField AuthDialogDataHelpUrl = new FacebookField("auth_dialog_data_help_url");

        /// <summary>
        /// One line description of an app that appears in the Login Dialog.
        /// </summary>
        public static readonly FacebookField AuthDialogHeadline = new FacebookField("auth_dialog_headline");

        /// <summary>
        /// The text to explain why an app needs additional permissions.  This appears in the Login Dialog.
        /// </summary>
        public static readonly FacebookField AuthDialogPermsExplanation = new FacebookField("auth_dialog_perms_explanation");

        /// <summary>
        /// The default privacy setting selected for Open Graph activities in the Auth Dialog.
        /// </summary>
        public static readonly FacebookField AuthReferralDefaultActivityPrivacy = new FacebookField("auth_referral_default_activity_privacy");

        /// <summary>
        /// Indicates whether Authenticated Referrals are enabled.
        /// </summary>
        public static readonly FacebookField AuthReferralEnabled = new FacebookField("auth_referral_enabled");

        /// <summary>
        /// Extended permissions that a person can choose to grant when Authenticated Referrals are enabled.
        /// </summary>
        public static readonly FacebookField AuthReferralExtendedPerms = new FacebookField("auth_referral_extended_perms");

        /// <summary>
        /// Basic friends permissions that a user must grant when Authenticated Referrals are enabled.
        /// </summary>
        public static readonly FacebookField AuthReferralFriendPerms = new FacebookField("auth_referral_friend_perms");

        /// <summary>
        /// The format that an app receives for the authentication token from the Login Dialog.
        /// </summary>
        public static readonly FacebookField AuthReferralResponseType = new FacebookField("auth_referral_response_type");

        /// <summary>
        /// Basic user permissions that a user must grant when Authenticated Referrals are enabled.
        /// </summary>
        public static readonly FacebookField AuthReferralUserPerms = new FacebookField("auth_referral_user_perms");

        /// <summary>
        /// Business owner of this app.
        /// </summary>
        public static readonly FacebookField Business = new FacebookField("business");

        /// <summary>
        /// Indicates whether the app uses fluid or settable height values for Canvas.
        /// </summary>
        public static readonly FacebookField CanvasFluidHeight = new FacebookField("canvas_fluid_height");

        /// <summary>
        /// Indicates whether the app uses fluid or fixed width values for Canvas.
        /// </summary>
        public static readonly FacebookField CanvasFluidWidth = new FacebookField("canvas_fluid_width");

        /// <summary>
        /// The non-secure URL from which Canvas app content is loaded.
        /// </summary>
        public static readonly FacebookField CanvasUrl = new FacebookField("canvas_url");

        /// <summary>
        /// The category of the app.
        /// </summary>
        public static readonly FacebookField Category = new FacebookField("category");

        /// <summary>
        /// Config data for the client.
        /// </summary>
        public static readonly FacebookField ClientConfig = new FacebookField("client_config");

        /// <summary>
        /// The company the app belongs to.
        /// </summary>
        public static readonly FacebookField Company = new FacebookField("company");

        /// <summary>
        /// True if the app has configured Single Sign On on iOS.
        /// </summary>
        public static readonly FacebookField ConfiguredIosSso = new FacebookField("configured_ios_sso");

        /// <summary>
        /// Email address listed for people using the app to contact developers.
        /// </summary>
        public static readonly FacebookField ContactEmail = new FacebookField("contact_email");

        /// <summary>
        /// Social context for the app.
        /// </summary>
        public static readonly FacebookField Context = new FacebookField("context");

        /// <summary>
        /// Timestamp that indicates when the app was created.
        /// </summary>
        public static readonly FacebookField CreatedTime = new FacebookField("created_time");

        /// <summary>
        /// User ID of the creator of this app.
        /// </summary>
        public static readonly FacebookField CreatorUid = new FacebookField("creator_uid");

        /// <summary>
        /// The number of daily active users the app has.
        /// </summary>
        public static readonly FacebookField DailyActiveUsers = new FacebookField("daily_active_users");

        /// <summary>
        /// Ranking of this app vs other apps comparing daily active users.
        /// </summary>
        public static readonly FacebookField DailyActiveUsersRank = new FacebookField("daily_active_users_rank");

        /// <summary>
        /// URL that is pinged whenever a person removes the app.
        /// </summary>
        public static readonly FacebookField DeauthCallbackUrl = new FacebookField("deauth_callback_url");

        /// <summary>
        /// The platform that should be used to share content.
        /// </summary>
        public static readonly FacebookField DefaultShareMode = new FacebookField("default_share_mode");

        /// <summary>
        /// The description of the app, as provided by the developer.
        /// </summary>
        public static readonly FacebookField Description = new FacebookField("description");

        /// <summary>
        /// The ID for the corresponding audience network financial entity.
        /// </summary>
        public static readonly FacebookField FinancialId = new FacebookField("financial_id");

        /// <summary>
        /// Webspace created with one of our hosting partners for this app.
        /// </summary>
        public static readonly FacebookField HostingUrl = new FacebookField("hosting_url");

        /// <summary>
        /// The URL of this app's icon.
        /// </summary>
        public static readonly FacebookField IconUrl = new FacebookField("icon_url");

        /// <summary>
        /// Bundle ID of the associated iOS app.
        /// </summary>
        public static readonly FacebookField IosBundleId = new FacebookField("ios_bundle_id");

        /// <summary>
        /// Whether to support the native proxy login flow.
        /// </summary>
        public static readonly FacebookField IosSupportsNativeProxyAuthFlow = new FacebookField("ios_supports_native_proxy_auth_flow");

        /// <summary>
        /// Whether to support the iOS integrated Login Dialog.
        /// </summary>
        public static readonly FacebookField IosSupportsSystemAuth = new FacebookField("ios_supports_system_auth");

        /// <summary>
        /// ID of the app in the iPad App Store.
        /// </summary>
        public static readonly FacebookField IpadAppStoreId = new FacebookField("ipad_app_store_id");

        /// <summary>
        /// ID of the app in the iPhone App Store.
        /// </summary>
        public static readonly FacebookField IphoneAppStoreId = new FacebookField("iphone_app_store_id");

        /// <summary>
        /// Test if viewer is one of admins of this app.
        /// </summary>
        public static readonly FacebookField IsViewerAdmin = new FacebookField("is_viewer_admin");

        /// <summary>
        /// App latest sdk version.
        /// </summary>
        public static readonly FacebookField LatestSdkVersion = new FacebookField("latest_sdk_version");

        /// <summary>
        /// A link to the app on Facebook.
        /// </summary>
        public static readonly FacebookField Link = new FacebookField("link");

        /// <summary>
        /// To use for logging purposes.
        /// </summary>
        public static readonly FacebookField LoggingToken = new FacebookField("logging_token");

        /// <summary>
        /// The URL of the app's logo.
        /// </summary>
        public static readonly FacebookField LogoUrl = new FacebookField("logo_url");

        /// <summary>
        /// Status of migrations for this app.
        /// </summary>
        public static readonly FacebookField Migrations = new FacebookField("migrations");

        /// <summary>
        /// Mobile URL of the app section on a person's profile.
        /// </summary>
        public static readonly FacebookField MobileProfileSectionUrl = new FacebookField("mobile_profile_section_url");

        /// <summary>
        /// URL to which Mobile users will be directed when using the app.
        /// </summary>
        public static readonly FacebookField MobileWebUrl = new FacebookField("mobile_web_url");

        /// <summary>
        /// The number of monthly active users the app has.
        /// </summary>
        public static readonly FacebookField MonthlyActiveUsers = new FacebookField("monthly_active_users");

        /// <summary>
        /// Ranking of this app vs other apps comparing monthly active users.
        /// </summary>
        public static readonly FacebookField MonthlyActiveUsersRank = new FacebookField("monthly_active_users_rank");

        /// <summary>
        /// The name of the app.
        /// </summary>
        public static readonly FacebookField Name = new FacebookField("name");

        /// <summary>
        /// The string appended to <c>apps.facebook.com/</c> to navigate to the app's canvas page.
        /// </summary>
        public static readonly FacebookField Namespace = new FacebookField("namespace");

        /// <summary>
        /// Mobile store URLs for the app.
        /// </summary>
        public static readonly FacebookField ObjectStoreUrls = new FacebookField("object_store_urls");

        /// <summary>
        /// The title of the app when used in a Page Tab.
        /// </summary>
        public static readonly FacebookField PageTabDefaultName = new FacebookField("page_tab_default_name");

        /// <summary>
        /// The non-secure URL from which Page Tab app content is loaded.
        /// </summary>
        public static readonly FacebookField PageTabUrl = new FacebookField("page_tab_url");

        /// <summary>
        /// The URL of the app photo.
        /// </summary>
        public static readonly FacebookField PhotoUrl = new FacebookField("photo_url");

        /// <summary>
        /// The URL that links to a Privacy Policy for the app.
        /// </summary>
        public static readonly FacebookField PrivacyPolicyUrl = new FacebookField("privacy_policy_url");

        /// <summary>
        /// URL of the app section on a user's profile for the desktop site.
        /// </summary>
        public static readonly FacebookField ProfileSectionUrl = new FacebookField("profile_section_url");

        /// <summary>
        /// Demographic restrictions for the app.
        /// </summary>
        public static readonly FacebookField Restrictions = new FacebookField("restrictions");

        /// <summary>
        /// The secure URL from which Canvas app content is loaded.
        /// </summary>
        public static readonly FacebookField SecureCanvasUrl = new FacebookField("secure_canvas_url");

        /// <summary>
        /// The secure URL from which Page Tab app content is loaded.
        /// </summary>
        public static readonly FacebookField SecurePageTabUrl = new FacebookField("secure_page_tab_url");

        /// <summary>
        /// App requests must originate from this comma-separated list of IP addresses.
        /// </summary>
        public static readonly FacebookField ServerIpWhitelist = new FacebookField("server_ip_whitelist");

        /// <summary>
        /// Indicates whether app usage stories show up in the Ticker or News Feed.
        /// </summary>
        public static readonly FacebookField SocialDiscovery = new FacebookField("social_discovery");

        /// <summary>
        /// The subcategory the app can be found under.
        /// </summary>
        public static readonly FacebookField Subcategory = new FacebookField("subcategory");

        /// <summary>
        /// All the platform the app supports.
        /// </summary>
        public static readonly FacebookField SupportedPlatforms = new FacebookField("supported_platforms");

        /// <summary>
        /// URL to Terms of Service that appears in the Login Dialog.
        /// </summary>
        public static readonly FacebookField TermsOfServiceUrl = new FacebookField("terms_of_service_url");

        /// <summary>
        /// URL scheme suffix.
        /// </summary>
        public static readonly FacebookField UrlSchemeSuffix = new FacebookField("url_scheme_suffix");

        /// <summary>
        /// Main contact email for this app where people can receive support.
        /// </summary>
        public static readonly FacebookField UserSupportEmail = new FacebookField("user_support_email");

        /// <summary>
        /// URL shown in the Canvas footer that people can visit to get support for the app.
        /// </summary>
        public static readonly FacebookField UserSupportUrl = new FacebookField("user_support_url");

        /// <summary>
        /// URL of a website that integrates with this app.
        /// </summary>
        public static readonly FacebookField WebsiteUrl = new FacebookField("website_url");

        /// <summary>
        /// The number of weekly active users the app has.
        /// </summary>
        public static readonly FacebookField WeeklyActiveUsers = new FacebookField("weekly_active_users");

        #endregion

        /// <summary>
        /// Gets an array of all known fields available for a Facebook application.
        /// </summary>
        public static readonly FacebookField[] All = {
            Id, AnAdSpaceLimit, AnPlatforms, AppAdDebugInfo, AppDomains, AppInstallTracked, AppName, AppType, AuthDialogDataHelpUrl,
            AuthDialogHeadline, AuthDialogPermsExplanation, AuthReferralDefaultActivityPrivacy, AuthReferralEnabled, AuthReferralExtendedPerms,
            AuthReferralFriendPerms, AuthReferralResponseType, AuthReferralUserPerms, Business, CanvasFluidHeight, CanvasFluidWidth,
            CanvasUrl, Category, ClientConfig, Company, ConfiguredIosSso, ContactEmail, Context, CreatedTime, CreatorUid,
            DailyActiveUsers, DailyActiveUsersRank, DeauthCallbackUrl, DefaultShareMode, Description, FinancialId, HostingUrl,
            IconUrl, IosBundleId, IosSupportsNativeProxyAuthFlow, IosSupportsSystemAuth, IpadAppStoreId, IphoneAppStoreId,
            IsViewerAdmin, LatestSdkVersion, Link, LoggingToken, LogoUrl, Migrations, MobileProfileSectionUrl, MobileWebUrl,
            MonthlyActiveUsers, MonthlyActiveUsersRank, Name, Namespace, ObjectStoreUrls, PageTabDefaultName, PageTabUrl,
            PhotoUrl, PrivacyPolicyUrl, ProfileSectionUrl, Restrictions, SecureCanvasUrl, SecurePageTabUrl, ServerIpWhitelist,
            SocialDiscovery, Subcategory, SupportedPlatforms, TermsOfServiceUrl, UrlSchemeSuffix, UserSupportEmail, UserSupportUrl,
            WebsiteUrl, WeeklyActiveUsers
        };

    }

}