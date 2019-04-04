using System;

namespace Skybrud.Social.Facebook.Scopes {
    
    /// <summary>
    /// Static class with properties representing scopes of available for the Facebook Graph API. If you're missing a
    /// scope that hasn't been added to this class, feel free to create
    /// <a href="https://github.com/abjerner/Skybrud.Social.Facebook/issues/new">an issue on GitHub</a>.
    /// </summary>
    public static class FacebookScopes {

        #region Basic permissions

        /// <summary>
        /// Granted by default. Provides access to a subset of items that are part of a person's public profile.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.facebook.com/docs/facebook-login/permissions#reference-public_profile</cref>
        /// </see>
        public static readonly FacebookScope PublicProfile = new FacebookScope(
            "public_profile",
            "Granted by default. Provides access to a subset of items that are part of a person's public profile.",
            FacebookScopeReview.No
        );

        /// <summary>
        /// Provides access to the person's primary email address via the <c>email</c> property on the <c>user</c> object.
        /// </summary>
        /// <see>
        ///     <cref>https://developers.facebook.com/docs/facebook-login/permissions#reference-email</cref>
        /// </see>
        public static readonly FacebookScope Email = new FacebookScope(
            "email",
            "Provides access to the person's primary email address via the <code>email</code> property on the <code>user</code> object.",
            FacebookScopeReview.No
        );

        /// <summary>
        /// Provides access the list of friends that also use your app. These friends can be found on the friends edge
        /// on the user object.
        /// 
        /// In order for a person to show up in one person's friend list, both people must have decided to share their
        /// list of friends with your app and not disabled that permission during login. Also both friends must have
        /// been asked for <c>user_friends</c> during the login process.
        /// </summary>
        public static readonly FacebookScope UserFriends = new FacebookScope(
            "user_friends",
            "Provides access the list of friends that also use your app. These friends can be found on the friends edge on the user object.<br /><br />In order for a person to show up in one person's friend list, both people must have decided to share their list of friends with your app and not disabled that permission during login. Also both friends must have been asked for <code>user_friends</code> during the login process.",
            FacebookScopeReview.No
        );

        #endregion

        #region Extended user permissions

        /// <summary>
        /// Provides access to a person's personal description (the 'About Me' section on their Profile) through the <c>bio</c> property on the <c>User</c> object.
        /// </summary>
        public static readonly FacebookScope UserAboutMe = new FacebookScope(
            "user_about_me",
            "Provides access to a person's personal description (the 'About Me' section on their Profile) through the <code>bio</code> property on the <code>User</code> object.",
            FacebookScopeReview.Yes
        );

        /// <summary>
        /// Access the date and month of a person's birthday. This may or may not include the person's year of birth,
        /// dependent upon their privacy settings and the access token being used to query this field.
        /// 
        /// Please note most integrations will only need <c>age_range</c> which comes as part of the
        /// <c>public_profile</c> permission.
        /// </summary>
        public static readonly FacebookScope UserBirthday = new FacebookScope(
            "user_birthday",
            "Access the date and month of a person's birthday. This may or may not include the person's year of birth, dependent upon their privacy settings and the access token being used to query this field.<br /><br />Please note most integrations will only need <code>age_range</code> which comes as part of the <code>public_profile</code> permission.",
            FacebookScopeReview.Yes
        );

        /// <summary>
        /// Provides access to a person's education history through the <c>education</c> field.
        /// </summary>
        public static readonly FacebookScope UserEducationHistory = new FacebookScope(
            "user_education_history",
            "Provides access to a person's education history through the <code>education</code> field.",
            FacebookScopeReview.Yes
        );

        /// <summary>
        /// Provides read-only access to the events a person is hosting or has RSVP'd to.
        /// </summary>
        public static readonly FacebookScope UserEvents = new FacebookScope(
            "user_events",
            "Provides read-only access to the events a person is hosting or has RSVP'd to.",
            FacebookScopeReview.Yes
        );

        /// <summary>
        /// Provides access to read a person's game activity (scores, achievements) in any game the person has played.
        /// </summary>
        public static readonly FacebookScope UserGamesActivity = new FacebookScope(
            "user_games_activity",
            "Provides access to read a person's game activity (scores, achievements) in any game the person has played.",
            FacebookScopeReview.Yes
        );

        /// <summary>
        /// Provides access to a person's hometown location through the <c>hometown</c> field on the
        /// <a href="https://developers.facebook.com/docs/graph-api/reference/user">User object</a>. This is set by the
        /// user in their profile.
        /// </summary>
        public static readonly FacebookScope UserHometown = new FacebookScope(
            "user_hometown",
            "Provides access to a person's hometown location through the <code>hometown</code> field on the <a href=\"https://developers.facebook.com/docs/graph-api/reference/user\">User object</a>. This is set by the user in their profile.",
            FacebookScopeReview.Yes
        );

        /// <summary>
        /// Provides access to the list of all Facebook Pages and Open Graph objects that a person has liked. This list
        /// is available through the <a href="https://developers.facebook.com/docs/graph-api/reference/user/likes">likes edge</a>
        /// on the <a href="https://developers.facebook.com/docs/graph-api/reference/user">User object</a>.
        /// </summary>
        public static readonly FacebookScope UserLikes = new FacebookScope(
            "user_likes",
            "Provides access to the list of all Facebook Pages and Open Graph objects that a person has liked. This list is available through the <a href=\"https://developers.facebook.com/docs/graph-api/reference/user/likes\">likes edge</a> on the <a href=\"https://developers.facebook.com/docs/graph-api/reference/user\">User object</a>.",
            FacebookScopeReview.Yes
        );

        public static readonly FacebookScope UserLocation = new FacebookScope("user_location");

        public static readonly FacebookScope UserManagedGroups = new FacebookScope("user_managed_groups");

        public static readonly FacebookScope UserPhotos = new FacebookScope("user_photos");

        public static readonly FacebookScope UserPosts = new FacebookScope("user_posts");

        public static readonly FacebookScope UserRelationships = new FacebookScope("user_relationships");

        public static readonly FacebookScope UserRelationshipDetails = new FacebookScope("user_relationship_details");

        public static readonly FacebookScope UserReligionPolitics = new FacebookScope("user_religion_politics");

        public static readonly FacebookScope UserTaggedPlaces = new FacebookScope("user_tagged_places");

        public static readonly FacebookScope UserVideos = new FacebookScope("user_videos");

        public static readonly FacebookScope UserWebsite = new FacebookScope("user_website");

        public static readonly FacebookScope UserWorkHistory = new FacebookScope("user_work_history");

        #endregion

        #region User actions

        /// <summary>
        /// Provides access to all common books actions published by any app the person has used. This includes books
        /// they've read, want to read, rated or quoted.
        /// </summary>
        public static readonly FacebookScope UserActionsBooks = new FacebookScope(
            "user_actions.books",
            "Provides access to all common books actions published by any app the person has used. This includes books they've read, want to read, rated or quoted.",
            FacebookScopeReview.Yes
        );

        /// <summary>
        /// Provides access to all common Open Graph fitness actions published by any app the person has used. This
        /// includes runs, walks and bikes actions.
        /// </summary>
        public static readonly FacebookScope UserActionsFitness = new FacebookScope(
            "user_actions.fitness",
            "Provides access to all common Open Graph fitness actions published by any app the person has used. This includes runs, walks and bikes actions.",
            FacebookScopeReview.Yes
        );

        /// <summary>
        /// Provides access to all common Open Graph music actions published by any app the person has used. This
        /// includes songs they've listened to, and playlists they've created.
        /// </summary>
        public static readonly FacebookScope UserActionsMusic = new FacebookScope(
            "user_actions.music",
            "Provides access to all common Open Graph music actions published by any app the person has used. This includes songs they've listened to, and playlists they've created.",
            FacebookScopeReview.Yes
        );

        /// <summary>
        /// Provides access to all common Open Graph news actions published by any app the person has used which
        /// publishes these actions. This includes news articles they've read or news articles they've published.
        /// </summary>
        public static readonly FacebookScope UserActionsNews = new FacebookScope(
            "user_actions.news",
            "Provides access to all common Open Graph news actions published by any app the person has used which publishes these actions. This includes news articles they've read or news articles they've published.",
            FacebookScopeReview.Yes
        );

        /// <summary>
        /// Provides access to all common Open Graph video actions published by any app the person has used which publishes these actions. This includes videos they've watched, videos they've rated and videos they want to watch.
        /// </summary>
        public static readonly FacebookScope UserActionsVideo = new FacebookScope(
            "user_actions.video",
            "Provides access to all common Open Graph video actions published by any app the person has used which publishes these actions. This includes videos they've watched, videos they've rated and videos they want to watch.",
            FacebookScopeReview.Yes
        );

        #endregion

        public static readonly FacebookScope ReadCustomFriendlists = new FacebookScope("read_custom_friendlists");

        public static readonly FacebookScope ReadInsights = new FacebookScope("read_insights");

        public static readonly FacebookScope ReadAudienceNetworkInsights = new FacebookScope("read_audience_network_insights");

        public static readonly FacebookScope ReadPageMailboxes = new FacebookScope("read_page_mailboxes");

        /// <summary>
        /// Lets the application manage pages that you have access to.
        /// </summary>
        public static readonly FacebookScope ManagePages = new FacebookScope(
            "manage_pages",
            "Enables your application to retrieve access_tokens for Pages and Applications that the user administrates. The access tokens can be queried by calling <code>/&lt;user_id&gt;/accounts</code> via the Graph API. <br> See <a href=\"https://developers.facebook.com/roadmap/offline-access-removal/#page_access_token\">here</a> for generating long-lived Page access tokens that do not expire after 60 days."
        );

        public static readonly FacebookScope PublishPages = new FacebookScope("publish_pages");

        public static readonly FacebookScope PublishActions = new FacebookScope("publish_actions");

        public static readonly FacebookScope RsvpEvent = new FacebookScope("rsvp_event");

        public static readonly FacebookScope PagesShowList = new FacebookScope("pages_show_list");

        public static readonly FacebookScope PagesManageCta = new FacebookScope("pages_manage_cta");

        public static readonly FacebookScope AdsRead = new FacebookScope("ads_read");

        public static readonly FacebookScope AdsManagement = new FacebookScope("ads_management");

        #region Deprecated scopes

        [Obsolete]
        public static readonly FacebookScope ManageNotifications = new FacebookScope("manage_notifications");

        [Obsolete]
        public static readonly FacebookScope ReadStream = new FacebookScope("read_stream");

        [Obsolete]
        public static readonly FacebookScope ReadMailbox = new FacebookScope("read_mailbox");

        /// <summary>
        /// This permission is only available for apps using Graph API version v2.3 or older.
        /// 
        /// Enables your app to read the groups a person is a member of through the groups edge on the user object.
        /// </summary>
        [Obsolete]
        public static readonly FacebookScope UserGroups = new FacebookScope(
            "user_groups",
            "This permission is only available for apps using Graph API version v2.3 or older.<br /><br />Enables your app to read the groups a person is a member of through the groups edge on the user object.",
            FacebookScopeReview.Yes
        );

        [Obsolete]
        public static readonly FacebookScope UserStatus = new FacebookScope("user_status");

        #endregion

    }

}