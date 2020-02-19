﻿using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtCommErrAgnt
    {
        public int CommId { get; set; }
        public int CommAgntSeqNum { get; set; }
        public string AgntSsnTinNum { get; set; }
        public string AgntSsnTinTypCd { get; set; }
        public string AgntNpn { get; set; }
        public string AgntCntrNum { get; set; }
        public decimal? AgntSplitPct { get; set; }
        public decimal? GrsPremAmt { get; set; }
        public decimal? CommPremAmt { get; set; }
        public decimal? CommRt { get; set; }
        public decimal? CommAmt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModById { get; set; }
        public string SrcTinTypCd { get; set; }

        public DmtSsnTinTypCd AgntSsnTinTypCdNavigation { get; set; }
        public DmtCommErr Comm { get; set; }
    }
}