using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCaseAddCov
    {
        public int CaseId { get; set; }
        public int AddCovSeqRecNum { get; set; }
        public string AddlCvgCoverage { get; set; }
        public string AddlCvgPlanName { get; set; }
        public string AddlCvgCoverageType { get; set; }
        public string AddlCvgCoverageLives { get; set; }
        public string AddlCvgCaseNum { get; set; }
        public decimal? AddlCvgCurrentAmt { get; set; }
        public decimal? AddlCvgDeathBeneAmt { get; set; }
        public int? AddlCvgCurrNumUnits { get; set; }
        public string AddlCvgValuePerUnit { get; set; }
        public DateTime? AddlLastmodifiedDate { get; set; }
        public string AddlCvgSlId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public DmtCase Case { get; set; }
    }
}
