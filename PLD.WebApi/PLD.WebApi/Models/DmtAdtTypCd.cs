using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtAdtTypCd
    {
        public DmtAdtTypCd()
        {
            DmtAdt = new HashSet<DmtAdt>();
        }

        public string AdtTypCd { get; set; }
        public string DescTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual ICollection<DmtAdt> DmtAdt { get; set; }
    }
}
