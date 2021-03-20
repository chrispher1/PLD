using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtTmActMap
    {
        public int CarrId { get; set; }
        public string SrcTmCd { get; set; }
        public string SrcActCd { get; set; }
        public int YrStartNum { get; set; }
        public int YrEndNum { get; set; }
        public string TmCd { get; set; }
        public string ActCd { get; set; }
        public string CompInd { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }
        public string SrcTransKey { get; set; }

        public virtual DmtActCd ActCdNavigation { get; set; }
        public virtual DmtTmCd TmCdNavigation { get; set; }
    }
}
