using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtSsnTinTypCd
    {
        public DmtSsnTinTypCd()
        {
            DmtCommAgnt = new HashSet<DmtCommAgnt>();
            DmtCommClnt = new HashSet<DmtCommClnt>();
            DmtCommErrAgnt = new HashSet<DmtCommErrAgnt>();
            DmtCommErrClnt = new HashSet<DmtCommErrClnt>();
        }

        public string SsnTinTypCd { get; set; }
        public string DescTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public ICollection<DmtCommAgnt> DmtCommAgnt { get; set; }
        public ICollection<DmtCommClnt> DmtCommClnt { get; set; }
        public ICollection<DmtCommErrAgnt> DmtCommErrAgnt { get; set; }
        public ICollection<DmtCommErrClnt> DmtCommErrClnt { get; set; }
    }
}
