﻿using System;
using System.Collections.Generic;

namespace PLD.WebApi.Models
{
    public partial class DmtCaserep
    {
        public DateTime ExtractDt { get; set; }
        public string RecordType { get; set; }
        public string CaseType { get; set; }
        public string SlCaseId { get; set; }
        public string DistributionCompany { get; set; }
        public string ApplicationId { get; set; }
        public string CaseIdC { get; set; }
        public string CaseMgrName { get; set; }
        public DateTime? DateEnteredC { get; set; }
        public string CaseMgrSlId { get; set; }
        public string CaseStatus { get; set; }
        public string ApplicationType { get; set; }
        public string Status { get; set; }
        public string SubStatus { get; set; }
        public DateTime? StatusDateC { get; set; }
        public string StatusReasonC { get; set; }
        public string CarrierInfo { get; set; }
        public string CarrierAcctName { get; set; }
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
        public string FinancialAdvisorInfo { get; set; }
        public string FaName { get; set; }
        public string FaPhone { get; set; }
        public string FaEmail { get; set; }
        public string FaAsstname { get; set; }
        public string FaAsstEmail { get; set; }
        public string FaAsstPhone { get; set; }
        public string FaFirmRegion { get; set; }
        public string FaNpn { get; set; }
        public string FaBusinessStreet1 { get; set; }
        public string FaBusinessStreet2 { get; set; }
        public string FaBusinessCity { get; set; }
        public string FaBusinessState { get; set; }
        public string FaBusinessZipCode { get; set; }
        public string FaBusinessCountry { get; set; }
        public decimal? FaLatitude { get; set; }
        public decimal? FaLongtitude { get; set; }
        public string FaPosition { get; set; }
        public string FaSlContactId { get; set; }
        public string PrimaryInsured { get; set; }
        public string PrimInsFirstname { get; set; }
        public string PrimInsMiddlename { get; set; }
        public string PrimInsLastname { get; set; }
        public string PrimInsSuffix { get; set; }
        public string PrimInsCity { get; set; }
        public string PrimInsState { get; set; }
        public string PrimInsZip { get; set; }
        public int? PrimInsIssueAge { get; set; }
        public string PolicyDetailPolicyBaseCoverage { get; set; }
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
        public string PremiumInfo { get; set; }
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
        public string ImportantDates { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? AppSignDate { get; set; }
        public DateTime? AppReceiptDate { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string LastUwActivity { get; set; }
        public DateTime? CommPaidDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? PlacementExpDate { get; set; }
        public DateTime? PolicyEffDate { get; set; }
        public DateTime? PolicyPlacedDate { get; set; }
        public string DistributionCompany2 { get; set; }
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
        public string LifeParticipant { get; set; }
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
        public string AdditionalCoverages { get; set; }
        public string AddlCvgCoverage { get; set; }
        public string AddlCvgPlanName { get; set; }
        public string AddlCvgCoverageType { get; set; }
        public string AddlCvgCoverageLives { get; set; }
        public string AddlCvgCaseNum { get; set; }
        public decimal? AddlCvgCurrentAmt { get; set; }
        public decimal? AddlCvgDeathBeneAmt { get; set; }
        public int? AddlCvgCurrNumUnits { get; set; }
        public string AddlCvgValuePerUnit { get; set; }
        public DateTime? AddlCvgLastmodifiedDate { get; set; }
        public string AddlCvgSlId { get; set; }
    }
}
