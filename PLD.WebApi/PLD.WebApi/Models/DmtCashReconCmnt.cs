using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCashReconCmnt
    {
        public int CashReconCmntId { get; set; }
        public int CashReconId { get; set; }
        public string CmntTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }

        public DmtCashRecon CashRecon { get; set; }
    }
}
