using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtFeed
    {
        public DmtFeed()
        {
            DmtFeedFile = new HashSet<DmtFeedFile>();
        }

        public int FeedId { get; set; }
        public int PrtnrFeedId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }

        public DmtPrtnrFeed PrtnrFeed { get; set; }
        public ICollection<DmtFeedFile> DmtFeedFile { get; set; }
    }
}
