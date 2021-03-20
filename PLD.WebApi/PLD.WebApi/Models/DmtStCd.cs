using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtStCd
    {
        public DmtStCd()
        {
            DmtProdRt = new HashSet<DmtProdRt>();
            DmtProdTypRt = new HashSet<DmtProdTypRt>();
        }

        public string StCd { get; set; }
        public string Name { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual ICollection<DmtProdRt> DmtProdRt { get; set; }
        public virtual ICollection<DmtProdTypRt> DmtProdTypRt { get; set; }
    }
}
