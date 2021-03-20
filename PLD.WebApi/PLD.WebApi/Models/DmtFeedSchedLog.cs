using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtFeedSchedLog
    {
        public int FeedId { get; set; }
        public int CalEntryId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }

        public virtual DmtCalEntry CalEntry { get; set; }
        public virtual DmtFeed Feed { get; set; }
    }
}
