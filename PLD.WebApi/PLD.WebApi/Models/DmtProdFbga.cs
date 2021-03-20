using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtProdFbga
    {
        public int ProdId { get; set; }
        public int FbId { get; set; }
        public int GaId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual DmtFb Fb { get; set; }
        public virtual DmtGa Ga { get; set; }
        public virtual DmtProd Prod { get; set; }
    }
}
