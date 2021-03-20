using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtFeedFile
    {
        public int FeedFileId { get; set; }
        public int FeedId { get; set; }
        public int PrtnrFeedFileId { get; set; }
        public string FileName { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }

        public virtual DmtFeed Feed { get; set; }
        public virtual DmtPrtnrFeedFile PrtnrFeedFile { get; set; }
    }
}
