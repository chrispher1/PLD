using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtCashReconStmnt
    {
        public int CashReconId { get; set; }
        public int CommStmntId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }

        public DmtCashRecon CashRecon { get; set; }
        public DmtCommStmnt CommStmnt { get; set; }
    }
}
