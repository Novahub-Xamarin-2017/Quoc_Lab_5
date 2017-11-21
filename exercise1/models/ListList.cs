using System.Collections.Generic;

namespace exercise1.models
{
    public class ListList
    {
        public List<EmailList> Lists { get; set; }
        public int TotalItems { get; set; }
        public List<models.Link> Links { get; set; }
    }
}