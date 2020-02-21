using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCommWpSnpshtHist
    {
        public int CommWpSnpshtId { get; set; }
        public int? CaseWpId { get; set; }
        public int CaseId { get; set; }
        public string RsvpStaffCd { get; set; }
        public int? CommId { get; set; }
        public decimal? WpAmt { get; set; }
        public DateTime? EffDt { get; set; }
        public DateTime? CrtTs { get; set; }
        public string Status { get; set; }
        public string CaseType { get; set; }
        public string RsvpContractNumber { get; set; }
        public string RsvpName { get; set; }
        public string Carrierid { get; set; }
        public string CarrName { get; set; }
        public int? FbId { get; set; }
        public DateTime? PolDt { get; set; }
        public int? YrNum { get; set; }
        public string ActCd { get; set; }
        public decimal? CommPremAmt { get; set; }
        public decimal? CommRt { get; set; }
        public decimal? CommAmt { get; set; }
        public string PremModeCd { get; set; }
        public DateTime? TransDt { get; set; }
        public decimal? ExpCommRt { get; set; }
        public decimal? ExpCommAmt { get; set; }
        public string AgntNpn { get; set; }
        public string AgntCntrNum { get; set; }
        public decimal? AgntSplitPct { get; set; }
        public DateTime? CrtDt { get; set; }
    }
}
