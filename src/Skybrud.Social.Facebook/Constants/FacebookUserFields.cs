using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Models.Photos;

namespace Skybrud.Social.Facebook.Constants {

    /// <summary>
    ///  Static class with constants for the fields available for a Facebook user (<see cref="FacebookPhoto" />).
    ///  
    ///  The class is auto-generated and based on the fields listed in the Facebook Graph API documentation. Not all
    ///  fields may have been mapped for the implementation in Skybrud.Social.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.12/user</cref>
    /// </see>
    public static class FacebookUserFields {

        #region Individial fields

        /// <summary>
        /// <em>Returns no data as of April 4, 2018.</em>.
        /// </summary>
        public static readonly FacebookField About = new FacebookField("about");

        /// <summary>
        /// The id of this person's user account. This ID is unique to each app and cannot be used across different
        /// apps. <a href="https://developers.facebook.com/docs/apps/upgrading/#upgrading_v2_0_user_ids"
        /// target="_blank">Our upgrade guide provides more information about app-specific IDs</a>.
        /// </summary>
        public static readonly FacebookField Id = new FacebookField("id");

        /// <summary>
        /// The person's address.
        /// </summary>
        public static readonly FacebookField Address = new FacebookField("address");

        /// <summary>
        /// Notes added by viewing page on this person.
        /// </summary>
        public static readonly FacebookField AdminNotes = new FacebookField("admin_notes");

        /// <summary>
        /// The age segment for this person expressed as a minimum and maximum age. For example, more than 18, less than
        /// 21.
        /// </summary>
        public static readonly FacebookField AgeRange = new FacebookField("age_range");

        /// <summary>
        /// The person's birthday.  This is a fixed format string, like <c>MM/DD/YYYY</c>.  However, people can control
        /// who can see the year they were born separately from the month and day so this string can be only the year
        /// (YYYY) or the month + day (MM/DD).
        /// </summary>
        public static readonly FacebookField Birthday = new FacebookField("birthday");

        /// <summary>
        /// Social context for this person.
        /// </summary>
        public static readonly FacebookField Context = new FacebookField("context");

        /// <summary>
        /// The person's cover photo.
        /// </summary>
        public static readonly FacebookField Cover = new FacebookField("cover");

        /// <summary>
        /// The person's local currency information.
        /// </summary>
        public static readonly FacebookField Currency = new FacebookField("currency");

        /// <summary>
        /// The list of devices the person is using. This will return only iOS and Android devices.
        /// </summary>
        public static readonly FacebookField Devices = new FacebookField("devices");

        /// <summary>
        /// <em>Returns no data as of April 4, 2018.</em>.
        /// </summary>
        public static readonly FacebookField Education = new FacebookField("education");

        /// <summary>
        /// The person's primary email address listed on their profile. This field will not be returned if no valid
        /// email address is available.
        /// </summary>
        public static readonly FacebookField Email = new FacebookField("email");

        /// <summary>
        /// The person's employee number, as set by the company via SCIM API.
        /// </summary>
        public static readonly FacebookField EmployeeNumber = new FacebookField("employee_number");

        /// <summary>
        /// Athletes the person likes.
        /// </summary>
        public static readonly FacebookField FavoriteAthletes = new FacebookField("favorite_athletes");

        /// <summary>
        /// Sports teams the person likes.
        /// </summary>
        public static readonly FacebookField FavoriteTeams = new FacebookField("favorite_teams");

        /// <summary>
        /// The person's first name.
        /// </summary>
        public static readonly FacebookField FirstName = new FacebookField("first_name");

        /// <summary>
        /// The gender selected by this person, <c>male</c> or <c>female</c>. If the gender is set to a custom value,
        /// this value will be based off of the preferred pronoun; it will be omitted if the preferred preferred pronoun
        /// is neutral.
        /// </summary>
        public static readonly FacebookField Gender = new FacebookField("gender");

        /// <summary>
        /// The person's hometown.
        /// </summary>
        public static readonly FacebookField Hometown = new FacebookField("hometown");

        /// <summary>
        /// The person's inspirational people.
        /// </summary>
        public static readonly FacebookField InspirationalPeople = new FacebookField("inspirational_people");

        /// <summary>
        /// Install type.
        /// </summary>
        public static readonly FacebookField InstallType = new FacebookField("install_type");

        /// <summary>
        /// Is the app making the request installed?
        /// </summary>
        public static readonly FacebookField Installed = new FacebookField("installed");

        /// <summary>
        /// <em>Returns no data as of April 4, 2018.</em>.
        /// </summary>
        public static readonly FacebookField InterestedIn = new FacebookField("interested_in");

        /// <summary>
        /// Is this a shared login (e.g. a gray user).
        /// </summary>
        public static readonly FacebookField IsSharedLogin = new FacebookField("is_shared_login");

        /// <summary>
        /// People with large numbers of followers can have the authenticity of their identity <a
        /// href="https://www.facebook.com/help/196050490547892" target="_blank">manually verified by Facebook</a>. This
        /// field indicates whether the person's profile is verified in this way. This is distinct from the
        /// <c>verified</c> field.
        /// </summary>
        public static readonly FacebookField IsVerified = new FacebookField("is_verified");

        /// <summary>
        /// Labels applied by viewing page on this person.
        /// </summary>
        public static readonly FacebookField Labels = new FacebookField("labels");

        /// <summary>
        /// Facebook Pages representing the languages this person knows.
        /// </summary>
        public static readonly FacebookField Languages = new FacebookField("languages");

        /// <summary>
        /// The person's last name.
        /// </summary>
        public static readonly FacebookField LastName = new FacebookField("last_name");

        /// <summary>
        /// A link to the person's Timeline.
        /// </summary>
        public static readonly FacebookField Link = new FacebookField("link");

        /// <summary>
        /// Display megaphone for local news bookmark.
        /// </summary>
        public static readonly FacebookField LocalNewsMegaphoneDismissStatus = new FacebookField("local_news_megaphone_dismiss_status");

        /// <summary>
        /// Daily local news notification.
        /// </summary>
        public static readonly FacebookField LocalNewsSubscriptionStatus = new FacebookField("local_news_subscription_status");

        /// <summary>
        /// The person's locale.
        /// </summary>
        public static readonly FacebookField Locale = new FacebookField("locale");

        /// <summary>
        /// The person's current location as entered by them on their profile. This field is not related to check-ins.
        /// </summary>
        public static readonly FacebookField Location = new FacebookField("location");

        /// <summary>
        /// What the person is interested in meeting for.
        /// </summary>
        public static readonly FacebookField MeetingFor = new FacebookField("meeting_for");

        /// <summary>
        /// The person's middle name.
        /// </summary>
        public static readonly FacebookField MiddleName = new FacebookField("middle_name");

        /// <summary>
        /// The person's full name.
        /// </summary>
        public static readonly FacebookField Name = new FacebookField("name");

        /// <summary>
        /// The person's name formatted to correctly handle Chinese, Japanese, or Korean ordering.
        /// </summary>
        public static readonly FacebookField NameFormat = new FacebookField("name_format");

        /// <summary>
        /// The person's payment pricepoints.
        /// </summary>
        public static readonly FacebookField PaymentPricepoints = new FacebookField("payment_pricepoints");

        /// <summary>
        /// <em>Returns no data as of April 4, 2018.</em>.
        /// </summary>
        public static readonly FacebookField Political = new FacebookField("political");

        /// <summary>
        /// The person's PGP public key.
        /// </summary>
        public static readonly FacebookField PublicKey = new FacebookField("public_key");

        /// <summary>
        /// The person's favorite quotes.
        /// </summary>
        public static readonly FacebookField Quotes = new FacebookField("quotes");

        /// <summary>
        /// <em>Returns no data as of April 4, 2018.</em>.
        /// </summary>
        public static readonly FacebookField RelationshipStatus = new FacebookField("relationship_status");

        /// <summary>
        /// <em>Returns no data as of April 4, 2018.</em>.
        /// </summary>
        public static readonly FacebookField Religion = new FacebookField("religion");

        /// <summary>
        /// Security settings.
        /// </summary>
        public static readonly FacebookField SecuritySettings = new FacebookField("security_settings");

        /// <summary>
        /// The time that the shared loginneeds to be upgraded to Business Manager by.
        /// </summary>
        public static readonly FacebookField SharedLoginUpgradeRequiredBy = new FacebookField("shared_login_upgrade_required_by");

        /// <summary>
        /// The person's significant other.
        /// </summary>
        public static readonly FacebookField SignificantOther = new FacebookField("significant_other");

        /// <summary>
        /// Sports played by the person.
        /// </summary>
        public static readonly FacebookField Sports = new FacebookField("sports");

        /// <summary>
        /// Platform test group.
        /// </summary>
        public static readonly FacebookField TestGroup = new FacebookField("test_group");

        /// <summary>
        /// A string containing an anonymous, but unique identifier for the person. You can use this identifier with
        /// third parties.
        /// </summary>
        public static readonly FacebookField ThirdPartyId = new FacebookField("third_party_id");

        /// <summary>
        /// The person's current timezone offset from UTC.
        /// </summary>
        public static readonly FacebookField Timezone = new FacebookField("timezone");

        /// <summary>
        /// A token that is the same across a business's apps. Access to this token requires that the person be logged
        /// into your app or have a role on your app. This token will change if the business owning the app changes.
        /// </summary>
        public static readonly FacebookField TokenForBusiness = new FacebookField("token_for_business");

        /// <summary>
        /// Updated time.
        /// </summary>
        public static readonly FacebookField UpdatedTime = new FacebookField("updated_time");

        /// <summary>
        /// Indicates whether the account has been verified. This is distinct from the <c>is_verified</c> field. Someone
        /// is considered verified if they take any of the following actions:.
        /// </summary>
        public static readonly FacebookField Verified = new FacebookField("verified");

        /// <summary>
        /// Video upload limits.
        /// </summary>
        public static readonly FacebookField VideoUploadLimits = new FacebookField("video_upload_limits");

        /// <summary>
        /// Can the viewer send a gift to this person?
        /// </summary>
        public static readonly FacebookField ViewerCanSendGift = new FacebookField("viewer_can_send_gift");

        /// <summary>
        /// <em>Returns no data as of April 4, 2018.</em>.
        /// </summary>
        public static readonly FacebookField Website = new FacebookField("website");

        /// <summary>
        /// <em>Returns no data as of April 4, 2018.</em>.
        /// </summary>
        public static readonly FacebookField Work = new FacebookField("work");

        #endregion

        /// <summary>
        /// Gets an array of all known fields available for a Facebook user.
        /// </summary>
        public static readonly FacebookField[] All = {
            About, Id, Address, AdminNotes, AgeRange, Birthday, Context, Cover, Currency, Devices, Education, Email, EmployeeNumber,
            FavoriteAthletes, FavoriteTeams, FirstName, Gender, Hometown, InspirationalPeople, InstallType, Installed, InterestedIn,
            IsSharedLogin, IsVerified, Labels, Languages, LastName, Link, LocalNewsMegaphoneDismissStatus, LocalNewsSubscriptionStatus,
            Locale, Location, MeetingFor, MiddleName, Name, NameFormat, PaymentPricepoints, Political, PublicKey, Quotes,
            RelationshipStatus, Religion, SecuritySettings, SharedLoginUpgradeRequiredBy, SignificantOther, Sports, TestGroup,
            ThirdPartyId, Timezone, TokenForBusiness, UpdatedTime, Verified, VideoUploadLimits, ViewerCanSendGift, Website,
            Work
        };

    }

}