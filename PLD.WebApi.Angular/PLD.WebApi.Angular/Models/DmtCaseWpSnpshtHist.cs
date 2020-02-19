using System;
using System.Collections.Generic;

namespace PLD.WebApi.Angular.Models
{
    public partial class DmtCaseWpSnpshtHist
    {
        public int CaseWpId { get; set; }
        public int CaseId { get; set; }
        public string RsvpStaffCd { get; set; }
        public decimal WpAmt { get; set; }
        public DateTime EffDt { get; set; }
        public DateTime CrtTs { get; set; }
        public string Status { get; set; }
        public string CaseType { get; set; }
        public string RsvpContractNumber { get; set; }
        public string RsvpName { get; set; }
        public string Carrierid { get; set; }
        public string CarrName { get; set; }
        public DateTime? CrtDt { get; set; }
    }
}
