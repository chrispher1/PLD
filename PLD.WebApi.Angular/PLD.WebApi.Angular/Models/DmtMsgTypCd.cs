using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtMsgTypCd
    {
        public DmtMsgTypCd()
        {
            DmtCaseMsg = new HashSet<DmtCaseMsg>();
            DmtCommMsg = new HashSet<DmtCommMsg>();
            DmtMsgCd = new HashSet<DmtMsgCd>();
        }

        public string MsgTypCd { get; set; }
        public string DescTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public ICollection<DmtCaseMsg> DmtCaseMsg { get; set; }
        public ICollection<DmtCommMsg> DmtCommMsg { get; set; }
        public ICollection<DmtMsgCd> DmtMsgCd { get; set; }
    }
}
