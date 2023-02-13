﻿using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Facebook.Models.Applications {

    /// <summary>
    /// Class representing a Facebook application (app).
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.10/application</cref>
    /// </see>
    public class FacebookApplication : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the app.
        /// </summary>
        public long Id { get; }

        // TODO: Add support for the "an_platforms" property
        // TODO: Add support for the "app_ad_debug_info" property

        /// <summary>
        /// Gets a list of domains and subdomains this app can use.
        /// </summary>
        public string[] AppDomains { get; }

        /// <summary>
        /// Gets whether the <see cref="AppDomains"/> property was included in the response and has a value.
        /// </summary>
        public bool HasAppDomains => AppDomains.Length > 0;

        // TODO: Add support for the "app_install_tracked" property

        /// <summary>
        /// Gets the app name.
        /// </summary>
        public string AppName { get; }

        /// <summary>
        /// Gets whether the <see cref="AppName"/> property was included in the response.
        /// </summary>
        public bool HasAppName => string.IsNullOrWhiteSpace(AppName) == false;

        /// <summary>
        /// Gets the app type.
        /// </summary>
        public int AppType { get; }

        /// <summary>
        /// Gets whether the <see cref="AppName"/> property was included in the response.
        /// </summary>
        public bool HasAppType => HasJsonProperty("app_type");

        // TODO: Add support for the "app_name" property
        // TODO: Add support for the "app_type" property
        // TODO: Add support for the "auth_dialog_data_help_url" property
        // TODO: Add support for the "auth_dialog_headline" property
        // TODO: Add support for the "auth_dialog_perms_explanation" property
        // TODO: Add support for the "auth_referral_default_activity_privacy" property
        // TODO: Add support for the "auth_referral_enabled" property
        // TODO: Add support for the "auth_referral_extended_perms" property
        // TODO: Add support for the "auth_referral_friend_perms" property
        // TODO: Add support for the "auth_referral_response_type" property
        // TODO: Add support for the "auth_referral_user_perms" property
        // TODO: Add support for the "canvas_fluid_height" property
        // TODO: Add support for the "canvas_fluid_width" property
        // TODO: Add support for the "canvas_url" property

        /// <summary>
        /// Gets the category of the app.
        /// </summary>
        public string Category { get; }

        /// <summary>
        /// Gets whether the <see cref="Category"/> property was included in the response.
        /// </summary>
        public bool HasCategory => string.IsNullOrWhiteSpace(Category) == false;

        // TODO: Add support for the "client_config" property

        /// <summary>
        /// Gets the name of the company the app belongs to.
        /// </summary>
        public string Company { get; }

        /// <summary>
        /// Gets whether the <see cref="Company"/> property has been specified and was included in the response.
        /// </summary>
        public bool HasCompany => string.IsNullOrWhiteSpace(Company) == false;

        // TODO: Add support for the "configured_ios_sso" property

        /// <summary>
        /// Gets the email address listed for people using the app to contact developers.
        /// </summary>
        public string ContactEmail { get; }

        /// <summary>
        /// Gets whether the <see cref="ContactEmail"/> property has been specified and was included in the response.
        /// </summary>
        public bool HasContactEmail => string.IsNullOrWhiteSpace(ContactEmail) == false;

        // TODO: Add support for the "context" property

        /// <summary>
        /// Gets the timestamp that indicates when the app was created.
        /// </summary>
        public EssentialsTime CreatedTime { get; }

        /// <summary>
        /// Gets whether the <see cref="CreatedTime"/> property was included in the response.
        /// </summary>
        public bool HasCreatedTime => CreatedTime != null;

        // TODO: Add support for the "creator_uid" property

        /// <summary>
        /// The number of daily active users the app has.
        /// </summary>
        public long DailyActiveUsers { get; }

        /// <summary>
        /// Gets whether the <see cref="DailyActiveUsers"/> property was included in the response.
        /// </summary>
        public bool HasDailyActiveUsers => HasJsonProperty("daily_active_users");

        /// <summary>
        /// Gets the ranking of this app vs other apps comparing daily active users.
        /// </summary>
        public uint DailyActiveUsersRank { get; }

        /// <summary>
        /// Gets whether the <see cref="DailyActiveUsersRank"/> property was included in the response.
        /// </summary>
        public bool HasDailyActiveUsersRank => HasJsonProperty("daily_active_users_rank");

        // TODO: Add support for the "deauth_callback_url" property
        // TODO: Add support for the "default_share_mode" property

        /// <summary>
        /// Gets the description of the app, as provided by the developer.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets whether the <see cref="Description"/> property has been specified and was included in the response.
        /// </summary>
        public bool HasDescription => string.IsNullOrWhiteSpace(Description) == false;

        // TODO: Add support for the "hosting_url" property

        /// <summary>
        /// Gets the URL of this app's icon.
        /// </summary>
        public string IconUrl { get; }

        /// <summary>
        /// Gets whether the <see cref="IconUrl"/> property has been specified and was included in the response.
        /// </summary>
        public bool HasIconUrl => string.IsNullOrWhiteSpace(IconUrl) == false;

        // TODO: Add support for the "ios_bundle_id" property
        // TODO: Add support for the "ios_supports_native_proxy_auth_flow" property
        // TODO: Add support for the "ios_supports_system_auth" property
        // TODO: Add support for the "ipad_app_store_id" property
        // TODO: Add support for the "iphone_app_store_id" property

        /// <summary>
        /// Gets the link to the app on Facebook.
        /// </summary>
        public string Link { get; }

        /// <summary>
        /// Gets whether the <see cref="Link"/> property has been specified and was included in the response.
        /// </summary>
        public bool HasLink => string.IsNullOrWhiteSpace(Link) == false;

        // TODO: Add support for the "logging_token" property

        /// <summary>
        /// Gets the URL of the app's logo.
        /// </summary>
        public string LogoUrl { get; }

        /// <summary>
        /// Gets whether the <see cref="Description"/> property has been specified and was included in the response.
        /// </summary>
        public bool HasLogoUrl => string.IsNullOrWhiteSpace(LogoUrl) == false;

        // TODO: Add support for the "migrations" property
        // TODO: Add support for the "mobile_profile_section_url" property
        // TODO: Add support for the "mobile_web_url" property

        /// <summary>
        /// Gets the number of monthly active users the app has.
        /// </summary>
        public long MonthlyActiveUsers { get; }

        /// <summary>
        /// Gets whether the <see cref="MonthlyActiveUsers"/> property was included in the response.
        /// </summary>
        public bool HasMonthlyActiveUsers => HasJsonProperty("monthly_active_users");

        /// <summary>
        /// Gets the ranking of this app vs other apps comparing monthly active users.
        /// </summary>
        public uint MonthlyActiveUsersRank { get; }

        /// <summary>
        /// Gets whether the <see cref="MonthlyActiveUsersRank"/> property was included in the response.
        /// </summary>
        public bool HasMonthlyActiveUsersRank => HasJsonProperty("monthly_active_users_rank");

        /// <summary>
        /// Gets the name of the app.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets whether the <see cref="Name"/> property was included in the response.
        /// </summary>
        public bool HasName => string.IsNullOrWhiteSpace(Name) == false;

        /// <summary>
        /// Gets the namespace of the app.
        /// </summary>
        public string Namespace { get; }

        /// <summary>
        /// Gets whether the <see cref="Namespace"/> property has been specified and was included in the response.
        /// </summary>
        public bool HasNamespace => string.IsNullOrWhiteSpace(Namespace) == false;

        // TODO: Add support for the "object_store_urls" property
        // TODO: Add support for the "page_tab_default_name" property
        // TODO: Add support for the "page_tab_url" property

        /// <summary>
        /// Gets the URL that links to a Privacy Policy for the app.
        /// </summary>
        public string PrivacyPolicyUrl { get; }

        /// <summary>
        /// Gets whether the <see cref="PrivacyPolicyUrl"/> property has been specified and was included in the
        /// response.
        /// </summary>
        public bool HasPrivacyPolicyUrl => string.IsNullOrWhiteSpace(PrivacyPolicyUrl) == false;

        // TODO: Add support for the "profile_section_url" property
        // TODO: Add support for the "restrictions" property
        // TODO: Add support for the "secure_canvas_url" property
        // TODO: Add support for the "secure_page_tab_url" property
        // TODO: Add support for the "server_ip_whitelist" property
        // TODO: Add support for the "social_discovery" property

        /// <summary>
        /// Gets the sub category the app can be found under.
        /// </summary>
        public string SubCategory { get; }

        /// <summary>
        /// Gets whether the <see cref="SubCategory"/> property was included in the response.
        /// </summary>
        public bool HasSubCategory => string.IsNullOrWhiteSpace(SubCategory) == false;

        // TODO: Add support for the "supported_platforms" property

        /// <summary>
        /// Gets the URL to Terms of Service that appears in the Login Dialog.
        /// </summary>
        public string TermsOfServiceUrl { get; }

        /// <summary>
        /// Gets whether the <see cref="TermsOfServiceUrl"/> property has been specified and was included in the
        /// response.
        /// </summary>
        public bool HasTermsOfServiceUrl => string.IsNullOrWhiteSpace(TermsOfServiceUrl) == false;

        // TODO: Add support for the "url_scheme_suffix" property

        /// <summary>
        /// Gets the main contact email for this app where people can receive support.
        /// </summary>
        public string UserSupportEmail { get; }

        /// <summary>
        /// Gets whether the <see cref="UserSupportEmail"/> property has been specified and was included in the
        /// response.
        /// </summary>
        public bool HasUserSupportEmail => string.IsNullOrWhiteSpace(UserSupportEmail) == false;

        /// <summary>
        /// Gets the URL shown in the Canvas footer that people can visit to get support for the app.
        /// </summary>
        public string UserSupportUrl { get; }

        /// <summary>
        /// Gets whether the <see cref="UserSupportUrl"/> property has been specified and was included in the response.
        /// </summary>
        public bool HasUserSupportUrl => string.IsNullOrWhiteSpace(UserSupportUrl) == false;

        /// <summary>
        /// Gets the URL of a website that integrates with this app.
        /// </summary>
        public string WebsiteUrl { get; }

        /// <summary>
        /// Gets whether the <see cref="WebsiteUrl"/> property has been specified and was included in the response.
        /// </summary>
        public bool HasWebsiteUrl => string.IsNullOrWhiteSpace(Description) == false;

        /// <summary>
        /// Gets the the number of weekly active users the app has.
        /// </summary>
        public long WeeklyActiveUsers { get; }

        /// <summary>
        /// Gets whether the <see cref="WeeklyActiveUsers"/> property was included in the response.
        /// </summary>
        public bool HasWeeklyActiveUsers => HasJsonProperty("weekly_active_users");

        #endregion

        #region Constructors

        private FacebookApplication(JObject obj) : base(obj) {
            Id = obj.GetInt64("id");
            // TODO: Add support for the "an_platforms" property
            // TODO: Add support for the "app_ad_debug_info" property
            AppDomains = obj.GetStringArray("app_domains");
            // TODO: Add support for the "app_install_tracked" property
            AppName = obj.GetString("app_name");
            AppType = obj.GetInt32("app_type");
            // TODO: Add support for the "auth_dialog_data_help_url" property
            // TODO: Add support for the "auth_dialog_headline" property
            // TODO: Add support for the "auth_dialog_perms_explanation" property
            // TODO: Add support for the "auth_referral_default_activity_privacy" property
            // TODO: Add support for the "auth_referral_enabled" property
            // TODO: Add support for the "auth_referral_extended_perms" property
            // TODO: Add support for the "auth_referral_friend_perms" property
            // TODO: Add support for the "auth_referral_response_type" property
            // TODO: Add support for the "auth_referral_user_perms" property
            // TODO: Add support for the "canvas_fluid_height" property
            // TODO: Add support for the "canvas_fluid_width" property
            // TODO: Add support for the "canvas_url" property
            Category = obj.GetString("category");
            // TODO: Add support for the "client_config" property
            Company = obj.GetString("company");
            // TODO: Add support for the "configured_ios_sso" property
            ContactEmail = obj.GetString("contact_email");
            // TODO: Add support for the "context" property
            CreatedTime = obj.GetString("created_time", EssentialsTime.Parse);
            // TODO: Add support for the "creator_uid" property
            DailyActiveUsers = obj.GetInt64("daily_active_users");
            DailyActiveUsersRank = GetUnsignedInt32(obj, "daily_active_users_rank");
            // TODO: Add support for the "deauth_callback_url" property
            // TODO: Add support for the "default_share_mode" property
            Description = obj.GetString("description");
            // TODO: Add support for the "hosting_url" property
            IconUrl = obj.GetString("icon_url");
            // TODO: Add support for the "ios_bundle_id" property
            // TODO: Add support for the "ios_supports_native_proxy_auth_flow" property
            // TODO: Add support for the "ios_supports_system_auth" property
            // TODO: Add support for the "ipad_app_store_id" property
            // TODO: Add support for the "iphone_app_store_id" property
            Link = obj.GetString("link");
            // TODO: Add support for the "logging_token" property
            LogoUrl = obj.GetString("logo_url");
            // TODO: Add support for the "migrations" property
            // TODO: Add support for the "mobile_profile_section_url" property
            // TODO: Add support for the "mobile_web_url" property
            MonthlyActiveUsers = obj.GetInt64("monthly_active_users");
            MonthlyActiveUsersRank = GetUnsignedInt32(obj, "monthly_active_users_rank");
            Name = obj.GetString("name");
            Namespace = obj.GetString("namespace");
            // TODO: Add support for the "object_store_urls" property
            // TODO: Add support for the "page_tab_default_name" property
            // TODO: Add support for the "page_tab_url" property
            PrivacyPolicyUrl = obj.GetString("privacy_policy_url");
            // TODO: Add support for the "profile_section_url" property
            // TODO: Add support for the "restrictions" property
            // TODO: Add support for the "secure_canvas_url" property
            // TODO: Add support for the "secure_page_tab_url" property
            // TODO: Add support for the "server_ip_whitelist" property
            // TODO: Add support for the "social_discovery" property
            SubCategory = obj.GetString("subcategory");
            // TODO: Add support for the "supported_platforms" property
            TermsOfServiceUrl = obj.GetString("terms_of_service_url");
            // TODO: Add support for the "url_scheme_suffix" property
            UserSupportEmail = obj.GetString("user_support_email");
            UserSupportUrl = obj.GetString("user_support_url");
            WebsiteUrl = obj.GetString("website_url");
            WeeklyActiveUsers = obj.GetInt64("weekly_active_users");
        }

        #endregion

        #region Member methods

        private uint GetUnsignedInt32(JObject obj, string propertyName) {
            JToken token = obj.GetObject(propertyName);
            return token == null || token.Type == JTokenType.Null ? default(uint) : token.Value<uint>();
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <c>obj</c> into an instance of <see cref="FacebookApplication"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookApplication"/>.</returns>
        public static FacebookApplication Parse(JObject obj) {
            return obj == null ? null : new FacebookApplication(obj);
        }

        #endregion

    }

}