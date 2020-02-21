using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtPrtnrFeed
    {
        public DmtPrtnrFeed()
        {
            DmtFeed = new HashSet<DmtFeed>();
            DmtPrtnrFeedFile = new HashSet<DmtPrtnrFeedFile>();
        }

        public int PrtnrFeedId { get; set; }
        public int PrtnrId { get; set; }
        public string Name { get; set; }
        public string DescTxt { get; set; }
        public bool SrcInd { get; set; }
        public bool TrgtInd { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }
        public string SrcAdptr { get; set; }
        public string TrgtAdptr { get; set; }

        public DmtPrtnr Prtnr { get; set; }
        public ICollection<DmtFeed> DmtFeed { get; set; }
        public ICollection<DmtPrtnrFeedFile> DmtPrtnrFeedFile { get; set; }
    }
}
