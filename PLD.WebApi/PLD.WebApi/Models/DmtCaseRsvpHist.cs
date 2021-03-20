using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCaseRsvpHist
    {
        public int CaseId { get; set; }
        public DateTime CaseHistTs { get; set; }
        public int RsvpSeqRecNum { get; set; }
        public string RsvpName { get; set; }
        public string RsvpTerritory { get; set; }
        public string RsvpPhone { get; set; }
        public string RsvpEmail { get; set; }
        public string RsvpStaffCode { get; set; }
        public string RsvpContractNumber { get; set; }
        public string RsvpRoleName { get; set; }
        public string RsvpSlId { get; set; }
        public string IwName { get; set; }
        public string IwPhone { get; set; }
        public string IwEmail { get; set; }
        public string IwRoleName { get; set; }
        public string IwSlId { get; set; }
        public string CaseMgrPhone { get; set; }
        public string CaseMgrEmail { get; set; }
        public string CaseMgrRolename { get; set; }
        public string CmSlId { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual DmtCaseHist Case { get; set; }
    }
}
