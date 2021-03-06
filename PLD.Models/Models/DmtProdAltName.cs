﻿using System;
using System.Collections.Generic;

namespace PLD.Models
{
    public partial class DmtProdAltName
    {
        public int ProdAltNameId { get; set; }
        public int ProdId { get; set; }
        public string Name { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual DmtProd Prod { get; set; }
    }
}
