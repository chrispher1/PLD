﻿using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtMsgCd
    {
        public DmtMsgCd()
        {
            DmtCaseMsg = new HashSet<DmtCaseMsg>();
            DmtCommMsg = new HashSet<DmtCommMsg>();
        }

        public string MsgCd { get; set; }
        public string MsgTypCd { get; set; }
        public string MsgTxt { get; set; }
        public bool AccptInd { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public DmtMsgTypCd MsgTypCdNavigation { get; set; }
        public ICollection<DmtCaseMsg> DmtCaseMsg { get; set; }
        public ICollection<DmtCommMsg> DmtCommMsg { get; set; }
    }
}
