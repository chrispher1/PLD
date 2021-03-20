using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtFeed
    {
        public DmtFeed()
        {
            DmtFeedFile = new HashSet<DmtFeedFile>();
            DmtFeedSchedLog = new HashSet<DmtFeedSchedLog>();
        }

        public int FeedId { get; set; }
        public int PrtnrFeedId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }

        public virtual DmtPrtnrFeed PrtnrFeed { get; set; }
        public virtual ICollection<DmtFeedFile> DmtFeedFile { get; set; }
        public virtual ICollection<DmtFeedSchedLog> DmtFeedSchedLog { get; set; }
    }
}
