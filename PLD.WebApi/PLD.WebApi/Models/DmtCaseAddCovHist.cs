using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCaseAddCovHist
    {
        public int CaseId { get; set; }
        public DateTime CaseHistTs { get; set; }
        public int AddCovSeqReqNum { get; set; }
        public string AddlCvgCoverage { get; set; }
        public string AddlCvgPlanName { get; set; }
        public string AddlCvgCoverageType { get; set; }
        public string AddlCvgCoverageLives { get; set; }
        public string AddlCvgCaseNum { get; set; }
        public decimal? AddlCvgCurrentAmt { get; set; }
        public decimal? AddlCvgDeathBeneAmt { get; set; }
        public int? AddlCvgCurrNumUnits { get; set; }
        public string AddlCvgValuePerUnits { get; set; }
        public DateTime? AddlCvgLastmodifiedDate { get; set; }
        public string AddlCvgSlId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual DmtCaseHist Case { get; set; }
    }
}
