using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Facebook.Constants;
using Skybrud.Social.Facebook.Models.Common;
using Skybrud.Social.Facebook.Models.Places;

namespace Skybrud.Social.Facebook.Models.Events {

    /// <summary>
    /// Class representing an event in the Facebook Graph API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.facebook.com/docs/graph-api/reference/event#read</cref>
    /// </see>
    public class FacebookEvent : FacebookObject {

        // 2014-12-27: The location of an event may be specified as either a string or an already created place.
        // According to the API documentation, the returned "venue" property will be of the type "Place", but the
        // returned data doesn't match a place. If the specified location is a string, the returned object for "venue"
        // will only contain the "name" property. If the location is specified as an already created place, the
        // returned will look similar the "location" property of a page, but also with an "id" property.
        //
        // 2017-01-14: When testing now with v2.8 of the Graph API, the "venue" property seems to have been replaced by
        // a "place" property. The location/place of an event is now returned as an object - even if only
        // the name of the location has specified.

        // 2014-12-27: Even though the Facebook API documenation specifies that an event can have a "cover" property, I
        // haven't been able to find an event where that is the case. I'm not sure whether the property isn't used
        // anymore, or whether it simply depends on the scope (which wouldn't make sense).
        //
        // 2017-01-14: This issue no longer seems to be the case (testing with v2.8).

        #region Properties

        /// <summary>
        /// Gets the ID of the event.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the number of people attending the event. Use <see cref="HasAttendingCount"/> to check whether this
        /// property was included in the response.
        /// </summary>
        public int AttendingCount { get; }

        /// <summary>
        /// Gets whether the <see cref="AttendingCount"/> property was included in the response.
        /// </summary>
        public bool HasAttendingCount => HasJsonProperty("attending_count");

        /// <summary>
        /// Gets whether guests can invite friends. Use <see cref="HasCanGuestsInvite"/> to check whether this
        /// property was included in the response.
        /// </summary>
        public bool CanGuestsInvite { get; }

        /// <summary>
        /// Gets whether the <see cref="CanGuestsInvite"/> property was included in the response.
        /// </summary>
        public bool HasCanGuestsInvite => HasJsonProperty("can_guests_invite");

        /// <summary>
        /// Gets the category of the event.
        /// </summary>
        public FacebookEventCategory Category { get; }

        /// <summary>
        /// Gets whether the category of the event was included in the response.
        /// </summary>
        public bool HasCategory => Category != FacebookEventCategory.Unspecified;

        /// <summary>
        /// Gets the cover photo of the event, or <code>null</code> if not available/specified. Requires the
        /// <see cref="FacebookEventFields.Cover"/> field.
        /// </summary>
        public FacebookCoverPhoto Cover { get; }

        /// <summary>
        /// Gets whether the event has a cover. The cover will only be included in the response if the
        /// <see cref="FacebookEventFields.Cover"/> field is requested.
        /// </summary>
        public bool HasCover => Cover != null;

        /// <summary>
        /// Gets the number of people who declined the event. Use <see cref="HasDeclinedCount"/> to check whether this
        /// property was included in the response.
        /// </summary>
        public int DeclinedCount { get; }

        /// <summary>
        /// Gets whether the <see cref="DeclinedCount"/> property was included in the response.
        /// </summary>
        public bool HasDeclinedCount => HasJsonProperty("declined_count");

        /// <summary>
        /// Gets the description of the event, or <code>null</code> if not available/specified. Use
        /// <see cref="HasDescription"/> to check whether this property was specified and included in the response.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets whether the description of the event has been specified and was included in the response.
        /// </summary>
        public bool HasDescription => !String.IsNullOrWhiteSpace(Description);

        /// <summary>
        /// Gets the end time of the event. Not all events have an end time.
        /// </summary>
        public EssentialsDateTime EndTime { get; }

        /// <summary>
        /// Gets whether an end time was specified for the event and included in the response.
        /// </summary>
        public bool HasEndTime => EndTime != null;

        /// <summary>
        /// Gets whether the guest list is visible. Use <see cref="HasGuestListEnabled"/> to check whether this
        /// property was included in the response.
        /// </summary>
        public bool GuestListEnabled { get; }

        /// <summary>
        /// Gets whether the <see cref="GuestListEnabled"/> property was included in the response.
        /// </summary>
        public bool HasGuestListEnabled => HasJsonProperty("guest_list_enabled");

        /// <summary>
        /// Gets the number of people interested in the event. Use <see cref="HasInterestedCount"/> to check whether this property was included in the response.
        /// </summary>
        public int InterestedCount { get; }

        /// <summary>
        /// Gets whether the <see cref="InterestedCount"/> property was included in the response.
        /// </summary>
        public bool HasInterestedCount => HasJsonProperty("interested_count");

        /// <summary>
        /// Gets whether the event has been marked as canceled. Use <see cref="HasIsCanceled"/> to check whether this property was included in the response.
        /// </summary>
        public bool IsCanceled { get; }

        /// <summary>
        /// Gets whether the <see cref="IsCanceled"/> property was included in the response.
        /// </summary>
        public bool HasIsCanceled => HasJsonProperty("is_canceled");

        /// <summary>
        /// Gets whether the event is created by page. Use <see cref="HasIsPageOwned"/> to check whether this property was included in the response.
        /// </summary>
        public bool IsPageOwned { get; }

        /// <summary>
        /// Gets whether the <see cref="IsPageOwned"/> property was included in the response.
        /// </summary>
        public bool HasIsPageOwned => HasJsonProperty("is_page_owned");

        /// <summary>
        /// Gets whether the event has been marked as canceled. Use <see cref="HasIsViewerAdmin"/> to check whether this property was included in the response.
        /// </summary>
        public bool IsViewerAdmin { get; }

        /// <summary>
        /// Gets whether the <see cref="IsViewerAdmin"/> property was included in the response.
        /// </summary>
        public bool HasIsViewerAdmin => HasJsonProperty("is_viewer_admin");

        /// <summary>
        /// Gets the number of people who maybe going to the event. Use <see cref="HasMaybeCount"/> to check whether this property was included in the response.
        /// </summary>
        public int MaybeCount { get; }

        /// <summary>
        /// Gets whether the <see cref="MaybeCount"/> property was included in the response.
        /// </summary>
        public bool HasMaybeCount => HasJsonProperty("maybe_count");

        /// <summary>
        /// Gets the name of the event, or <code>null</code> if not included in the response.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets whether the name of the event was included in the response.
        /// </summary>
        public bool HasName => !String.IsNullOrWhiteSpace(Name);

        /// <summary>
        /// Gets the number of people who did not reply to the event. Use <see cref="HasNoreplyCount"/> to check whether this property was included in the response.
        /// </summary>
        public int NoreplyCount { get; }

        /// <summary>
        /// Gets whether the <see cref="NoreplyCount"/> property was included in the response.
        /// </summary>
        public bool HasNoreplyCount => HasJsonProperty("noreply_count");

        /// <summary>
        /// Gets a reference to the profile that created the event, or <code>null</code> if not available.
        /// </summary>
        public FacebookEventOwner Owner { get; }

        /// <summary>
        /// Gets whether the <see cref="Owner"/> property was included in the response. The owner will only be included
        /// in the response if the <see cref="FacebookEventFields.Owner"/> field is requested.
        /// </summary>
        public bool HasOwner => Owner != null;

        // TODO: Add support for the "parent_group" property

        /// <summary>
        /// Gets a reference to the place of the event, or <code>null</code> if not available.
        /// </summary>
        public FacebookPlace Place { get; }

        /// <summary>
        /// Gets whether the <see cref="Place"/> property was specified for the event and included in the response.
        /// </summary>
        public bool HasPlace => Place != null;

        /// <summary>
        /// Gets the start time of the event.
        /// </summary>
        public EssentialsDateTime StartTime { get; }

        /// <summary>
        /// Gets whether a start time was specified for the event and included in the response.
        /// </summary>
        public bool HasStartTime => StartTime != null;

        /// <summary>
        /// Gets the link users can visit to buy a ticket to this event. Use <see cref="HasTicketUri"/> to check
        /// whether this property was specified and included in the response.
        /// </summary>
        public string TicketUri { get; }

        /// <summary>
        /// Gets whether the <see cref="TicketUri"/> property has been specified and was included in the response.
        /// </summary>
        public bool HasTicketUri => !String.IsNullOrWhiteSpace(TicketUri);

        /// <summary>
        /// Gets the timezone of the event. Use <see cref="HasTimezone"/> to check whether this property was specified
        /// and included in the response.
        /// </summary>
        public string Timezone { get; }

        /// <summary>
        /// Gets whether the <see cref="HasTimezone"/> property has been specified and was included in the response.
        /// </summary>
        public bool HasTimezone => !String.IsNullOrWhiteSpace(Timezone);

        /// <summary>
        /// Gets the type of the event. Use <see cref="HasType"/> to check whether this property was included in the
        /// response.
        /// </summary>
        public FacebookEventType Type { get; }

        /// <summary>
        /// Gets whether the <see cref="Type"/> property was included in the response.
        /// </summary>
        public bool HasType => Type != FacebookEventType.Unspecified;

        /// <summary>
        /// Gets the last time the event was updated. Use <see cref="HasUpdatedTime"/> to check whether this property
        /// was included in the response.
        /// </summary>
        public EssentialsDateTime UpdatedTime { get; }

        /// <summary>
        /// Gets whether the <see cref="UpdatedTime"/> property was included in the response.
        /// </summary>
        public bool HasUpdatedTime => UpdatedTime != null;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the event.</param>
        protected FacebookEvent(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            AttendingCount = obj.GetInt32("attending_count");
            CanGuestsInvite = obj.GetBoolean("can_guests_invite");
            Category = obj.GetEnum("category", FacebookEventCategory.Unspecified);
            Cover = obj.GetObject("cover", FacebookCoverPhoto.Parse);
            DeclinedCount = obj.GetInt32("declined_count");
            Description = obj.GetString("description");
            EndTime = obj.GetString("end_time", EssentialsDateTime.Parse);
            GuestListEnabled = obj.GetBoolean("guest_list_enabled");
            InterestedCount = obj.GetInt32("interested_count");
            IsCanceled = obj.GetBoolean("is_canceled");
            IsPageOwned = obj.GetBoolean("is_page_owned");
            IsViewerAdmin = obj.GetBoolean("is_viewer_admin");
            MaybeCount = obj.GetInt32("maybe_count");
            Name = obj.GetString("name");
            NoreplyCount = obj.GetInt32("noreply_count");
            Owner = obj.GetObject("owner", FacebookEventOwner.Parse);
            // parent_group");
            Place = obj.GetObject("place", FacebookPlace.Parse);
            StartTime = obj.GetString("start_time", EssentialsDateTime.Parse);
            TicketUri = obj.GetString("ticket_uri");
            Timezone = obj.GetString("timezone");
            Type = obj.GetEnum("type", FacebookEventType.Unspecified);
            UpdatedTime = obj.GetString("updated_time", EssentialsDateTime.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="FacebookEvent"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="FacebookEvent"/>.</returns>
        public static FacebookEvent Parse(JObject obj) {
            return obj == null ? null : new FacebookEvent(obj);
        }

        #endregion

    }

}