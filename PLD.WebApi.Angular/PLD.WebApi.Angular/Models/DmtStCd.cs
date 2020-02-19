﻿using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtStCd
    {
        public DmtStCd()
        {
            DmtProdRt = new HashSet<DmtProdRt>();
            DmtProdTypRt = new HashSet<DmtProdTypRt>();
        }

        public string StCd { get; set; }
        public string Name { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public ICollection<DmtProdRt> DmtProdRt { get; set; }
        public ICollection<DmtProdTypRt> DmtProdTypRt { get; set; }
    }
}
