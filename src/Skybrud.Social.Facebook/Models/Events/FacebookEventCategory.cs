namespace Skybrud.Social.Facebook.Models.Events {
    
    /// <summary>
    /// Enum class representing the category of an event.
    /// </summary>
    public enum FacebookEventCategory {

        /// <summary>
        /// Indicates that the category of the event wasn't specified. This means that the <code>category</code> property was missing in
        /// the JSON returned by the Facebook Graph API.
        /// </summary>
        Unspecified,

        ArtEvent,
        BookEvent,
        MovieEvent,
        Fundraiser,
        Volunteering,
        FamilyEvent,
        FestivalEvent,
        Neighborhood,
        ReligiousEvent,
        Shopping,
        ComedyEvent,
        MusicEvent,
        DanceEvent,
        Nightlife,
        TheaterEvent,
        DiningEvent,
        FoodTasting,
        ConferenceEvent,
        Meetup,
        ClassEvent,
        Lecture,
        Workshop,
        Fitness,
        SportsEvent,
        Other
    }

}