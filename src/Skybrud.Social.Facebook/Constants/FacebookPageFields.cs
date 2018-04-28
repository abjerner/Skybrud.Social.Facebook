using Skybrud.Social.Facebook.Fields;
using Skybrud.Social.Facebook.Models.Pages;

namespace Skybrud.Social.Facebook.Constants {

    /// <summary>
    ///  Static class with constants for the fields available for a Facebook page (<see cref="FacebookPage" />).
    ///  
    ///  The class is auto-generated and based on the fields listed in the Facebook Graph API documentation. Not all
    ///  fields may have been mapped for the implementation in Skybrud.Social.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/v2.12/page</cref>
    /// </see>
    public static class FacebookPageFields {

        #region Individial fields

        /// <summary>
        /// Page ID. No access token is required to access this field.
        /// </summary>
        public static readonly FacebookField Id = new FacebookField("id");

        /// <summary>
        /// Information about the Page.
        /// </summary>
        public static readonly FacebookField About = new FacebookField("about");

        /// <summary>
        /// The Page's access token. Only returned if the User making the request has a role (other than Live
        /// Contributor) on the Page. If your business requires two-factor authentication, the User must also be
        /// authenticated.
        /// </summary>
        public static readonly FacebookField AccessToken = new FacebookField("access_token");

        /// <summary>
        /// The Page's currently running promotion campaign.
        /// </summary>
        public static readonly FacebookField AdCampaign = new FacebookField("ad_campaign");

        /// <summary>
        /// Affiliation of this person. Applicable to Pages representing people.
        /// </summary>
        public static readonly FacebookField Affiliation = new FacebookField("affiliation");

        /// <summary>
        /// App ID for app-owned Pages and app Pages.
        /// </summary>
        public static readonly FacebookField AppId = new FacebookField("app_id");

        /// <summary>
        /// AppLinks data associated with the Page's URL.
        /// </summary>
        public static readonly FacebookField AppLinks = new FacebookField("app_links");

        /// <summary>
        /// Artists the band likes. Applicable to Bands.
        /// </summary>
        public static readonly FacebookField ArtistsWeLike = new FacebookField("artists_we_like");

        /// <summary>
        /// Dress code of the business. Applicable to Restaurants or Nightlife. Can be one of Casual, Dressy or
        /// Unspecified.
        /// </summary>
        public static readonly FacebookField Attire = new FacebookField("attire");

        /// <summary>
        /// The awards information of the film. Applicable to Films.
        /// </summary>
        public static readonly FacebookField Awards = new FacebookField("awards");

        /// <summary>
        /// Band interests. Applicable to Bands.
        /// </summary>
        public static readonly FacebookField BandInterests = new FacebookField("band_interests");

        /// <summary>
        /// Members of the band. Applicable to Bands.
        /// </summary>
        public static readonly FacebookField BandMembers = new FacebookField("band_members");

        /// <summary>
        /// The best available Page on Facebook for the concept represented by this Page. The best available Page takes
        /// into account authenticity and the number of likes.
        /// </summary>
        public static readonly FacebookField BestPage = new FacebookField("best_page");

        /// <summary>
        /// Biography of the band. Applicable to Bands.
        /// </summary>
        public static readonly FacebookField Bio = new FacebookField("bio");

        /// <summary>
        /// Birthday of this person. Applicable to Pages representing people.
        /// </summary>
        public static readonly FacebookField Birthday = new FacebookField("birthday");

        /// <summary>
        /// Booking agent of the band. Applicable to Bands.
        /// </summary>
        public static readonly FacebookField BookingAgent = new FacebookField("booking_agent");

        /// <summary>
        /// Year vehicle was built. Applicable to Vehicles.
        /// </summary>
        public static readonly FacebookField Built = new FacebookField("built");

        /// <summary>
        /// The Business associated with this Page.  Visible only with a page access token or a user access token that
        /// has admin rights on the page.
        /// </summary>
        public static readonly FacebookField Business = new FacebookField("business");

        /// <summary>
        /// Whether this page has checkin functionality enabled.
        /// </summary>
        public static readonly FacebookField CanCheckin = new FacebookField("can_checkin");

        /// <summary>
        /// Whether the current session user can post on this Page.
        /// </summary>
        public static readonly FacebookField CanPost = new FacebookField("can_post");

        /// <summary>
        /// The Page's category. e.g. Product/Service, Computers/Technology.
        /// </summary>
        public static readonly FacebookField Category = new FacebookField("category");

        /// <summary>
        /// The Page's sub-categories.
        /// </summary>
        public static readonly FacebookField CategoryList = new FacebookField("category_list");

        /// <summary>
        /// Number of checkins at a place represented by a Page.
        /// </summary>
        public static readonly FacebookField Checkins = new FacebookField("checkins");

        /// <summary>
        /// The company overview. Applicable to Companies.
        /// </summary>
        public static readonly FacebookField CompanyOverview = new FacebookField("company_overview");

        /// <summary>
        /// The mailing or contact address for this page. This field will be blank if the contact address is the same as
        /// the physical address.
        /// </summary>
        public static readonly FacebookField ContactAddress = new FacebookField("contact_address");

        /// <summary>
        /// Social context for this Page.
        /// </summary>
        public static readonly FacebookField Context = new FacebookField("context");

        /// <summary>
        /// Insight metrics that measures performance of copyright attribution. An example metric would be number of
        /// incremental followers from attribution.
        /// </summary>
        public static readonly FacebookField CopyrightAttributionInsights = new FacebookField("copyright_attribution_insights");

        /// <summary>
        /// If this is a Page in a Global Pages hierarchy, the number of people who are being directed to this Page.
        /// </summary>
        public static readonly FacebookField CountryPageLikes = new FacebookField("country_page_likes");

        /// <summary>
        /// Information about the page's cover photo.
        /// </summary>
        public static readonly FacebookField Cover = new FacebookField("cover");

        /// <summary>
        /// Culinary team of the business. Applicable to Restaurants or Nightlife.
        /// </summary>
        public static readonly FacebookField CulinaryTeam = new FacebookField("culinary_team");

        /// <summary>
        /// Current location of the Page.
        /// </summary>
        public static readonly FacebookField CurrentLocation = new FacebookField("current_location");

        /// <summary>
        /// The description of the Page.
        /// </summary>
        public static readonly FacebookField Description = new FacebookField("description");

        /// <summary>
        /// The description of the Page in raw HTML.
        /// </summary>
        public static readonly FacebookField DescriptionHtml = new FacebookField("description_html");

        /// <summary>
        /// The director of the film. Applicable to Films.
        /// </summary>
        public static readonly FacebookField DirectedBy = new FacebookField("directed_by");

        /// <summary>
        /// Subtext about the Page being viewed.
        /// </summary>
        public static readonly FacebookField DisplaySubtext = new FacebookField("display_subtext");

        /// <summary>
        /// Page estimated message response time displayed to user.
        /// </summary>
        public static readonly FacebookField DisplayedMessageResponseTime = new FacebookField("displayed_message_response_time");

        /// <summary>
        /// The emails listed in the About section of a Page.
        /// </summary>
        public static readonly FacebookField Emails = new FacebookField("emails");

        /// <summary>
        /// The social sentence and like count information for this Page. This is the same info used for the like
        /// button.
        /// </summary>
        public static readonly FacebookField Engagement = new FacebookField("engagement");

        /// <summary>
        /// The number of users who like the Page. For Global Pages this is the count for all Pages across the brand.
        /// </summary>
        public static readonly FacebookField FanCount = new FacebookField("fan_count");

        /// <summary>
        /// Video featured by the Page.
        /// </summary>
        public static readonly FacebookField FeaturedVideo = new FacebookField("featured_video");

        /// <summary>
        /// Features of the vehicle. Applicable to Vehicles.
        /// </summary>
        public static readonly FacebookField Features = new FacebookField("features");

        /// <summary>
        /// The restaurant's food styles. Applicable to Restaurants.
        /// </summary>
        public static readonly FacebookField FoodStyles = new FacebookField("food_styles");

        /// <summary>
        /// When the company was founded. Applicable to Pages in the Company category.
        /// </summary>
        public static readonly FacebookField Founded = new FacebookField("founded");

        /// <summary>
        /// General information provided by the Page.
        /// </summary>
        public static readonly FacebookField GeneralInfo = new FacebookField("general_info");

        /// <summary>
        /// General manager of the business. Applicable to Restaurants or Nightlife.
        /// </summary>
        public static readonly FacebookField GeneralManager = new FacebookField("general_manager");

        /// <summary>
        /// The genre of the film. Applicable to Films.
        /// </summary>
        public static readonly FacebookField Genre = new FacebookField("genre");

        /// <summary>
        /// The name of the Page with country codes appended for Global Pages. Only visible to the Page admin.
        /// </summary>
        public static readonly FacebookField GlobalBrandPageName = new FacebookField("global_brand_page_name");

        /// <summary>
        /// This brand's global Root ID.
        /// </summary>
        public static readonly FacebookField GlobalBrandRootId = new FacebookField("global_brand_root_id");

        /// <summary>
        /// Indicates whether this Page has added the app making the query in a Page tab.
        /// </summary>
        public static readonly FacebookField HasAddedApp = new FacebookField("has_added_app");

        /// <summary>
        /// Has whatsapp number.
        /// </summary>
        public static readonly FacebookField HasWhatsappNumber = new FacebookField("has_whatsapp_number");

        /// <summary>
        /// Hometown of the band. Applicable to Bands.
        /// </summary>
        public static readonly FacebookField Hometown = new FacebookField("hometown");

        /// <summary>
        /// Indicates a single range of opening hours for a day. Each day can have 2 different hours ranges. The keys in
        /// the map are in the form of <c>{day}_{number}_{status}</c>.  <c>{day}</c> should be the first 3 characters of
        /// the day of the week, <c>{number}</c> should be either 1 or 2 to allow for the two different hours ranges per
        /// day. <c>{status}</c> should be either <c>open</c> or <c>close</c> to delineate the start or end of a time
        /// range. An example would be <c>mon_1_open</c> with value <c>17:00</c> and <c>mon_1_close</c> with value
        /// <c>21:15</c> which would represent a single opening range of 5pm to 9:15pm on Mondays.
        /// </summary>
        public static readonly FacebookField Hours = new FacebookField("hours");

        /// <summary>
        /// Legal information about the Page publishers.
        /// </summary>
        public static readonly FacebookField Impressum = new FacebookField("impressum");

        /// <summary>
        /// Influences on the band. Applicable to Bands.
        /// </summary>
        public static readonly FacebookField Influences = new FacebookField("influences");

        /// <summary>
        /// Indicates the current Instant Articles review status for this page.
        /// </summary>
        public static readonly FacebookField InstantArticlesReviewStatus = new FacebookField("instant_articles_review_status");

        /// <summary>
        /// Indicates whether this location is always open.
        /// </summary>
        public static readonly FacebookField IsAlwaysOpen = new FacebookField("is_always_open");

        /// <summary>
        /// Indicates whether location is part of a chain.
        /// </summary>
        public static readonly FacebookField IsChain = new FacebookField("is_chain");

        /// <summary>
        /// Indicates whether the Page is a community Page.
        /// </summary>
        public static readonly FacebookField IsCommunityPage = new FacebookField("is_community_page");

        /// <summary>
        /// Indicates whether the page is eligible for the branded content tool.
        /// </summary>
        public static readonly FacebookField IsEligibleForBrandedContent = new FacebookField("is_eligible_for_branded_content");

        /// <summary>
        /// Indicates whether the page is a Messenger Platform Bot with Get Started button enabled.
        /// </summary>
        public static readonly FacebookField IsMessengerBotGetStartedEnabled = new FacebookField("is_messenger_bot_get_started_enabled");

        /// <summary>
        /// Indicates whether the page is a Messenger Platform Bot.
        /// </summary>
        public static readonly FacebookField IsMessengerPlatformBot = new FacebookField("is_messenger_platform_bot");

        /// <summary>
        /// Indicates whether page is owned.
        /// </summary>
        public static readonly FacebookField IsOwned = new FacebookField("is_owned");

        /// <summary>
        /// Whether the business corresponding to this Page is permanently closed.
        /// </summary>
        public static readonly FacebookField IsPermanentlyClosed = new FacebookField("is_permanently_closed");

        /// <summary>
        /// Indicates whether the Page is published and visible to non-admins.
        /// </summary>
        public static readonly FacebookField IsPublished = new FacebookField("is_published");

        /// <summary>
        /// Indicates whether the Page is unclaimed.
        /// </summary>
        public static readonly FacebookField IsUnclaimed = new FacebookField("is_unclaimed");

        /// <summary>
        /// Deprecated, use "verification_status". Pages with a large number of followers can be manually verified by
        /// Facebook as [having an authentic identity] (https://www.facebook.com/help/196050490547892). This field
        /// indicates whether the page is verified by this process.
        /// </summary>
        public static readonly FacebookField IsVerified = new FacebookField("is_verified");

        /// <summary>
        /// Indicates whether the application is subscribed for real time updates from this page.
        /// </summary>
        public static readonly FacebookField IsWebhooksSubscribed = new FacebookField("is_webhooks_subscribed");

        /// <summary>
        /// Deprecated. Returns null.
        /// </summary>
        public static readonly FacebookField Keywords = new FacebookField("keywords");

        /// <summary>
        /// The details needed to generate an accurate preview of a lead gen form.
        /// </summary>
        public static readonly FacebookField LeadgenFormPreviewDetails = new FacebookField("leadgen_form_preview_details");

        /// <summary>
        /// Indicates whether this page hasApp subscribes page leads realtime update.
        /// </summary>
        public static readonly FacebookField LeadgenHasCrmIntegration = new FacebookField("leadgen_has_crm_integration");

        /// <summary>
        /// Indicates whether this pagehas App that subscribes page leads realtime update via fat ping.
        /// </summary>
        public static readonly FacebookField LeadgenHasFatPingCrmIntegration = new FacebookField("leadgen_has_fat_ping_crm_integration");

        /// <summary>
        /// Indicates the time when the TOS for running LeadGen Ads on the page was accepted.
        /// </summary>
        public static readonly FacebookField LeadgenTosAcceptanceTime = new FacebookField("leadgen_tos_acceptance_time");

        /// <summary>
        /// Indicates whether a user has accepted the TOS for running LeadGen Ads on the Page.
        /// </summary>
        public static readonly FacebookField LeadgenTosAccepted = new FacebookField("leadgen_tos_accepted");

        /// <summary>
        /// Indicates the user who accepted the TOS for running LeadGen Ads on the page.
        /// </summary>
        public static readonly FacebookField LeadgenTosAcceptingUser = new FacebookField("leadgen_tos_accepting_user");

        /// <summary>
        /// The Page's Facebook URL.
        /// </summary>
        public static readonly FacebookField Link = new FacebookField("link");

        /// <summary>
        /// The location of this place. Applicable to all Places.
        /// </summary>
        public static readonly FacebookField Location = new FacebookField("location");

        /// <summary>
        /// Members of this org. Applicable to Pages representing Team Orgs.
        /// </summary>
        public static readonly FacebookField Members = new FacebookField("members");

        /// <summary>
        /// The instant workflow merchant id associated with the Page.
        /// </summary>
        public static readonly FacebookField MerchantId = new FacebookField("merchant_id");

        /// <summary>
        /// Review status of the Page against FB commerce policies, this status decides whether the Page can use
        /// component flow.
        /// </summary>
        public static readonly FacebookField MerchantReviewStatus = new FacebookField("merchant_review_status");

        /// <summary>
        /// The default ice breakers for a certain page.
        /// </summary>
        public static readonly FacebookField MessengerAdsDefaultIcebreakers = new FacebookField("messenger_ads_default_icebreakers");

        /// <summary>
        /// The default page welcome message for Click to Messenger Ads.
        /// </summary>
        public static readonly FacebookField MessengerAdsDefaultPageWelcomeMessage = new FacebookField("messenger_ads_default_page_welcome_message");

        /// <summary>
        /// The default quick replies for a certain page.
        /// </summary>
        public static readonly FacebookField MessengerAdsDefaultQuickReplies = new FacebookField("messenger_ads_default_quick_replies");

        /// <summary>
        /// Indicates what type this page is and we will generate different sets of quick replies based on it.
        /// </summary>
        public static readonly FacebookField MessengerAdsQuickRepliesType = new FacebookField("messenger_ads_quick_replies_type");

        /// <summary>
        /// The company mission. Applicable to Companies.
        /// </summary>
        public static readonly FacebookField Mission = new FacebookField("mission");

        /// <summary>
        /// MPG of the vehicle. Applicable to Vehicles.
        /// </summary>
        public static readonly FacebookField Mpg = new FacebookField("mpg");

        /// <summary>
        /// The name of the Page.
        /// </summary>
        public static readonly FacebookField Name = new FacebookField("name");

        /// <summary>
        /// The name of the Page with its location and/or global brand descriptor. Only visible to a page admin.
        /// Non-page admins will get the same value as <c>name</c>.
        /// </summary>
        public static readonly FacebookField NameWithLocationDescriptor = new FacebookField("name_with_location_descriptor");

        /// <summary>
        /// The TV network for the TV show. Applicable to TV Shows.
        /// </summary>
        public static readonly FacebookField Network = new FacebookField("network");

        /// <summary>
        /// The number of people who have liked the Page, since the last login. Only visible to a page admin.
        /// </summary>
        public static readonly FacebookField NewLikeCount = new FacebookField("new_like_count");

        /// <summary>
        /// Offer eligibility status. Only visible to a page admin.
        /// </summary>
        public static readonly FacebookField OfferEligible = new FacebookField("offer_eligible");

        /// <summary>
        /// Overall page rating based on rating survey from users on a scale of 1-5. This value is normalized and is not
        /// guaranteed to be a strict average of user ratings.
        /// </summary>
        public static readonly FacebookField OverallStarRating = new FacebookField("overall_star_rating");

        /// <summary>
        /// Page token.
        /// </summary>
        public static readonly FacebookField PageToken = new FacebookField("page_token");

        /// <summary>
        /// Parent Page for this Page.
        /// </summary>
        public static readonly FacebookField ParentPage = new FacebookField("parent_page");

        /// <summary>
        /// Parking information. Applicable to Businesses and Places.
        /// </summary>
        public static readonly FacebookField Parking = new FacebookField("parking");

        /// <summary>
        /// Payment options accepted by the business. Applicable to Restaurants or Nightlife.
        /// </summary>
        public static readonly FacebookField PaymentOptions = new FacebookField("payment_options");

        /// <summary>
        /// Personal information. Applicable to Pages representing People.
        /// </summary>
        public static readonly FacebookField PersonalInfo = new FacebookField("personal_info");

        /// <summary>
        /// Personal interests. Applicable to Pages representing People.
        /// </summary>
        public static readonly FacebookField PersonalInterests = new FacebookField("personal_interests");

        /// <summary>
        /// Pharmacy safety information. Applicable to Pharmaceutical companies.
        /// </summary>
        public static readonly FacebookField PharmaSafetyInfo = new FacebookField("pharma_safety_info");

        /// <summary>
        /// Phone number provided by a Page.
        /// </summary>
        public static readonly FacebookField Phone = new FacebookField("phone");

        /// <summary>
        /// For places, the category of the place.
        /// </summary>
        public static readonly FacebookField PlaceType = new FacebookField("place_type");

        /// <summary>
        /// The plot outline of the film. Applicable to Films.
        /// </summary>
        public static readonly FacebookField PlotOutline = new FacebookField("plot_outline");

        /// <summary>
        /// Group of tags describing the preferred audienceof ads created for the Page.
        /// </summary>
        public static readonly FacebookField PreferredAudience = new FacebookField("preferred_audience");

        /// <summary>
        /// Press contact information of the band. Applicable to Bands.
        /// </summary>
        public static readonly FacebookField PressContact = new FacebookField("press_contact");

        /// <summary>
        /// Price range of the business. Applicable to Restaurants or Nightlife. Can be one of <c>$</c>, <c>$$</c>,
        /// <c>$$$</c>, <c>$$$$</c> or <c>Unspecified</c>.
        /// </summary>
        public static readonly FacebookField PriceRange = new FacebookField("price_range");

        /// <summary>
        /// The productor of the film. Applicable to Films.
        /// </summary>
        public static readonly FacebookField ProducedBy = new FacebookField("produced_by");

        /// <summary>
        /// The products of this company. Applicable to Companies.
        /// </summary>
        public static readonly FacebookField Products = new FacebookField("products");

        /// <summary>
        /// Boosted posts eligibility status. Only visible to a page admin.
        /// </summary>
        public static readonly FacebookField PromotionEligible = new FacebookField("promotion_eligible");

        /// <summary>
        /// Reason for which boosted posts are not eligible. Only visible to a page admin.
        /// </summary>
        public static readonly FacebookField PromotionIneligibleReason = new FacebookField("promotion_ineligible_reason");

        /// <summary>
        /// Public transit to the business. Applicable to Restaurants or Nightlife.
        /// </summary>
        public static readonly FacebookField PublicTransit = new FacebookField("public_transit");

        /// <summary>
        /// Publisher Space for the page.
        /// </summary>
        public static readonly FacebookField PublisherSpace = new FacebookField("publisher_space");

        /// <summary>
        /// Number of ratings for the page.
        /// </summary>
        public static readonly FacebookField RatingCount = new FacebookField("rating_count");

        /// <summary>
        /// Messenger page scope id associated with page and a user using account_linking_token.
        /// </summary>
        public static readonly FacebookField Recipient = new FacebookField("recipient");

        /// <summary>
        /// Record label of the band. Applicable to Bands.
        /// </summary>
        public static readonly FacebookField RecordLabel = new FacebookField("record_label");

        /// <summary>
        /// The film's release date. Applicable to Films.
        /// </summary>
        public static readonly FacebookField ReleaseDate = new FacebookField("release_date");

        /// <summary>
        /// Services the restaurant provides. Applicable to Restaurants.
        /// </summary>
        public static readonly FacebookField RestaurantServices = new FacebookField("restaurant_services");

        /// <summary>
        /// The restaurant's specialties. Applicable to Restaurants.
        /// </summary>
        public static readonly FacebookField RestaurantSpecialties = new FacebookField("restaurant_specialties");

        /// <summary>
        /// The air schedule of the TV show. Applicable to TV Shows.
        /// </summary>
        public static readonly FacebookField Schedule = new FacebookField("schedule");

        /// <summary>
        /// The screenwriter of the film. Applicable to Films.
        /// </summary>
        public static readonly FacebookField ScreenplayBy = new FacebookField("screenplay_by");

        /// <summary>
        /// The season information of the TV Show. Applicable to TV Shows.
        /// </summary>
        public static readonly FacebookField Season = new FacebookField("season");

        /// <summary>
        /// The page address, if any, in a simple single line format.
        /// </summary>
        public static readonly FacebookField SingleLineAddress = new FacebookField("single_line_address");

        /// <summary>
        /// The cast of the film. Applicable to Films.
        /// </summary>
        public static readonly FacebookField Starring = new FacebookField("starring");

        /// <summary>
        /// Information about when the entity represented by the Page was started.
        /// </summary>
        public static readonly FacebookField StartInfo = new FacebookField("start_info");

        /// <summary>
        /// Location Page's store location descriptor.
        /// </summary>
        public static readonly FacebookField StoreLocationDescriptor = new FacebookField("store_location_descriptor");

        /// <summary>
        /// Unique store number for this location Page.
        /// </summary>
        public static readonly FacebookField StoreNumber = new FacebookField("store_number");

        /// <summary>
        /// The studio for the film production. Applicable to Films.
        /// </summary>
        public static readonly FacebookField Studio = new FacebookField("studio");

        /// <summary>
        /// Indicates whether this Page supports Instant Articles.
        /// </summary>
        public static readonly FacebookField SupportsInstantArticles = new FacebookField("supports_instant_articles");

        /// <summary>
        /// The number of people talking about this Page.
        /// </summary>
        public static readonly FacebookField TalkingAboutCount = new FacebookField("talking_about_count");

        /// <summary>
        /// Unread message count for the Page. Only visible to a page admin.
        /// </summary>
        public static readonly FacebookField UnreadMessageCount = new FacebookField("unread_message_count");

        /// <summary>
        /// Number of unread notifications. Only visible to a page admin.
        /// </summary>
        public static readonly FacebookField UnreadNotifCount = new FacebookField("unread_notif_count");

        /// <summary>
        /// Unseen message count for the Page. Only visible to a page admin.
        /// </summary>
        public static readonly FacebookField UnseenMessageCount = new FacebookField("unseen_message_count");

        /// <summary>
        /// The alias of the Page. For example, for www.facebook.com/platform the username is 'platform'.
        /// </summary>
        public static readonly FacebookField Username = new FacebookField("username");

        /// <summary>
        /// Showing whether this Page is verified and in what color e.g. blue verified, gray verified or not verified.
        /// </summary>
        public static readonly FacebookField VerificationStatus = new FacebookField("verification_status");

        /// <summary>
        /// Voip info.
        /// </summary>
        public static readonly FacebookField VoipInfo = new FacebookField("voip_info");

        /// <summary>
        /// The URL of the Page's website.
        /// </summary>
        public static readonly FacebookField Website = new FacebookField("website");

        /// <summary>
        /// The number of visits to this Page's location. If the Page setting <em>Show map, check-ins and star ratings
        /// on the Page</em> (under <em>Page Settings > Page Info > Address</em>) is disabled, then this value will also
        /// be disabled.
        /// </summary>
        public static readonly FacebookField WereHereCount = new FacebookField("were_here_count");

        /// <summary>
        /// Whatsapp number.
        /// </summary>
        public static readonly FacebookField WhatsappNumber = new FacebookField("whatsapp_number");

        /// <summary>
        /// The writer of the TV show. Applicable to TV Shows.
        /// </summary>
        public static readonly FacebookField WrittenBy = new FacebookField("written_by");

        #endregion

        /// <summary>
        /// Gets an array of all known fields available for a Facebook page.
        /// </summary>
        public static readonly FacebookField[] All = {
            Id, About, AccessToken, AdCampaign, Affiliation, AppId, AppLinks, ArtistsWeLike, Attire, Awards, BandInterests,
            BandMembers, BestPage, Bio, Birthday, BookingAgent, Built, Business, CanCheckin, CanPost, Category, CategoryList,
            Checkins, CompanyOverview, ContactAddress, Context, CopyrightAttributionInsights, CountryPageLikes, Cover, CulinaryTeam,
            CurrentLocation, Description, DescriptionHtml, DirectedBy, DisplaySubtext, DisplayedMessageResponseTime, Emails,
            Engagement, FanCount, FeaturedVideo, Features, FoodStyles, Founded, GeneralInfo, GeneralManager, Genre, GlobalBrandPageName,
            GlobalBrandRootId, HasAddedApp, HasWhatsappNumber, Hometown, Hours, Impressum, Influences, InstantArticlesReviewStatus,
            IsAlwaysOpen, IsChain, IsCommunityPage, IsEligibleForBrandedContent, IsMessengerBotGetStartedEnabled, IsMessengerPlatformBot,
            IsOwned, IsPermanentlyClosed, IsPublished, IsUnclaimed, IsVerified, IsWebhooksSubscribed, Keywords, LeadgenFormPreviewDetails,
            LeadgenHasCrmIntegration, LeadgenHasFatPingCrmIntegration, LeadgenTosAcceptanceTime, LeadgenTosAccepted, LeadgenTosAcceptingUser,
            Link, Location, Members, MerchantId, MerchantReviewStatus, MessengerAdsDefaultIcebreakers, MessengerAdsDefaultPageWelcomeMessage,
            MessengerAdsDefaultQuickReplies, MessengerAdsQuickRepliesType, Mission, Mpg, Name, NameWithLocationDescriptor,
            Network, NewLikeCount, OfferEligible, OverallStarRating, PageToken, ParentPage, Parking, PaymentOptions, PersonalInfo,
            PersonalInterests, PharmaSafetyInfo, Phone, PlaceType, PlotOutline, PreferredAudience, PressContact, PriceRange,
            ProducedBy, Products, PromotionEligible, PromotionIneligibleReason, PublicTransit, PublisherSpace, RatingCount,
            Recipient, RecordLabel, ReleaseDate, RestaurantServices, RestaurantSpecialties, Schedule, ScreenplayBy, Season,
            SingleLineAddress, Starring, StartInfo, StoreLocationDescriptor, StoreNumber, Studio, SupportsInstantArticles,
            TalkingAboutCount, UnreadMessageCount, UnreadNotifCount, UnseenMessageCount, Username, VerificationStatus, VoipInfo,
            Website, WereHereCount, WhatsappNumber, WrittenBy
        };

    }

}