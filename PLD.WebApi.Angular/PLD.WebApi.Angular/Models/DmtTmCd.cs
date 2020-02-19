using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtTmCd
    {
        public DmtTmCd()
        {
            DmtComm = new HashSet<DmtComm>();
            DmtCommErr = new HashSet<DmtCommErr>();
            DmtProdRt = new HashSet<DmtProdRt>();
            DmtProdTypRt = new HashSet<DmtProdTypRt>();
        }

        public string TmCd { get; set; }
        public string DescTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public ICollection<DmtComm> DmtComm { get; set; }
        public ICollection<DmtCommErr> DmtCommErr { get; set; }
        public ICollection<DmtProdRt> DmtProdRt { get; set; }
        public ICollection<DmtProdTypRt> DmtProdTypRt { get; set; }
    }
}
