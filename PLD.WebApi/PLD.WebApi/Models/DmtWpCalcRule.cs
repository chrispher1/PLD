using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtWpCalcRule
    {
        public int WpCalcRuleId { get; set; }
        public int? ProdTypId { get; set; }
        public int? ProdId { get; set; }
        public string TmCd { get; set; }
        public string ActCd { get; set; }
        public int? YrInfrcNum { get; set; }
        public bool? CompInd { get; set; }
        public decimal FactorRt { get; set; }
        public string CaseAmtName { get; set; }
        public string CommAmtName { get; set; }
        public string WpCalcCd { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }
    }
}
