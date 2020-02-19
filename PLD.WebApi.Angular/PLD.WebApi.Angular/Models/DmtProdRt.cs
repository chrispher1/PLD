using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtProdRt
    {
        public int ProdRtId { get; set; }
        public int ProdId { get; set; }
        public string StCd { get; set; }
        public DateTime EffDt { get; set; }
        public string TmCd { get; set; }
        public string ActCd { get; set; }
        public int YrStartNum { get; set; }
        public int YrEndNum { get; set; }
        public int? AgeStartNum { get; set; }
        public int? AgeEndNum { get; set; }
        public decimal Rate { get; set; }
        public DateTime? ExpDt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public DmtActCd ActCdNavigation { get; set; }
        public DmtProd Prod { get; set; }
        public DmtStCd StCdNavigation { get; set; }
        public DmtTmCd TmCdNavigation { get; set; }
    }
}
