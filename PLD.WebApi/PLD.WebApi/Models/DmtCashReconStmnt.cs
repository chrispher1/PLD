﻿using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCashReconStmnt
    {
        public int CashReconId { get; set; }
        public int CommStmntId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }

        public virtual DmtCashRecon CashRecon { get; set; }
        public virtual DmtCommStmnt CommStmnt { get; set; }
    }
}
