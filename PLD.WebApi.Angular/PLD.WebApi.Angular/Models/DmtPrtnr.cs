using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtPrtnr
    {
        public DmtPrtnr()
        {
            DmtPrtnrFeed = new HashSet<DmtPrtnrFeed>();
        }

        public int PrtnrId { get; set; }
        public string Name { get; set; }
        public string DescTxt { get; set; }
        public bool SndrId { get; set; }
        public bool RcvrId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public ICollection<DmtPrtnrFeed> DmtPrtnrFeed { get; set; }
    }
}
