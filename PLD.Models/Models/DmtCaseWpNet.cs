using System;
using System.Collections.Generic;

namespace PLD.Models
{
    public partial class DmtCaseWpNet
    {
        public int CaseWpNetId { get; set; }
        public int CaseId { get; set; }
        public string WpTypCd { get; set; }
        public decimal? WpNetAmt { get; set; }
        public DateTime? AsOfDt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CryById { get; set; }
    }
}
