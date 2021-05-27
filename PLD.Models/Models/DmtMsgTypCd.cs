using System;
using System.Collections.Generic;

namespace PLD.Models
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

        public virtual ICollection<DmtCaseMsg> DmtCaseMsg { get; set; }
        public virtual ICollection<DmtCommMsg> DmtCommMsg { get; set; }
        public virtual ICollection<DmtMsgCd> DmtMsgCd { get; set; }
    }
}
