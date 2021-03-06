﻿using System;
using System.Collections.Generic;

namespace PLD.Models
{
    public partial class DmtActCd
    {
        public DmtActCd()
        {
            DmtCommErr = new HashSet<DmtCommErr>();
            DmtProdRt = new HashSet<DmtProdRt>();
            DmtProdTypRt = new HashSet<DmtProdTypRt>();            
        }

        public string ActCd { get; set; }
        public string DescTxt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual ICollection<DmtComm> DmtComm { get; set; }
        public virtual ICollection<DmtCommErr> DmtCommErr { get; set; }
        public virtual ICollection<DmtProdRt> DmtProdRt { get; set; }
        public virtual ICollection<DmtProdTypRt> DmtProdTypRt { get; set; }        
    }
}
