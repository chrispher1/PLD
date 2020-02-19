using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtCaseWpCmnt
    {
        public int CaseWpCmntId { get; set; }
        public int CaseWpId { get; set; }
        public string CmntTxt { get; set; }
        public DateTime? CrtDt { get; set; }
        public string CrtBy { get; set; }
    }
}
