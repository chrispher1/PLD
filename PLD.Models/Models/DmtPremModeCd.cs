﻿using System;
using System.Collections.Generic;

namespace PLD.Models
{
    public partial class DmtPremModeCd
    {
        public DmtPremModeCd()
        {
            //DmtComm = new HashSet<DmtComm>();
            DmtCommErr = new HashSet<DmtCommErr>();
        }

        public string PremModeCd { get; set; }
        public string DescTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        //public virtual ICollection<DmtComm> DmtComm { get; set; }
        public virtual ICollection<DmtCommErr> DmtCommErr { get; set; }
    }
}
