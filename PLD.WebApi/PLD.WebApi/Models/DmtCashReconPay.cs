﻿using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCashReconPay
    {
        public int CashReconId { get; set; }
        public int PayId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }

        public DmtCashRecon CashRecon { get; set; }
        public DmtPay Pay { get; set; }
    }
}