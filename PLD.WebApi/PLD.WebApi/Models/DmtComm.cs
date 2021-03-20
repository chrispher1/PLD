using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtComm
    {
        public DmtComm()
        {
            DmtCommAgnt = new HashSet<DmtCommAgnt>();
            DmtCommClnt = new HashSet<DmtCommClnt>();
        }

        public int CommId { get; set; }
        public int FbId { get; set; }
        public int GaId { get; set; }
        public int CarrId { get; set; }
        public int ProdId { get; set; }
        public int CaseId { get; set; }
        public string PolNum { get; set; }
        public string GrpPolNum { get; set; }
        public DateTime? ApplDt { get; set; }
        public DateTime? IppDt { get; set; }
        public DateTime? IssDt { get; set; }
        public DateTime? PolDt { get; set; }
        public string IssStCd { get; set; }
        public string ResStCd { get; set; }
        public int? IssAgeNum { get; set; }
        public int YrNum { get; set; }
        public string TmCd { get; set; }
        public string ActCd { get; set; }
        public decimal? GrsPremAmt { get; set; }
        public decimal CommPremAmt { get; set; }
        public decimal CommRt { get; set; }
        public decimal CommAmt { get; set; }
        public DateTime? PremDueDt { get; set; }
        public string PremModeCd { get; set; }
        public DateTime? TransDt { get; set; }
        public int? LnkCommId { get; set; }
        public DateTime? ExtrctDt { get; set; }
        public DateTime OrigPrcsDt { get; set; }
        public string StatCd { get; set; }
        public DateTime StatDt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModById { get; set; }
        public string SrcFileName { get; set; }
        public string TrnsmsnUniqId { get; set; }
        public string SndrId { get; set; }
        public string RcvrId { get; set; }
        public string SrcCarrCd { get; set; }
        public string CntlNum { get; set; }
        public int? TransSeqNum { get; set; }
        public string CompInd { get; set; }
        public decimal? ApplRt { get; set; }
        public decimal? ExpCommRt { get; set; }
        public decimal? ExpCommAmt { get; set; }
        public decimal? DueAmt { get; set; }
        public DateTime? OrigReconDt { get; set; }
        public DateTime? LstReconDt { get; set; }
        public decimal? AdjAmt { get; set; }

        public virtual DmtActCd ActCdNavigation { get; set; }
        public virtual DmtCarr Carr { get; set; }
        public virtual DmtFb Fb { get; set; }
        public virtual DmtGa Ga { get; set; }
        public virtual DmtPremModeCd PremModeCdNavigation { get; set; }
        public virtual DmtProd Prod { get; set; }
        public virtual DmtStatCd StatCdNavigation { get; set; }
        public virtual DmtTmCd TmCdNavigation { get; set; }
        public virtual ICollection<DmtCommAgnt> DmtCommAgnt { get; set; }
        public virtual ICollection<DmtCommClnt> DmtCommClnt { get; set; }
    }
}
