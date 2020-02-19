using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtCaseCmnt
    {
        public int CaseCmntId { get; set; }
        public int CaseId { get; set; }
        public string CmntTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }

        public DmtCase Case { get; set; }
    }
}
