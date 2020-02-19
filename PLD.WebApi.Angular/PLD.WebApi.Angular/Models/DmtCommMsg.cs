﻿using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtCommMsg
    {
        public int CommMsgId { get; set; }
        public int CommId { get; set; }
        public string MsgCd { get; set; }
        public string MsgTypCd { get; set; }
        public string MsgTxt { get; set; }
        public string TechMsgTxt { get; set; }
        public bool? AccptInd { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public DmtMsgCd MsgCdNavigation { get; set; }
        public DmtMsgTypCd MsgTypCdNavigation { get; set; }
    }
}
