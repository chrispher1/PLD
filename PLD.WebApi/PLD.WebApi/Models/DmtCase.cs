using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCase
    {
        public DmtCase()
        {
            DmtCaseAddCov = new HashSet<DmtCaseAddCov>();
            DmtCaseAgnt = new HashSet<DmtCaseAgnt>();
            DmtCaseAgntHist = new HashSet<DmtCaseAgntHist>();
            DmtCaseCmnt = new HashSet<DmtCaseCmnt>();
            DmtCaseHist = new HashSet<DmtCaseHist>();
            DmtCaseLifePartic = new HashSet<DmtCaseLifePartic>();
            DmtCaseRsvp = new HashSet<DmtCaseRsvp>();
            DmtCaseWpRsvp = new HashSet<DmtCaseWpRsvp>();
        }

        public int CaseId { get; set; }
        public int? FbId { get; set; }
        public int? GaId { get; set; }
        public int? CarrId { get; set; }
        public int? ProdId { get; set; }
        public int? ProdTypId { get; set; }
        public string RecordType { get; set; }
        public string CaseType { get; set; }
        public string SlCaseId { get; set; }
        public string ApplicationId { get; set; }
        public string CaseIdC { get; set; }
        public string CaseMgrName { get; set; }
        public DateTime? DateEnteredC { get; set; }
        public string CaseMgrSlIdC { get; set; }
        public string ApplicationType { get; set; }
        public string Status { get; set; }
        public string SubStatus { get; set; }
        public DateTime? StatusDateC { get; set; }
        public string StatusReasonC { get; set; }
        public string CarrierActName { get; set; }
        public string CarrierCasemgrName { get; set; }
        public string CarrierCasemgrEmail { get; set; }
        public string CarrierCasemgrPhone { get; set; }
        public string SlCarrierCmContactid { get; set; }
        public string Carrierid { get; set; }
        public string CarrierUnderwriterName { get; set; }
        public string CarrierUnderwriterEmail { get; set; }
        public string CarrierUnderwriterPhone { get; set; }
        public string CarrierUwRole { get; set; }
        public string CarrierUwContactid { get; set; }
        public string PrimInsFirstname { get; set; }
        public string PrimInsMiddlename { get; set; }
        public string PrimInsLastname { get; set; }
        public string PrimInsSuffix { get; set; }
        public string PrimInsCity { get; set; }
        public string PrimInsState { get; set; }
        public string PrimInsZip { get; set; }
        public int? PrimInsIssueAge { get; set; }
        public string PolicyNumber { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public decimal? FaceAmt { get; set; }
        public string DeathBenefitType { get; set; }
        public decimal? DeathBenefitAmt { get; set; }
        public string CoverageType { get; set; }
        public string IssueState { get; set; }
        public int? IssueAge { get; set; }
        public string UwClass { get; set; }
        public string TobaccoUsage { get; set; }
        public string PermanentTableRating { get; set; }
        public decimal? FlatExtraAmount { get; set; }
        public DateTime? FlatEndDate { get; set; }
        public string AdditionalCoveragesIndicator { get; set; }
        public decimal? Amount1035 { get; set; }
        public string ClassName { get; set; }
        public string CoveredLives { get; set; }
        public decimal? ModalPremium { get; set; }
        public string PremiumMode { get; set; }
        public decimal? TargetPremAmt { get; set; }
        public decimal? AnnualizedPremium { get; set; }
        public string PaymentMethod { get; set; }
        public decimal? CashWithApp { get; set; }
        public decimal? TotalCashWithApp { get; set; }
        public string MoneyTransferType { get; set; }
        public decimal? InitialPremiumPayment { get; set; }
        public decimal? BalanceOfPremiumDue { get; set; }
        public decimal? ExcessPremium { get; set; }
        public decimal? WeightedPremiumMeasure { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? AppSignDate { get; set; }
        public DateTime? AppRecieptDate { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string LastUwActivity { get; set; }
        public DateTime? CommPaidDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? PlacementExpDate { get; set; }
        public DateTime? PolicyEffDate { get; set; }
        public DateTime? PolicyPlacedDate { get; set; }
        public DateTime? CrtDt { get; set; }
        public string CrtBy { get; set; }
        public DateTime? ModDt { get; set; }
        public string ModBy { get; set; }

        public virtual DmtCarr Carr { get; set; }
        public virtual DmtFb Fb { get; set; }
        public virtual DmtGa Ga { get; set; }
        public virtual DmtProd Prod { get; set; }
        public virtual DmtProdTyp ProdTyp { get; set; }
        public virtual ICollection<DmtCaseAddCov> DmtCaseAddCov { get; set; }
        public virtual ICollection<DmtCaseAgnt> DmtCaseAgnt { get; set; }
        public virtual ICollection<DmtCaseAgntHist> DmtCaseAgntHist { get; set; }
        public virtual ICollection<DmtCaseCmnt> DmtCaseCmnt { get; set; }
        public virtual ICollection<DmtCaseHist> DmtCaseHist { get; set; }
        public virtual ICollection<DmtCaseLifePartic> DmtCaseLifePartic { get; set; }
        public virtual ICollection<DmtCaseRsvp> DmtCaseRsvp { get; set; }
        public virtual ICollection<DmtCaseWpRsvp> DmtCaseWpRsvp { get; set; }
    }
}
