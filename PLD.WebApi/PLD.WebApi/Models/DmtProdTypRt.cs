using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtProdTypRt
    {
        public int ProdTypRtId { get; set; }
        public int CarrId { get; set; }
        public int ProdTypId { get; set; }
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
        public DmtCarr Carr { get; set; }
        public DmtStCd StCdNavigation { get; set; }
        public DmtTmCd TmCdNavigation { get; set; }
    }
}
