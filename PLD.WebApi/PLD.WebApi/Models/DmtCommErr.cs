using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCommErr
    {
        public DmtCommErr()
        {
            DmtCommErrAgnt = new HashSet<DmtCommErrAgnt>();
            DmtCommErrClnt = new HashSet<DmtCommErrClnt>();
        }

        public int CommId { get; set; }
        public int? FbId { get; set; }
        public int? GaId { get; set; }
        public int? CarrId { get; set; }
        public int? ProdId { get; set; }
        public int? CaseId { get; set; }
        public string PolNum { get; set; }
        public string GrpPolNum { get; set; }
        public DateTime? ApplDt { get; set; }
        public DateTime? IppDt { get; set; }
        public DateTime? IssDt { get; set; }
        public DateTime? PolDt { get; set; }
        public string IssStCd { get; set; }
        public string ResStCd { get; set; }
        public int? IssAgeNum { get; set; }
        public int? YrNum { get; set; }
        public string TmCd { get; set; }
        public string ActCd { get; set; }
        public decimal? GrsPremAmt { get; set; }
        public decimal? CommPremAmt { get; set; }
        public decimal? CommRt { get; set; }
        public decimal? CommAmt { get; set; }
        public DateTime? PremDueDt { get; set; }
        public string PremModeCd { get; set; }
        public DateTime? TransDt { get; set; }
        public int? LnkCommId { get; set; }
        public DateTime? ExtrctDt { get; set; }
        public DateTime? OrigPrcsDt { get; set; }
        public string StatCd { get; set; }
        public DateTime? StatDt { get; set; }
        public DateTime CrtDt { get; set; }
        public string CrtById { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModById { get; set; }
        public string SrcFileName { get; set; }
        public string TrnmsnUniqId { get; set; }
        public string SndrId { get; set; }
        public string RcvrId { get; set; }
        public string SrcCarrId { get; set; }
        public string CntlNum { get; set; }
        public int? TransSeqNum { get; set; }
        public string CusipNum { get; set; }
        public string SrcCommOptCd { get; set; }
        public string SrcCommExtCd { get; set; }
        public string SrcProdTypCd { get; set; }
        public string SrcProdCd { get; set; }
        public string SrcTmCd { get; set; }
        public string SrcActCd { get; set; }
        public string SrcPremModeCd { get; set; }
        public string CompInd { get; set; }
        public string AssocFmInd { get; set; }
        public string CommTypCd { get; set; }
        public string CommEvntTypCd { get; set; }
        public decimal? ApplRt { get; set; }
        public decimal? ExpCommRt { get; set; }
        public decimal? ExpCommAmt { get; set; }
        public decimal? DueAmt { get; set; }
        public DateTime? OrigReconDt { get; set; }
        public DateTime? LstReconDt { get; set; }
        public decimal? AdjAmt { get; set; }

        public DmtActCd ActCdNavigation { get; set; }
        public DmtCarr Carr { get; set; }
        public DmtFb Fb { get; set; }
        public DmtGa Ga { get; set; }
        public DmtPremModeCd PremModeCdNavigation { get; set; }
        public DmtProd Prod { get; set; }
        public DmtStatCd StatCdNavigation { get; set; }
        public DmtTmCd TmCdNavigation { get; set; }
        public ICollection<DmtCommErrAgnt> DmtCommErrAgnt { get; set; }
        public ICollection<DmtCommErrClnt> DmtCommErrClnt { get; set; }
    }
}
