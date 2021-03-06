﻿using System;
using System.Collections.Generic;

namespace PLD.Models
{
    public partial class DmtPayCmnt
    {
        public int PayCmntId { get; set; }
        public int PayId { get; set; }
        public string CmntTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }

        public virtual DmtPay Pay { get; set; }
    }
}
