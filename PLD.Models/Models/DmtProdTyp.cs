﻿using System;
using System.Collections.Generic;

namespace PLD.Models
{
    public partial class DmtProdTyp
    {
        public DmtProdTyp()
        {
            DmtCase = new HashSet<DmtCase>();            
            DmtProd = new HashSet<DmtProd>();
        }

        public int ProdTypId { get; set; }
        public string ProdTypCd { get; set; }
        public string Name { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }
        public virtual ICollection<DmtCase> DmtCase { get; set; }        
        public virtual ICollection<DmtProd> DmtProd { get; set; }
    }
}
