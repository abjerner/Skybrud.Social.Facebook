using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Newtonsoft.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Extensions;
using Skybrud.Social.Facebook.Models.Common;

namespace Skybrud.Social.Facebook.Models.Pages {

    /// <summary>
    /// Class representing a Facebook page.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.8/page#Reading</cref>
    /// </see>
    public class FacebookPage : FacebookObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the page.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets information about the page.
        /// </summary>
        public string? About { get; }

        /// <summary>
        /// Gets or sets the access token you can use to act as the Page. Only visible to Page Admins. If your business requires two-factor authentication, and the person hasn't authenticated, this field may not be returned.
        /// </summary>
        public string? AccessToken { get; }

        // TODO: Add support for the "ad_campaign" field

        /// <summary>
        /// Gets the affiliation of this person. Applicable to pages representing people.
        /// </summary>
        public string? Affiliation { get; }

        // TODO: Add support for the "app_id" field (applies to app-owned pages)

        // TODO: Add support for the "app_links" field (applies to app-owned pages)

        /// <summary>
        /// Gets a list of artists the band likes. Applicable to <strong>Bands</strong>.
        /// </summary>
        public string? ArtistsWeLike { get; }

        /// <summary>
        /// Gets the dress code of the business. Applicable to <strong>Restaurants</strong> or
        /// <strong>Nightlife</strong>. Can be one of <see cref="FacebookPageAttire.Casual"/>,
        /// <see cref="FacebookPageAttire.Dressy"/> or <see cref="FacebookPageAttire.Unknown"/>.
        /// </summary>
        public FacebookPageAttire? Attire { get; }

        /// <summary>
        /// Gets the awards information of the film. Applicable to <strong>Films</strong>.
        /// </summary>
        public string? Awards { get; }

        /// <summary>
        /// Gets the interests of the band.
        /// </summary>
        public string? BandInterests { get; }

        /// <summary>
        /// Gets the members of the band.
        /// </summary>
        public string? BandMembers { get; }

        // TODO: Add support for the "best_page" field

        /// <summary>
        /// Gets the biography of the band. Applicable to <strong>Bands</strong>.
        /// </summary>
        public string? Bio { get; }

        /// <summary>
        /// Gets the birthday of this person. Applicable to pages representing people.
        /// </summary>
        public EssentialsDate? Birthday { get; }

        /// <summary>
        /// Gets the booking agent of the band. Applicable to <strong>Bands</strong>.
        /// </summary>
        public string? BookingAgent { get; }

        /// <summary>
        /// Gets the year the vehicle was built. Applicable to <strong>Vehicles</strong>.
        /// </summary>
        public string? Built { get; }

        // TODO: Add support for the "business" field

        /// <summary>
        /// Gets whether this page has checkin functionality enabled.
        /// </summary>
        public bool? CanCheckin { get; }

        /// <summary>
        /// Gets whether the authenticated user can post to the page.
        /// </summary>
        public bool? CanPost { get; }

        /// <summary>
        /// Gets the main category of the page.
        /// </summary>
        public string? Category { get; }

        /// <summary>
        /// Gets a list of all sub categories.
        /// </summary>
        public IReadOnlyList<FacebookPageCategory>? CategoryList { get; }

        /// <summary>
        /// Gets the number of checkins at a place represented by the page.
        /// </summary>
        public int? Checkins { get; }

        /// <summary>
        /// Gets the company overview. Applicable to <strong>Companies</strong>.
        /// </summary>
        public string? CompanyOverview { get; }

        // TODO: Add support for the "contact_address" field

        // TODO: Add support for the "context" field

        // TODO: Add support for the "country_page_likes" field

        /// <summary>
        /// Gets information about the cover photo of the page.
        /// </summary>
        public FacebookCoverPhoto? Cover { get; }

        /// <summary>
        /// Gets the culinary team of the business. Applicable to <strong>Restaurants</strong> or <strong>Nightlife</strong>.
        /// </summary>
        public string? CulinaryTeam { get; }

        /// <summary>
        /// Gets the current location of the page.
        /// </summary>
        public string? CurrentLocation { get; }

        /// <summary>
        /// Gets the description of the page.
        /// </summary>
        public string? Description { get; }

        /// <summary>
        /// Gets the description of the page in raw HTML.
        /// </summary>
        public string? DescriptionHtml { get; }

        /// <summary>
        /// Gets the director of the film. Applicable to <strong>Films</strong>.
        /// </summary>
        public string? DirectedBy { get; }

        // TODO: Add support for the "display_subtext" field

        // TODO: Add support for the "displayed_message_response_time" field

        /// <summary>
        /// Gets an array with the emails listed in the about section of the page.
        /// </summary>
        public IReadOnlyList<string>? Emails { get; }

        // TODO: Add support for the "engagement" field

        /// <summary>
        /// Gets the number of users who like the page. For <strong>Global Pages</strong> this is the count for all pages across the brand.
        /// </summary>
        public int? FanCount { get; }

        // TODO: Add support for the "fan_count" field

        // TODO: Add support for the "featured_video" field

        /// <summary>
        /// Gets an array with the features of the vehicle. Applicable to <strong>Vehicles</strong>.
        /// </summary>
        public string? Features { get; }

        /// <summary>
        /// Gets the restaurant's food styles. Applicable to <strong>Restaurants</strong>.
        /// </summary>
        public IReadOnlyList<string>? FoodStyles { get; }

        /// <summary>
        /// Gets when the company was founded. Applicable to <strong>Companies</strong>.
        /// </summary>
        public string? Founded { get; }

        /// <summary>
        /// General information provided by the page.
        /// </summary>
        public string? GeneralInfo { get; }

        /// <summary>
        /// Gets the general manager of the business. Applicable to <strong>Restaurants</strong> or
        /// <strong>Nightlife</strong>.
        /// </summary>
        public string? GeneralManager { get; }

        /// <summary>
        /// Gets the genre of the film. Applicable to <strong>Films</strong>.
        /// </summary>
        public string? Genre { get; }

        // TODO: Add support for the "global_brand_page_name" field

        // TODO: Add support for the "global_brand_root_id" field

        // TODO: Add support for the "has_added_app" field

        /// <summary>
        /// Gets the hometown of the band. Applicable to <strong>Bands</strong>.
        /// </summary>
        public string? Hometown { get; }

        /// <summary>
        /// Gets the opening hours for the page.
        /// </summary>
        public FacebookPageOpeningHours? Hours { get; }

        /// <summary>
        /// Gets the legal information about the page publishers.
        /// </summary>
        public string? Impressum { get; }

        /// <summary>
        /// Gets the influences on the band. Applicable to <strong>Bands</strong>.
        /// </summary>
        public string? Influences { get; }

        // TODO: Add support for the "instant_articles_review_status" field

        /// <summary>
        /// Gets whether this location is always open.
        /// </summary>
        public bool? IsAlwaysOpen { get; }

        /// <summary>
        /// Gets whether the page is a community page.
        /// </summary>
        public bool? IsCommunityPage { get; }

        /// <summary>
        /// For businesses that are no longer operating.
        /// </summary>
        public bool? IsPermantlyClosed { get; }

        /// <summary>
        /// Gets whether the page is published and visible to non-admins.
        /// </summary>
        public bool? IsPublished { get; }

        /// <summary>
        /// Gets whether the page is unclaimed.
        /// </summary>
        public bool? IsUnclaimed { get; }

        /// <summary>
        /// Pages with a large number of followers can be manually verified by Facebook as having an authentic
        /// identity. This property indicates whether the page is verified by this process.
        /// </summary>
        public bool? IsVerified { get; }

        // TODO: Add support for the "is_webhooks_subscribed" field

        // TODO: Add support for the "leadgen_form_preview_details" field

        // TODO: Add support for the "leadgen_tos_acceptance_time" field

        // TODO: Add support for the "leadgen_tos_accepted" field

        // TODO: Add support for the "leadgen_tos_accepting_user" field

        /// <summary>
        /// Gets the Facebook URL of the page.
        /// </summary>
        public string? Link { get; }

        /// <summary>
        /// Gets the location of the place. Applicable to all <strong>Places</strong>.
        /// </summary>
        public FacebookLocation? Location { get; }

        /// <summary>
        /// Gets the members of this org. Applicable to pages representing <strong>Team Orgs</strong>.
        /// </summary>
        public string? Members { get; }

        // TODO: Add support for the "merchant_id" field

        // TODO: Add support for the "merchant_review_status" field

        /// <summary>
        /// Gets the company mission. Applicable to <strong>Companies</strong>.
        /// </summary>
        public string? Mission { get; }

        /// <summary>
        /// Gets the MPG of the vehicle. Applicable to <strong>Vehicles</strong>.
        /// </summary>
        public string? Mpg { get; }

        /// <summary>
        /// Gets the name of the page.
        /// </summary>
        public string? Name { get; }

        /// <summary>
        /// Gets the name of the page with its location and/or global brand descriptor.
        /// </summary>
        public string? NameWithLocationDescriptor { get; }

        /// <summary>
        /// Gets the TV network for the TV show. Applicable to <strong>TV Shows</strong>.
        /// </summary>
        public string? Network { get; }

        /// <summary>
        /// Gets the number of people who have liked the page, since the last login. Only visible to a page admin.
        /// </summary>
        public int? NewLikeCount { get; }

        // TODO: Add support for the "offer_eligible" field

        /// <summary>
        /// Gets the Overall page rating based on rating survey from users on a scale of 1-5. This value is normalized
        /// and is not guaranteed to be a strict average of user ratings.
        /// </summary>
        public float? OverallStarRating { get; }

        /// <summary>
        /// Gets the parent page for this page.
        /// </summary>
        public FacebookPage? ParentPage { get; }

        /// <summary>
        /// Gets information about the parking available at a place.
        /// </summary>
        public FacebookPageParking? Parking { get; }

        /// <summary>
        /// Gets information about the available payment options at a place.
        /// </summary>
        public FacebookPagePaymentOptions? PaymentOptions { get; }

        /// <summary>
        /// Gets the personal information. Applicable to pages representing people.
        /// </summary>
        public string? PersonalInfo { get; }

        /// <summary>
        /// Gets the personal interests. Applicable to pages representing people.
        /// </summary>
        public string? PersonalInterests { get; }

        /// <summary>
        /// Gets pharmacy safety information. Applicable to pharmaceutical companies.
        /// </summary>
        public string? PharmaSafetyInfo { get; }

        /// <summary>
        /// Gets the phone number provided by a page.
        /// </summary>
        public string? Phone { get; }

        /// <summary>
        /// For places, the category of the place.
        /// </summary>
        public string? PlaceType { get; }

        /// <summary>
        /// Gets the plot outline of the film. Applicable to <strong>Films</strong>.
        /// </summary>
        public string? PlotOutline { get; }

        // TODO: Add support for the "preferred_audience" field

        /// <summary>
        /// Gets the press contact information of the band. Applicable to <strong>Bands</strong>.
        /// </summary>
        public string? PressContact { get; }

        /// <summary>
        /// Price range of the business. Applicable to <strong>Restaurants</strong> or <strong>Nightlife</strong>.
        /// </summary>
        public string? PriceRange { get; }

        /// <summary>
        /// Gets the productor of the film. Applicable to <strong>Films</strong>.
        /// </summary>
        public string? ProducedBy { get; }

        /// <summary>
        /// Gets the products of this company. Applicable to <strong>Companies</strong>.
        /// </summary>
        public string? Products { get; }

        /// <summary>
        /// Gets whether the page is eligible for promotion.
        /// </summary>
        public bool? PromotionEligible { get; }

        /// <summary>
        /// Gets the reason, for which boosted posts are not eligible. Only visible to a page admin.
        /// </summary>
        public string? PromotionIneligibleReason { get; }

        /// <summary>
        /// Gets information about public transit to the business. Applicable to <strong>Restaurants</strong> or <strong>Nightlife</strong>.
        /// </summary>
        public string? PublicTransit { get; }

        /// <summary>
        /// Gets the number of ratings for the page.
        /// </summary>
        public int? RatingCount { get; }

        // TODO: Add support for the "recipient" field

        /// <summary>
        /// Gets the record label of the band. Applicable to <strong>Bands</strong>.
        /// </summary>
        public string? RecordLabel { get; }

        /// <summary>
        /// Gets the film's release date. Applicable to <strong>Films</strong>.
        /// </summary>
        public string? ReleaseDate { get; }

        /// <summary>
        /// Services the restaurant provides. Applicable to <strong>Restaurants</strong>.
        /// </summary>
        public FacebookPageRestaurantServices? RestaurantServices { get; }

        /// <summary>
        /// The restaurant's specialties. Applicable to <strong>Restaurants</strong>.
        /// </summary>
        public FacebookPageRestaurantSpecialties? RestaurantSpecialties { get; }

        /// <summary>
        /// Gets the air schedule of the TV show. Applicable to <strong>TV Shows</strong>.
        /// </summary>
        public string? Schedule { get; }

        /// <summary>
        /// Gets the screenwriter of the film. Applicable to <strong>Films</strong>.
        /// </summary>
        public string? ScreenplayBy { get; }

        /// <summary>
        /// Gets the season information of the TV Show. Applicable to <strong>TV Shows</strong>.
        /// </summary>
        public string? Season { get; }

        /// <summary>
        /// Gets the page address, if any, in a simple single line format.
        /// </summary>
        public string? SingleLineAddress { get; }

        /// <summary>
        /// Gets the cast of the film. Applicable to <strong>Films</strong>.
        /// </summary>
        public string? Starring { get; }

        // TODO: Add support for the "start_info" field

        /// <summary>
        /// Gets the location page's store location descriptor.
        /// </summary>
        public string? StoreLocationDescriptor { get; }

        /// <summary>
        /// Gets the unique store number for this location page.
        /// </summary>
        public int? StoreNumber { get; }

        /// <summary>
        /// Gets the studio for the film production. Applicable to <strong>Films</strong>.
        /// </summary>
        public string? Studio { get; }

        // TODO: Add support for the "supports_instant_articles" field

        /// <summary>
        /// Gets the number of people talking about the page.
        /// </summary>
        public int? TalkingAboutCount { get; }

        // TODO: Add support for the "unread_message_count" field

        // TODO: Add support for the "unread_notif_count" field

        // TODO: Add support for the "unseen_message_count" field

        /// <summary>
        /// Gets the alias of the page. For example, for www.facebook.com/platform the username is <c>platform</c>.
        /// </summary>
        public string? Username { get; }

        /// <summary>
        /// Gets the URL to the website of the page.
        /// </summary>
        public string? Website { get; }

        /// <summary>
        /// Gets whether this page is verified and in what color e.g. <see cref="FacebookPageVerificationStatus.BlueVerified"/>,
        /// <see cref="FacebookPageVerificationStatus.GreyVerified"/> or <see cref="FacebookPageVerificationStatus.NotVerified"/>.
        /// </summary>
        public FacebookPageVerificationStatus? VerificationStatus { get; }

        // TODO: Add support for the "voip_info" field

        /// <summary>
        /// Gets the number of visits to location of the page.
        /// </summary>
        public int? WereHereCount { get; }

        /// <summary>
        /// Gets the writer of the TV show. Applicable to <strong>TV Shows</strong>.
        /// </summary>
        public string? WrittenBy { get; }

        #endregion

        #region Constructors

        private FacebookPage(JObject json) : base(json) {
            Id = json.GetString("id")!;
            About = json.GetString("about");
            AccessToken = json.GetString("access_token");
            // TODO: Add support for the "ad_campaign" field
            Affiliation = json.GetString("affiliation");
            // TODO: Add support for the "app_id" field
            // TODO: Add support for the "app_links" field
            ArtistsWeLike = json.GetString("artists_we_like");
            Attire = json.GetString("attire", ParseEnumOrDefault<FacebookPageAttire>);
            Awards = json.GetString("awards");
            BandInterests = json.GetString("band_interests");
            BandMembers = json.GetString("band_members");
            // TODO: Add support for the "best_page" field
            Bio = json.GetString("bio");
            Birthday = json.GetString("birthday", ParseBirthday);
            BookingAgent = json.GetString("booking_agent");
            Built = json.GetString("built");
            // TODO: Add support for the "business" field
            CanCheckin = json.GetBooleanOrNull("can_checkin");
            CanPost = json.GetBooleanOrNull("can_post");
            Category = json.GetString("category");
            CategoryList = json.GetArray("category_list", FacebookPageCategory.Parse);
            Checkins = json.GetInt32OrNull("checkins");
            CompanyOverview = json.GetString("company_overview");
            // TODO: Add support for the "contact_address" field
            // TODO: Add support for the "context" field
            // TODO: Add support for the "country_page_likes" field
            Cover = json.GetObject("cover", FacebookCoverPhoto.Parse);
            CulinaryTeam = json.GetString("culinary_team");
            CurrentLocation = json.GetString("current_location");
            Description = json.GetString("description");
            DescriptionHtml = json.GetString("description_html");
            DirectedBy = json.GetString("directed_by");
            // TODO: Add support for the "display_subtext" field
            // TODO: Add support for the "displayed_message_response_time" field
            Emails = json.GetStringArrayOrNull("emails");
            // TODO: Add support for the "engagement" field
            FanCount = json.GetInt32OrNull("fan_count");
            // TODO: Add support for the "featured_video" field
            Features = json.GetString("features");
            FoodStyles = json.GetStringArrayOrNull("food_styles");
            Founded = json.GetString("founded");
            GeneralInfo = json.GetString("general_info");
            GeneralManager = json.GetString("general_manager");
            Genre = json.GetString("genre");
            // TODO: Add support for the "global_brand_page_name" field
            // TODO: Add support for the "global_brand_root_id" field
            // TODO: Add support for the "has_added_app" field
            Hometown = json.GetString("hometown");
            Hours = json.GetObject("hours", FacebookPageOpeningHours.Parse);
            Impressum = json.GetString("impressum");
            Influences = json.GetString("influences");
            // TODO: Add support for the "instant_articles_review_status" field
            IsAlwaysOpen = json.GetBooleanOrNull("is_always_open");
            IsCommunityPage = json.GetBooleanOrNull("is_community_page");
            IsPermantlyClosed = json.GetBooleanOrNull("is_permanently_closed");
            IsPublished = json.GetBooleanOrNull("is_published");
            IsUnclaimed = json.GetBooleanOrNull("is_unclaimed");
            IsVerified = json.GetBooleanOrNull("is_verified");
            // TODO: Add support for the "is_webhooks_subscribed" field
            // TODO: Add support for the "leadgen_form_preview_details" field
            // TODO: Add support for the "leadgen_tos_acceptance_time" field
            // TODO: Add support for the "leadgen_tos_accepted" field
            // TODO: Add support for the "leadgen_tos_accepting_user" field
            Link = json.GetString("link");
            Location = json.GetObject("location", FacebookLocation.Parse);
            Members = json.GetString("members");
            // TODO: Add support for the "merchant_id" field
            // TODO: Add support for the "merchant_review_status" field
            Mission = json.GetString("mission");
            Mpg = json.GetString("mpg");
            Name = json.GetString("name");
            NameWithLocationDescriptor = json.GetString("name_with_location_descriptor");
            Network = json.GetString("network");
            NewLikeCount = json.GetInt32OrNull("new_like_count");
            // TODO: Add support for the "offer_eligible" field
            OverallStarRating = json.GetFloatOrNull("overall_star_rating");
            ParentPage = json.GetObject("parent_page", Parse);
            Parking = json.GetObject("parking", FacebookPageParking.Parse);
            PaymentOptions = json.GetObject("payment_options", FacebookPagePaymentOptions.Parse);
            PersonalInfo = json.GetString("personal_info");
            PersonalInterests = json.GetString("personal_interests");
            PharmaSafetyInfo = json.GetString("pharma_safety_info");
            Phone = json.GetString("phone");
            PlaceType = json.GetString("place_type");
            PlotOutline = json.GetString("plot_outline");
            // TODO: Add support for the "preferred_audience" field
            PressContact = json.GetString("press_contact");
            PriceRange = json.GetString("price_range");
            ProducedBy = json.GetString("produced_by");
            Products = json.GetString("products");
            PromotionEligible = json.GetBooleanOrNull("promotion_eligible");
            PromotionIneligibleReason = json.GetString("promotion_ineligible_reason");
            PublicTransit = json.GetString("public_transit");
            // TODO: Add support for the "publisher_space" field
            RatingCount = json.GetInt32OrNull("rating_count");
            // TODO: Add support for the "recipient" field
            RecordLabel = json.GetString("record_label");
            PriceRange = json.GetString("price_range");
            ReleaseDate = json.GetString("release_date");
            RestaurantServices = json.GetObject("restaurant_services", FacebookPageRestaurantServices.Parse);
            RestaurantSpecialties = json.GetObject("restaurant_specialties", FacebookPageRestaurantSpecialties.Parse);
            Schedule = json.GetString("schedule");
            ScreenplayBy = json.GetString("screenplay_by");
            Season = json.GetString("season");
            SingleLineAddress = json.GetString("single_line_address");
            Starring = json.GetString("starring");
            // TODO: Add support for the "start_info" field
            StoreLocationDescriptor = json.GetString("store_location_descriptor");
            StoreNumber = json.GetInt32OrNull("store_number");
            Studio = json.GetString("studio");
            // TODO: Add support for the "supports_instant_articles" field
            TalkingAboutCount = json.GetInt32OrNull("talking_about_count");
            // TODO: Add support for the "unread_message_count" field
            // TODO: Add support for the "unread_notif_count" field
            // TODO: Add support for the "unseen_message_count" field
            Username = json.GetString("username");
            VerificationStatus = json.GetEnumOrDefault<FacebookPageVerificationStatus>("verification_status");
            // TODO: Add support for the "voip_info" field
            Website = json.GetString("website");
            WereHereCount = json.GetInt32OrNull("were_here_count");
            WrittenBy = json.GetString("written_by");
        }

        #endregion

        #region Static methods

        private static EssentialsDate? ParseBirthday(string str) {
            return string.IsNullOrWhiteSpace(str) ? null : new EssentialsDate(DateTime.ParseExact(str, "MM/dd/yyyy", CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Parses the specified <paramref name="json"/> object into an instance of <see cref="FacebookPage"/>.
        /// </summary>
        /// <param name="json">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookPage"/>.</returns>
        [return: NotNullIfNotNull("json")]
        public static FacebookPage? Parse(JObject? json) {
            return json == null ? null : new FacebookPage(json);
        }

        #endregion

    }

}