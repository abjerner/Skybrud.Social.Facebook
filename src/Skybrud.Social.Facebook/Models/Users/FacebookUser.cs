using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Models.Common;
using Skybrud.Social.Facebook.Models.Pages;

namespace Skybrud.Social.Facebook.Models.Users {
    
    /// <summary>
    /// Class representing information about a Facebook user.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/user#Reading</cref>
    /// </see>
    public class FacebookUser : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the user. As of v2.0 of the Facebook Graph API, IDs are unique to each app and cannot be
        /// used across different apps.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the "about me" section of the person's profile.
        /// </summary>
        public string About { get; private set; }

        // TODO: Add support for the "admin_notes" field

        // TODO: Add support for the "age_range" field

        /// <summary>
        /// Gets whether the <see cref="About"/> property was included in the response and has a value.
        /// </summary>
        public bool HasAbout {
            get { return !String.IsNullOrWhiteSpace(About); }
        }

        /// <summary>
        /// Gets the birthday of the user.
        /// </summary>
        public string Birthday { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Birthday"/> property was included in the response.
        /// </summary>
        public bool HasBirthday {
            get { return !String.IsNullOrWhiteSpace(Birthday); }
        }

        // TODO: Add support for the "can_review_measurement_request" field

        // TODO: Add support for the "context" field

        /// <summary>
        /// Gets information about the cover photo of the user.
        /// </summary>
        public FacebookCoverPhoto Cover { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Cover"/> property was included in the response.
        /// </summary>
        public bool HasCover {
            get { return Cover != null; }
        }

        /// <summary>
        /// Gets the person's local currency information.
        /// </summary>
        public FacebookCurrency Currency { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Currency"/> property was included in the response.
        /// </summary>
        public bool HasCurrency {
            get { return Currency != null; }
        }

        /// <summary>
        /// Gets the list of devices the person is using. This will return only iOS and Android devices.
        /// </summary>
        public FacebookUserDevice[] Devices { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Devices"/> property was included in the response.
        /// </summary>
        public bool HasDevices {
            get { return Devices.Any(); }
        }

        /// <summary>
        /// Gets the person's education.
        /// </summary>
        public FacebookEducationExperience[] Education { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Education"/> property was included in the response.
        /// </summary>
        public bool HasEducation {
            get { return Education.Any(); }
        }

        /// <summary>
        /// Gets the email address of the user.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Email"/> property was included in the response and has a value.
        /// </summary>
        public bool HasEmail {
            get { return !String.IsNullOrWhiteSpace(Email); }
        }

        /// <summary>
        /// Gets the he person's employee number, as set by the company via SCIM API.
        /// </summary>
        public string EmployeeNumber { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="EmployeeNumber"/> property was included in the response.
        /// </summary>
        public bool HasEmployeeNumber {
            get { return !String.IsNullOrWhiteSpace(EmployeeNumber); }
        }

        /// <summary>
        /// Gets an array of athletes the person likes.
        /// </summary>
        public FacebookExperience[] FavoriteAthletes { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="FavoriteAthletes"/> property was included in the response.
        /// </summary>
        public bool HasFavoriteAthletes {
            get { return FavoriteAthletes.Any(); }
        }

        /// <summary>
        /// Gets an array of sports teams the person likes.
        /// </summary>
        public FacebookExperience[] FavoriteTeams { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="FavoriteTeams"/> property was included in the response.
        /// </summary>
        public bool HasFavoriteTeams {
            get { return FavoriteTeams.Any(); }
        }

        /// <summary>
        /// Gets the first name of the user.
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="FirstName"/> property was included in the response and has a value.
        /// </summary>
        public bool HasFirstName {
            get { return !String.IsNullOrWhiteSpace(FirstName); }
        }

        /// <summary>
        /// Gets the gender of the user.
        /// </summary>
        public FacebookGender Gender { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Gender"/> property was included in the response and has a value.
        /// </summary>
        public bool HasGender {
            get { return Gender != FacebookGender.NotSpecified; }
        }

        /// <summary>
        /// Gets information about the hometown of the user.
        /// </summary>
        public FacebookPage Hometown { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Hometown"/> property was included in the response.
        /// </summary>
        public bool HasHometown {
            get { return Hometown != null; }
        }

        /// <summary>
        /// Gets an array of the person's inspirational people.
        /// </summary>
        public FacebookExperience[] InspirationalPeople { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="InspirationalPeople"/> property was included in the response.
        /// </summary>
        public bool HasInspirationalPeople {
            get { return InspirationalPeople.Any(); }
        }

        // TODO: Add support for the "install_type" field

        /// <summary>
        /// Gets whether the app making the request installed.
        /// </summary>
        public bool Installed { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Installed"/> property was included in the response.
        /// </summary>
        public bool HasInstalled {
            get { return JObject.HasValue("installed"); }
        }

        /// <summary>
        /// Gets an array of genders the person is interested in.
        /// </summary>
        public string[] InterestedIn { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="InterestedIn"/> property was included in the response.
        /// </summary>
        public bool HasInterestedIn {
            get { return InterestedIn.Any(); }
        }

        /// <summary>
        /// Gets whether the login is shared (e.g. a gray user).
        /// </summary>
        public bool IsSharedLogin { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="IsSharedLogin"/> property was included in the response.
        /// </summary>
        public bool HasIsSharedLogin {
            get { return JObject.HasValue("is_shared_login"); }
        }

        /// <summary>
        /// People with large numbers of followers can have the authenticity of their identity manually verified by
        /// Facebook. This field indicates whether the user profile is verified in this way.
        /// </summary>
        public bool IsVerified { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="IsVerified"/> property was included in the response.
        /// </summary>
        public bool HasIsVerified {
            get { return JObject.HasValue("is_verified"); }
        }

        // TODO: Add support for the "labels" field

        /// <summary>
        /// Gets an array of the Facebook pages representing the languages this person knows.
        /// </summary>
        public FacebookExperience[] Languages { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Languages"/> property was included in the response and has a value.
        /// </summary>
        public bool HasLanguages {
            get { return Languages.Length > 0; }
        }

        /// <summary>
        /// Gets the last name of the user.
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="LastName"/> property was included in the response and has a value.
        /// </summary>
        public bool HasLastName {
            get { return !String.IsNullOrWhiteSpace(LastName); }
        }

        /// <summary>
        /// Gets a link to the profile of the user.
        /// </summary>
        public string Link { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Link"/> property was included in the response and has a value.
        /// </summary>
        public bool HasLink {
            get { return !String.IsNullOrWhiteSpace(Link); }
        }

        /// <summary>
        /// Gets the selected locale of the user.
        /// </summary>
        public string Locale { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Locale"/> property was included in the response and has a value.
        /// </summary>
        public bool HasLocale {
            get { return !String.IsNullOrWhiteSpace(Locale); }
        }

        /// <summary>
        /// Gets the person's current location as entered by them on their profile. This field is not related to
        /// check-ins.
        /// </summary>
        public FacebookPage Location { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Location"/> property was included in the response.
        /// </summary>
        public bool HasLocation {
            get { return Location != null; }
        }

        /// <summary>
        /// Gets an array of what the person is interested in meeting for.
        /// </summary>
        public string[] MeetingFor { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="MeetingFor"/> property was included in the response.
        /// </summary>
        public bool HasMeetingFor {
            get { return MeetingFor.Any(); }
        }

        /// <summary>
        /// Gets the middle name of the user.
        /// </summary>
        public string MiddleName { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="MiddleName"/> property was included in the response and has a value.
        /// </summary>
        public bool HasMiddleName {
            get { return !String.IsNullOrWhiteSpace(MiddleName); }
        }

        /// <summary>
        /// Gets the full name of the user.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Name"/> property was included in the response and has a value.
        /// </summary>
        public bool HasName {
            get { return !String.IsNullOrWhiteSpace(Name); }
        }

        /// <summary>
        /// Gets the person's name formatted to correctly handle Chinese, Japanese, or Korean ordering.
        /// </summary>
        public string NameFormat { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="NameFormat"/> property was included in the response.
        /// </summary>
        public bool HasNameFormat {
            get { return !String.IsNullOrWhiteSpace(NameFormat); }
        }
        
        // TODO: Add support for the "payment_pricepoints" field

        /// <summary>
        /// Gets the person's political views.
        /// </summary>
        public string Political { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Political"/> property was included in the response.
        /// </summary>
        public bool HasPolitical {
            get { return !String.IsNullOrWhiteSpace(Political); }
        }

        /// <summary>
        /// Gets the person's PGP public key.
        /// </summary>
        public string PublicKey { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="PublicKey"/> property was included in the response.
        /// </summary>
        public bool HasPublicKey {
            get { return !String.IsNullOrWhiteSpace(PublicKey); }
        }

        /// <summary>
        /// Gets the person's favorite quotes.
        /// </summary>
        public string Quotes { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Quotes"/> property was included in the response.
        /// </summary>
        public bool HasQuotes {
            get { return !String.IsNullOrWhiteSpace(Quotes); }
        }

        /// <summary>
        /// Gets the person's relationship status.
        /// </summary>
        public string RelationshipStatus { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="RelationshipStatus"/> property was included in the response.
        /// </summary>
        public bool HasRelationshipStatus {
            get { return !String.IsNullOrWhiteSpace(RelationshipStatus); }
        }

        /// <summary>
        /// Gets the person's religion.
        /// </summary>
        public string Religion { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Religion"/> property was included in the response.
        /// </summary>
        public bool HasReligion {
            get { return !String.IsNullOrWhiteSpace(Religion); }
        }

        // TODO: Add support for the "security_settings" field

        // TODO: Add support for the "shared_login_upgrade_required_by" field

        /// <summary>
        /// Gets the person's significant other.
        /// </summary>
        public FacebookUser SignificantOther { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="SignificantOther"/> property was included in the response.
        /// </summary>
        public bool HasSignificantOther {
            get { return SignificantOther != null; }
        }

        /// <summary>
        /// Gets an array of sports played by the person.
        /// </summary>
        public FacebookExperience[] Sports { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Sports"/> property was included in the response.
        /// </summary>
        public bool HasSports {
            get { return Sports.Any(); }
        }

        // TODO: Add support for the "test_group" field

        /// <summary>
        /// Gets a string containing an anonymous, but unique identifier for the person. You can use this identifier
        /// with third parties.
        /// </summary>
        public string ThirdPartyId { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="ThirdPartyId"/> property was included in the response.
        /// </summary>
        public bool HasThirdPartyId {
            get { return !String.IsNullOrWhiteSpace(ThirdPartyId); }
        }

        /// <summary>
        /// Gets the selected timezone of the user. The timezone is specified as the offset in hours from UTC.
        /// </summary>
        public float Timezone { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Timezone"/> property was included in the response.
        /// </summary>
        public bool HasTimezone {
            get { return JObject.HasValue("timezone"); }
        }

        // TODO: Add support for the "token_for_business" field

        /// <summary>
        /// Gets the update time of the user.
        /// </summary>
        public EssentialsDateTime UpdatedTime { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="UpdatedTime"/> property was included in the response.
        /// </summary>
        public bool HasUpdatedTime {
            get { return UpdatedTime != null; }
        }

        /// <summary>
        /// Indicates whether the user account has been verified. This is distinct from the <see cref="IsVerified"/>
        /// field. Someone is considered verified if they take any of the following actions:
        /// - Register for mobile
        /// - Confirm their account via SMS
        /// - Enter a valid credit card
        /// </summary>
        public bool Verified { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Verified"/> property was included in the response.
        /// </summary>
        public bool HasVerified {
            get { return JObject.HasValue("verified"); }
        }

        // TODO: Add support for the "video_upload_limits" field

        // TODO: Add support for the "viewer_can_send_gift" field

        /// <summary>
        /// Gets the URL for the website of the user.
        /// </summary>
        public string Website { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Website"/> property was included in the response and has a value.
        /// </summary>
        public bool HasWebsite {
            get { return !String.IsNullOrWhiteSpace(Website); }
        }

        /// <summary>
        /// Gets an array of the person`s work experience.
        /// </summary>
        public FacebookWorkExperience[] Work { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Work"/> property was included in the response.
        /// </summary>
        public bool HasWork {
            get { return Work.Any(); }
        }

        #endregion

        #region Constructors

        private FacebookUser(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            About = obj.GetString("about");
            // TODO: Add support for the "admin_notes" field
            // TODO: Add support for the "age_range" field
            Birthday = obj.GetString("birthday");
            // TODO: Add support for the "can_review_measurement_request" field
            // TODO: Add support for the "context" field
            Cover = obj.GetObject("cover", FacebookCoverPhoto.Parse);
            Currency = obj.GetObject("currency", FacebookCurrency.Parse);
            Devices = obj.GetArrayItems("devices", FacebookUserDevice.Parse);
            Education = obj.GetArrayItems("education", FacebookEducationExperience.Parse);
            Email = obj.GetString("email");
            EmployeeNumber = obj.GetString("employee_number");
            FavoriteAthletes = obj.GetArrayItems("favorite_athletes", FacebookExperience.Parse);
            FavoriteTeams = obj.GetArrayItems("favorite_teams", FacebookExperience.Parse);
            FirstName = obj.GetString("first_name");
            Gender = obj.GetEnum("gender", FacebookGender.NotSpecified);
            Hometown = obj.GetObject("hometown", FacebookPage.Parse);
            InspirationalPeople = obj.GetArrayItems("inspirational_people", FacebookExperience.Parse);
            // TODO: Add support for the "install_type" field
            Installed = obj.GetBoolean("installed");
            InterestedIn = obj.GetStringArray("interested_in");
            IsSharedLogin = obj.GetBoolean("is_shared_login");
            IsVerified = obj.GetBoolean("is_verified");
            // TODO: Add support for the "labels" field
            Languages = obj.GetArrayItems("languages", FacebookExperience.Parse);
            LastName = obj.GetString("last_name");
            Link = obj.GetString("link");
            Locale = obj.GetString("locale");
            Location = obj.GetObject("location", FacebookPage.Parse);
            MeetingFor = obj.GetStringArray("meeting_for");
            MiddleName = obj.GetString("middle_name");
            Name = obj.GetString("name");
            NameFormat = obj.GetString("name_format");
            // TODO: Add support for the "payment_pricepoints" field
            Political = obj.GetString("political");
            PublicKey = obj.GetString("public_key");
            Quotes = obj.GetString("quotes");
            RelationshipStatus = obj.GetString("relationship_status");
            Religion = obj.GetString("religion");
            // TODO: Add support for the "security_settings" field
            // TODO: Add support for the "shared_login_upgrade_required_by" field
            SignificantOther = obj.GetObject("significant_other", Parse);
            Sports = obj.GetArrayItems("sports", FacebookExperience.Parse);
            // TODO: Add support for the "test_group" field
            ThirdPartyId = obj.GetString("third_party_id");
            Timezone = obj.GetFloat("timezone");
            // TODO: Add support for the "token_for_business" field
            UpdatedTime = obj.GetString("updated_time", EssentialsDateTime.Parse);
            Verified = obj.GetBoolean("verified");
            // TODO: Add support for the "video_upload_limits" field
            // TODO: Add support for the "viewer_can_send_gift" field
            Website = obj.GetString("website");
            Work = obj.GetArrayItems("work", FacebookWorkExperience.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookUser"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookUser"/>.</returns>
        public static FacebookUser Parse(JObject obj) {
            return obj == null ? null : new FacebookUser(obj);
        }

        #endregion

    }

}