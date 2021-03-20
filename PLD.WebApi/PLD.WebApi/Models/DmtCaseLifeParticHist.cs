using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCaseLifeParticHist
    {
        public int CaseId { get; set; }
        public DateTime CaseHistTs { get; set; }
        public int LifeParticSeqRecNum { get; set; }
        public string LifePartCoverageName { get; set; }
        public string LifePartRole { get; set; }
        public int? LifePartIssueAge { get; set; }
        public string LifePartIssueGender { get; set; }
        public string LifePartClassName { get; set; }
        public string LifePartUwClass { get; set; }
        public string LifePartUwSubClass { get; set; }
        public string LifePartTobacco { get; set; }
        public string LifePartTempRating { get; set; }
        public string LifePartPermRating { get; set; }
        public string LifePartPermTableRating { get; set; }
        public string LifePartLastModifiedDate { get; set; }
        public string LifePartSlId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual DmtCaseHist Case { get; set; }
    }
}
