using System;
using System.Collections.Generic;

namespace exercise1.models
{
    public class EmailList
    {
        public string Id { get; set; }
        public int WebId { get; set; }
        public string Name { get; set; }
        public Contact Contact { get; set; }
        public string PermissionReminder { get; set; }
        public bool UseArchiveBar { get; set; }
        public CampaignDefaults CampaignDefaults { get; set; }
        public string NotifyOnSubscribe { get; set; }
        public string NotifyOnUnsubscribe { get; set; }
        public DateTime DateCreated { get; set; }
        public int ListRating { get; set; }
        public bool EmailTypeOption { get; set; }
        public string SubscribeUrlShort { get; set; }
        public string SubscribeUrlLong { get; set; }
        public string BeamerAddress { get; set; }
        public string Visibility { get; set; }
        public List<object> Modules { get; set; }
        public Stats Stats { get; set; }
        public List<Link> Links { get; set; }
    }
}