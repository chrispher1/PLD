using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCaseWp
    {
        public int CaseWpId { get; set; }
        public int CaseId { get; set; }
        public string RsvpStaffCd { get; set; }
        public int? CommId { get; set; }
        public string WpTypCd { get; set; }
        public decimal? WpAmt { get; set; }
        public DateTime? EffDt { get; set; }
        public bool VoidInd { get; set; }
        public DateTime? VoidDt { get; set; }
        public string VoidById { get; set; }
        public bool ApprovInd { get; set; }
        public DateTime? ApprovDt { get; set; }
        public string ApprovById { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModById { get; set; }
        public string StatCd { get; set; }
        public DateTime? StatDt { get; set; }
        public string SysStatCd { get; set; }
        public DateTime? SysStatDt { get; set; }
    }
}
