using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PLD.Models;

namespace PLD.DataAccess
{
    public partial class DMTPLDContext : DbContext
    {
        public DMTPLDContext(DbContextOptions<DMTPLDContext> options): base(options) {
        
        }

        public virtual DbSet<DmtActCd> DmtActCd { get; set; }        
        public virtual DbSet<DmtCarr> DmtCarr { get; set; }
        public virtual DbSet<DmtCase> DmtCase { get; set; } 
        public virtual DbSet<DmtCaseAgnt> DmtCaseAgnt { get; set; }        
        public virtual DbSet<DmtCaseCmnt> DmtCaseCmnt { get; set; }        
        public virtual DbSet<DmtCaseLifePartic> DmtCaseLifePartic { get; set; }
        public virtual DbSet<DmtCaseMsg> DmtCaseMsg { get; set; }
        public virtual DbSet<DmtCaseRsvp> DmtCaseRsvp { get; set; }        
        public virtual DbSet<DmtCaseWp> DmtCaseWp { get; set; }
        public virtual DbSet<DmtCaseWpCmnt> DmtCaseWpCmnt { get; set; }
        public virtual DbSet<DmtCaseWpNet> DmtCaseWpNet { get; set; }
        public virtual DbSet<DmtCaseWpRsvp> DmtCaseWpRsvp { get; set; } 
        public virtual DbSet<DmtComm> DmtComm { get; set; }
        public virtual DbSet<DmtCommAgnt> DmtCommAgnt { get; set; }
        public virtual DbSet<DmtCommClnt> DmtCommClnt { get; set; }
        public virtual DbSet<DmtCommCmnt> DmtCommCmnt { get; set; }
        public virtual DbSet<DmtCommErr> DmtCommErr { get; set; }
        public virtual DbSet<DmtCommErrAgnt> DmtCommErrAgnt { get; set; }
        public virtual DbSet<DmtCommErrClnt> DmtCommErrClnt { get; set; }
        public virtual DbSet<DmtCommMsg> DmtCommMsg { get; set; }        
        public virtual DbSet<DmtMsgCd> DmtMsgCd { get; set; }
        public virtual DbSet<DmtMsgTypCd> DmtMsgTypCd { get; set; }
        public virtual DbSet<DmtPay> DmtPay { get; set; }
        public virtual DbSet<DmtPayCmnt> DmtPayCmnt { get; set; }
        public virtual DbSet<DmtPremModeCd> DmtPremModeCd { get; set; }
        public virtual DbSet<DmtProd> DmtProd { get; set; }
        public virtual DbSet<DmtProdAltName> DmtProdAltName { get; set; }        
        public virtual DbSet<DmtProdRt> DmtProdRt { get; set; }
        public virtual DbSet<DmtProdTyp> DmtProdTyp { get; set; }
        public virtual DbSet<DmtProdTypRt> DmtProdTypRt { get; set; }
        public virtual DbSet<DmtSsnTinTypCd> DmtSsnTinTypCd { get; set; }
        public virtual DbSet<DmtStCd> DmtStCd { get; set; }
        public virtual DbSet<DmtStatCd> DmtStatCd { get; set; }        
        public virtual DbSet<DmtTmCd> DmtTmCd { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                 optionsBuilder.UseSqlServer("Server=MSI;Database=DMTPLD;Trusted_Connection=True;");
//             }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DmtActCd>(entity =>
            {
                entity.HasKey(e => e.ActCd);

                entity.ToTable("DMT_ACT_CD");

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescTxt)
                    .IsRequired()
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(100);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");
            });

            modelBuilder.Entity<DmtCarr>(entity =>
            {
                entity.HasKey(e => e.CarrId);

                entity.ToTable("DMT_CARR");

                entity.Property(e => e.CarrId)
                    .HasColumnName("CARR_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarrCd)
                    .IsRequired()
                    .HasColumnName("CARR_CD")
                    .HasMaxLength(25);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);
            });  

            modelBuilder.Entity<DmtCase>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.ToTable("DMT_CASE");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.AdditionalCoveragesIndicator)
                    .HasColumnName("ADDITIONAL_COVERAGES_INDICATOR")
                    .HasMaxLength(5);

                entity.Property(e => e.Amount1035)
                    .HasColumnName("AMOUNT_1035")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AnnualizedPremium)
                    .HasColumnName("ANNUALIZED_PREMIUM")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AppRecieptDate)
                    .HasColumnName("APP_RECIEPT_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.AppSignDate)
                    .HasColumnName("APP_SIGN_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnName("APPLICATION_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("APPLICATION_ID")
                    .HasMaxLength(12);

                entity.Property(e => e.ApplicationType)
                    .HasColumnName("APPLICATION_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.ApprovalDate)
                    .HasColumnName("APPROVAL_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.BalanceOfPremiumDue)
                    .HasColumnName("BALANCE_OF_PREMIUM_DUE")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CarrId).HasColumnName("CARR_ID");

                entity.Property(e => e.CarrierActName)
                    .HasColumnName("CARRIER_ACT_NAME")
                    .HasMaxLength(40);

                entity.Property(e => e.CarrierCasemgrEmail)
                    .HasColumnName("CARRIER_CASEMGR_EMAIL")
                    .HasMaxLength(80);

                entity.Property(e => e.CarrierCasemgrName)
                    .HasColumnName("CARRIER_CASEMGR_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.CarrierCasemgrPhone)
                    .HasColumnName("CARRIER_CASEMGR_PHONE")
                    .HasMaxLength(14);

                entity.Property(e => e.CarrierUnderwriterEmail)
                    .HasColumnName("CARRIER_UNDERWRITER_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CarrierUnderwriterName)
                    .HasColumnName("CARRIER_UNDERWRITER_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.CarrierUnderwriterPhone)
                    .HasColumnName("CARRIER_UNDERWRITER_PHONE")
                    .HasMaxLength(14);

                entity.Property(e => e.CarrierUwContactid)
                    .HasColumnName("CARRIER_UW_CONTACTID")
                    .HasMaxLength(18);

                entity.Property(e => e.CarrierUwRole)
                    .HasColumnName("CARRIER_UW_ROLE")
                    .HasMaxLength(30);

                entity.Property(e => e.Carrierid)
                    .IsRequired()
                    .HasColumnName("CARRIERID")
                    .HasMaxLength(6);

                entity.Property(e => e.CaseIdC)
                    .HasColumnName("CASE_ID_C")
                    .HasMaxLength(20);

                entity.Property(e => e.CaseMgrName)
                    .HasColumnName("CASE_MGR_NAME")
                    .HasMaxLength(80);

                entity.Property(e => e.CaseMgrSlIdC)
                    .HasColumnName("CASE_MGR_SL_ID_C")
                    .HasMaxLength(18);

                entity.Property(e => e.CaseType)
                    .HasColumnName("CASE_TYPE")
                    .HasMaxLength(15);

                entity.Property(e => e.CashWithApp)
                    .HasColumnName("CASH_WITH_APP")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ClassName)
                    .HasColumnName("CLASS_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.CommPaidDate)
                    .HasColumnName("COMM_PAID_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.CoverageType)
                    .HasColumnName("COVERAGE_TYPE")
                    .HasMaxLength(60);

                entity.Property(e => e.CoveredLives)
                    .HasColumnName("COVERED_LIVES")
                    .HasMaxLength(25);

                entity.Property(e => e.CrtBy)
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateEnteredC)
                    .HasColumnName("DATE_ENTERED_C")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.DeathBenefitAmt)
                    .HasColumnName("DEATH_BENEFIT_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.DeathBenefitType)
                    .HasColumnName("DEATH_BENEFIT_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.ExcessPremium)
                    .HasColumnName("EXCESS_PREMIUM")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.FaceAmt)
                    .HasColumnName("FACE_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.FlatEndDate)
                    .HasColumnName("FLAT_END_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FlatExtraAmount)
                    .HasColumnName("FLAT_EXTRA_AMOUNT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.InitialPremiumPayment)
                    .HasColumnName("INITIAL_PREMIUM_PAYMENT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.IssueAge).HasColumnName("ISSUE_AGE");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("ISSUE_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.IssueState)
                    .HasColumnName("ISSUE_STATE")
                    .HasMaxLength(2);

                entity.Property(e => e.LastActivityDate)
                    .HasColumnName("LAST_ACTIVITY_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.LastUwActivity)
                    .HasColumnName("LAST_UW_ACTIVITY")
                    .HasMaxLength(20);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ModalPremium)
                    .HasColumnName("MODAL_PREMIUM")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.MoneyTransferType)
                    .HasColumnName("MONEY_TRANSFER_TYPE")
                    .HasMaxLength(60);

                entity.Property(e => e.PaymentMethod)
                    .HasColumnName("PAYMENT_METHOD")
                    .HasMaxLength(75);

                entity.Property(e => e.PermanentTableRating)
                    .HasColumnName("PERMANENT_TABLE_RATING")
                    .HasMaxLength(60);

                entity.Property(e => e.PlacementExpDate)
                    .HasColumnName("PLACEMENT_EXP_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.PolicyEffDate)
                    .HasColumnName("POLICY_EFF_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.PolicyNumber)
                    .HasColumnName("POLICY_NUMBER")
                    .HasMaxLength(30);

                entity.Property(e => e.PolicyPlacedDate)
                    .HasColumnName("POLICY_PLACED_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.PremiumMode)
                    .HasColumnName("PREMIUM_MODE")
                    .HasMaxLength(50);

                entity.Property(e => e.PrimInsCity)
                    .HasColumnName("PRIM_INS_CITY")
                    .HasMaxLength(50);

                entity.Property(e => e.PrimInsFirstname)
                    .HasColumnName("PRIM_INS_FIRSTNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.PrimInsIssueAge).HasColumnName("PRIM_INS_ISSUE_AGE");

                entity.Property(e => e.PrimInsLastname)
                    .HasColumnName("PRIM_INS_LASTNAME")
                    .HasMaxLength(30);

                entity.Property(e => e.PrimInsMiddlename)
                    .HasColumnName("PRIM_INS_MIDDLENAME")
                    .HasMaxLength(30);

                entity.Property(e => e.PrimInsState)
                    .HasColumnName("PRIM_INS_STATE")
                    .HasMaxLength(2);

                entity.Property(e => e.PrimInsSuffix)
                    .HasColumnName("PRIM_INS_SUFFIX")
                    .HasMaxLength(3);

                entity.Property(e => e.PrimInsZip)
                    .HasColumnName("PRIM_INS_ZIP")
                    .HasMaxLength(10);

                entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

                entity.Property(e => e.ProdTypId).HasColumnName("PROD_TYP_ID");

                entity.Property(e => e.ProductName)
                    .HasColumnName("PRODUCT_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.ProductType)
                    .HasColumnName("PRODUCT_TYPE")
                    .HasMaxLength(40);

                entity.Property(e => e.RecordType)
                    .HasColumnName("RECORD_TYPE")
                    .HasMaxLength(15);

                entity.Property(e => e.SlCarrierCmContactid)
                    .HasColumnName("SL_CARRIER_CM_CONTACTID")
                    .HasMaxLength(18);

                entity.Property(e => e.SlCaseId)
                    .HasColumnName("SL_CASE_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusDateC)
                    .HasColumnName("STATUS_DATE_C")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.StatusReasonC)
                    .HasColumnName("STATUS_REASON_C")
                    .HasMaxLength(100);

                entity.Property(e => e.SubStatus)
                    .HasColumnName("SUB_STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.TargetPremAmt)
                    .HasColumnName("TARGET_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.TobaccoUsage)
                    .HasColumnName("TOBACCO_USAGE")
                    .HasMaxLength(60);

                entity.Property(e => e.TotalCashWithApp)
                    .HasColumnName("TOTAL_CASH_WITH_APP")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.UwClass)
                    .HasColumnName("UW_CLASS")
                    .HasMaxLength(60);

                entity.Property(e => e.WeightedPremiumMeasure)
                    .HasColumnName("WEIGHTED_PREMIUM_MEASURE")
                    .HasColumnType("numeric(16, 2)");

                entity.HasOne(d => d.Carr)
                    .WithMany(p => p.DmtCase)
                    .HasForeignKey(d => d.CarrId)
                    .HasConstraintName("FK_DMT_CASE_DMT_CARR");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.DmtCase)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK_DMT_CASE_DMT_PROD");

                entity.HasOne(d => d.ProdTyp)
                    .WithMany(p => p.DmtCase)
                    .HasForeignKey(d => d.ProdTypId)
                    .HasConstraintName("FK_DMT_CASE_DMT_PROD_TYP");
            });

            modelBuilder.Entity<DmtCaseAgnt>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.AgntSeqRecNum });

                entity.ToTable("DMT_CASE_AGNT");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.AgntSeqRecNum).HasColumnName("AGNT_SEQ_REC_NUM");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FaAsstEmail)
                    .HasColumnName("FA_ASST_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.FaAsstPhone)
                    .HasColumnName("FA_ASST_PHONE")
                    .HasMaxLength(14);

                entity.Property(e => e.FaAsstname)
                    .HasColumnName("FA_ASSTNAME")
                    .HasMaxLength(60);

                entity.Property(e => e.FaBusinessCity)
                    .HasColumnName("FA_BUSINESS_CITY")
                    .HasMaxLength(50);

                entity.Property(e => e.FaBusinessCountry)
                    .HasColumnName("FA_BUSINESS_COUNTRY")
                    .HasMaxLength(3);

                entity.Property(e => e.FaBusinessState)
                    .HasColumnName("FA_BUSINESS_STATE")
                    .HasMaxLength(3);

                entity.Property(e => e.FaBusinessStreet1)
                    .HasColumnName("FA_BUSINESS_STREET_1")
                    .HasMaxLength(50);

                entity.Property(e => e.FaBusinessStreet2)
                    .HasColumnName("FA_BUSINESS_STREET_2")
                    .HasMaxLength(50);

                entity.Property(e => e.FaBusinessZipCode)
                    .HasColumnName("FA_BUSINESS_ZIP_CODE")
                    .HasMaxLength(10);

                entity.Property(e => e.FaEmail)
                    .HasColumnName("FA_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.FaFirmRegion)
                    .HasColumnName("FA_FIRM_REGION")
                    .HasMaxLength(3);

                entity.Property(e => e.FaLatitude)
                    .HasColumnName("FA_LATITUDE")
                    .HasColumnType("decimal(13, 10)");

                entity.Property(e => e.FaLongtitude)
                    .HasColumnName("FA_LONGTITUDE")
                    .HasColumnType("decimal(13, 10)");

                entity.Property(e => e.FaName)
                    .HasColumnName("FA_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.FaNpn)
                    .HasColumnName("FA_NPN")
                    .HasMaxLength(10);

                entity.Property(e => e.FaPhone)
                    .HasColumnName("FA_PHONE")
                    .HasMaxLength(14);

                entity.Property(e => e.FaPosition)
                    .HasColumnName("FA_POSITION")
                    .HasMaxLength(100);

                entity.Property(e => e.FaSlContactId)
                    .HasColumnName("FA_SL_CONTACT_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime2(0)");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.DmtCaseAgnt)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_AGNT_DMT_CASE");
            });

            modelBuilder.Entity<DmtCaseCmnt>(entity =>
            {
                entity.HasKey(e => e.CaseCmntId);

                entity.ToTable("DMT_CASE_CMNT");

                entity.Property(e => e.CaseCmntId).HasColumnName("CASE_CMNT_ID");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CmntTxt)
                    .IsRequired()
                    .HasColumnName("CMNT_TXT")
                    .HasMaxLength(4000);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.DmtCaseCmnt)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_CMNT_DMT_CASE");
            });            

            modelBuilder.Entity<DmtCaseLifePartic>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.LifeParticSeqRecNum });

                entity.ToTable("DMT_CASE_LIFE_PARTIC");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.LifeParticSeqRecNum).HasColumnName("LIFE_PARTIC_SEQ_REC_NUM");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LifePartClassName)
                    .HasColumnName("LIFE_PART_CLASS_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.LifePartCoverageName)
                    .HasColumnName("LIFE_PART_COVERAGE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.LifePartIssueAge).HasColumnName("LIFE_PART_ISSUE_AGE");

                entity.Property(e => e.LifePartIssueGender)
                    .HasColumnName("LIFE_PART_ISSUE_GENDER")
                    .HasMaxLength(10);

                entity.Property(e => e.LifePartLastModifiedDate)
                    .HasColumnName("LIFE_PART_LAST_MODIFIED_DATE")
                    .HasMaxLength(25);

                entity.Property(e => e.LifePartPermRating)
                    .HasColumnName("LIFE_PART_PERM_RATING")
                    .HasMaxLength(50);

                entity.Property(e => e.LifePartPermTableRating)
                    .HasColumnName("LIFE_PART_PERM_TABLE_RATING")
                    .HasMaxLength(50);

                entity.Property(e => e.LifePartRole)
                    .HasColumnName("LIFE_PART_ROLE")
                    .HasMaxLength(50);

                entity.Property(e => e.LifePartSlId)
                    .HasColumnName("LIFE_PART_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.LifePartTempRating)
                    .HasColumnName("LIFE_PART_TEMP_RATING")
                    .HasMaxLength(50);

                entity.Property(e => e.LifePartTobacco)
                    .HasColumnName("LIFE_PART_TOBACCO")
                    .HasMaxLength(50);

                entity.Property(e => e.LifePartUwClass)
                    .HasColumnName("LIFE_PART_UW_CLASS")
                    .HasMaxLength(50);

                entity.Property(e => e.LifePartUwSubClass)
                    .HasColumnName("LIFE_PART_UW_SUB_CLASS")
                    .HasMaxLength(50);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime2(0)");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.DmtCaseLifePartic)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_LIFE_PARTIC_DMT_CASE");
            });            

            modelBuilder.Entity<DmtCaseMsg>(entity =>
            {
                entity.HasKey(e => e.CaseMsgId);

                entity.ToTable("DMT_CASE_MSG");

                entity.Property(e => e.CaseMsgId)
                    .HasColumnName("CASE_MSG_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccptInd).HasColumnName("ACCPT_IND");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.MsgCd)
                    .IsRequired()
                    .HasColumnName("MSG_CD")
                    .HasMaxLength(25);

                entity.Property(e => e.MsgTxt)
                    .HasColumnName("MSG_TXT")
                    .HasMaxLength(4000);

                entity.Property(e => e.MsgTypCd)
                    .HasColumnName("MSG_TYP_CD")
                    .HasMaxLength(10);

                entity.Property(e => e.TechMsgTxt)
                    .HasColumnName("TECH_MSG_TXT")
                    .HasMaxLength(4000);

                entity.HasOne(d => d.MsgCdNavigation)
                    .WithMany(p => p.DmtCaseMsg)
                    .HasForeignKey(d => d.MsgCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_MSG_DMT_MSG_CD");

                entity.HasOne(d => d.MsgTypCdNavigation)
                    .WithMany(p => p.DmtCaseMsg)
                    .HasForeignKey(d => d.MsgTypCd)
                    .HasConstraintName("FK_DMT_CASE_MSG_DMT_MSG_TYP_CD");
            });

            modelBuilder.Entity<DmtCaseRsvp>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.RsvpSeqRecNum });

                entity.ToTable("DMT_CASE_RSVP");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.RsvpSeqRecNum).HasColumnName("RSVP_SEQ_REC_NUM");

                entity.Property(e => e.CaseMgrEmail)
                    .HasColumnName("CASE_MGR_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CaseMgrPhone)
                    .HasColumnName("CASE_MGR_PHONE")
                    .HasMaxLength(14);

                entity.Property(e => e.CaseMgrRolename)
                    .HasColumnName("CASE_MGR_ROLENAME")
                    .HasMaxLength(20);

                entity.Property(e => e.CmSlId)
                    .HasColumnName("CM_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IwEmail)
                    .HasColumnName("IW_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.IwName)
                    .HasColumnName("IW_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.IwPhone)
                    .HasColumnName("IW_PHONE")
                    .HasMaxLength(14);

                entity.Property(e => e.IwRoleName)
                    .HasColumnName("IW_ROLE_NAME")
                    .HasMaxLength(20);

                entity.Property(e => e.IwSlId)
                    .HasColumnName("IW_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.RsvpContractNumber)
                    .HasColumnName("RSVP_CONTRACT_NUMBER")
                    .HasMaxLength(6);

                entity.Property(e => e.RsvpEmail)
                    .HasColumnName("RSVP_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.RsvpName)
                    .HasColumnName("RSVP_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.RsvpPhone)
                    .HasColumnName("RSVP_PHONE")
                    .HasMaxLength(14);

                entity.Property(e => e.RsvpRoleName)
                    .HasColumnName("RSVP_ROLE_NAME")
                    .HasMaxLength(5);

                entity.Property(e => e.RsvpSlId)
                    .HasColumnName("RSVP_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.RsvpStaffCode)
                    .HasColumnName("RSVP_STAFF_CODE")
                    .HasMaxLength(3);

                entity.Property(e => e.RsvpTerritory)
                    .HasColumnName("RSVP_TERRITORY")
                    .HasMaxLength(25);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.DmtCaseRsvp)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_RSVP_DMT_CASE");
            });            

            modelBuilder.Entity<DmtCaseWp>(entity =>
            {
                entity.HasKey(e => e.CaseWpId);

                entity.ToTable("DMT_CASE_WP");

                entity.Property(e => e.CaseWpId).HasColumnName("CASE_WP_ID");

                entity.Property(e => e.ApprovById)
                    .HasColumnName("APPROV_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ApprovDt)
                    .HasColumnName("APPROV_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ApprovInd).HasColumnName("APPROV_IND");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CommId).HasColumnName("COMM_ID");

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffDt)
                    .HasColumnName("EFF_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModById)
                    .HasColumnName("MOD_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.RsvpStaffCd)
                    .IsRequired()
                    .HasColumnName("RSVP_STAFF_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.StatCd)
                    .HasColumnName("STAT_CD")
                    .HasMaxLength(1);

                entity.Property(e => e.StatDt)
                    .HasColumnName("STAT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.SysStatCd)
                    .HasColumnName("SYS_STAT_CD")
                    .HasMaxLength(1);

                entity.Property(e => e.SysStatDt)
                    .HasColumnName("SYS_STAT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.VoidById)
                    .HasColumnName("VOID_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.VoidDt)
                    .HasColumnName("VOID_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.VoidInd).HasColumnName("VOID_IND");

                entity.Property(e => e.WpAmt)
                    .HasColumnName("WP_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.WpTypCd)
                    .HasColumnName("WP_TYP_CD")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<DmtCaseWpCmnt>(entity =>
            {
                entity.HasKey(e => e.CaseWpCmntId);

                entity.ToTable("DMT_CASE_WP_CMNT");

                entity.Property(e => e.CaseWpCmntId).HasColumnName("CASE_WP_CMNT_ID");

                entity.Property(e => e.CaseWpId).HasColumnName("CASE_WP_ID");

                entity.Property(e => e.CmntTxt)
                    .HasColumnName("CMNT_TXT")
                    .HasMaxLength(4000);

                entity.Property(e => e.CrtBy)
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DmtCaseWpNet>(entity =>
            {
                entity.HasKey(e => e.CaseWpNetId);

                entity.ToTable("DMT_CASE_WP_NET");

                entity.Property(e => e.CaseWpNetId).HasColumnName("CASE_WP_NET_ID");

                entity.Property(e => e.AsOfDt)
                    .HasColumnName("AS_OF_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CryById)
                    .IsRequired()
                    .HasColumnName("CRY_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.WpNetAmt)
                    .HasColumnName("WP_NET_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.WpTypCd)
                    .HasColumnName("WP_TYP_CD")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<DmtCaseWpRsvp>(entity =>
            {
                entity.HasKey(e => e.CaseWpRsvpId);

                entity.ToTable("DMT_CASE_WP_RSVP");

                entity.Property(e => e.CaseWpRsvpId).HasColumnName("CASE_WP_RSVP_ID");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModById)
                    .HasColumnName("MOD_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.RsvpStaffCd)
                    .IsRequired()
                    .HasColumnName("RSVP_STAFF_CD")
                    .HasMaxLength(3);

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.DmtCaseWpRsvp)
                    .HasForeignKey(d => d.CaseId)
                    .HasConstraintName("FK_DMT_CASE_WP_RSVP_DMT_CASE");
            });

            modelBuilder.Entity<DmtComm>(entity =>
            {
                entity.HasKey(e => e.CommId);

                entity.ToTable("DMT_COMM");

                entity.Property(e => e.CommId)
                    .HasColumnName("COMM_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActCd)
                    .IsRequired()
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.AdjAmt)
                    .HasColumnName("ADJ_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ApplDt).HasColumnName("APPL_DT");

                entity.Property(e => e.ApplRt)
                    .HasColumnName("APPL_RT")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.CarrId).HasColumnName("CARR_ID");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CntlNum)
                    .HasColumnName("CNTL_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.CommAmt)
                    .HasColumnName("COMM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommPremAmt)
                    .HasColumnName("COMM_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommRt)
                    .HasColumnName("COMM_RT")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.CompInd)
                    .HasColumnName("COMP_IND")
                    .HasMaxLength(2);

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DueAmt)
                    .HasColumnName("DUE_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ExpCommAmt)
                    .HasColumnName("EXP_COMM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ExpCommRt)
                    .HasColumnName("EXP_COMM_RT")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.ExtrctDt).HasColumnName("EXTRCT_DT");

                entity.Property(e => e.GrpPolNum)
                    .HasColumnName("GRP_POL_NUM")
                    .HasMaxLength(30);

                entity.Property(e => e.GrsPremAmt)
                    .HasColumnName("GRS_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.IppDt).HasColumnName("IPP_DT");

                entity.Property(e => e.IssAgeNum).HasColumnName("ISS_AGE_NUM");

                entity.Property(e => e.IssDt).HasColumnName("ISS_DT");

                entity.Property(e => e.IssStCd)
                    .HasColumnName("ISS_ST_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.LnkCommId).HasColumnName("LNK_COMM_ID");

                entity.Property(e => e.LstReconDt).HasColumnName("LST_RECON_DT");

                entity.Property(e => e.ModById)
                    .HasColumnName("MOD_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.OrigPrcsDt).HasColumnName("ORIG_PRCS_DT");

                entity.Property(e => e.OrigReconDt).HasColumnName("ORIG_RECON_DT");

                entity.Property(e => e.PolDt).HasColumnName("POL_DT");

                entity.Property(e => e.PolNum)
                    .IsRequired()
                    .HasColumnName("POL_NUM")
                    .HasMaxLength(30);

                entity.Property(e => e.PremDueDt).HasColumnName("PREM_DUE_DT");

                entity.Property(e => e.PremModeCd)
                    .HasColumnName("PREM_MODE_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

                entity.Property(e => e.RcvrId)
                    .HasColumnName("RCVR_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.ResStCd)
                    .HasColumnName("RES_ST_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.SndrId)
                    .HasColumnName("SNDR_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.SrcCarrCd)
                    .HasColumnName("SRC_CARR_CD")
                    .HasMaxLength(25);

                entity.Property(e => e.SrcFileName)
                    .HasColumnName("SRC_FILE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.StatCd)
                    .IsRequired()
                    .HasColumnName("STAT_CD")
                    .HasMaxLength(1);

                entity.Property(e => e.StatDt).HasColumnName("STAT_DT");

                entity.Property(e => e.TmCd)
                    .HasColumnName("TM_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.TransDt).HasColumnName("TRANS_DT");

                entity.Property(e => e.TransSeqNum).HasColumnName("TRANS_SEQ_NUM");

                entity.Property(e => e.TrnsmsnUniqId)
                    .HasColumnName("TRNSMSN_UNIQ_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.YrNum).HasColumnName("YR_NUM");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.ActCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_DMT_ACT_CD");                    

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.CarrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_DMT_CARR");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_DMT_PROD");

                entity.HasOne(d => d.StatusCode)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.StatCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_DMT_STAT_CD");

/*
                entity.HasOne(d => d.TmCdNavigation)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.TmCd)
                    .HasConstraintName("FK_DMT_COMM_DMT_TM_CD");
*/

            });

            modelBuilder.Entity<DmtCommAgnt>(entity =>
            {
                entity.HasKey(e => new { e.CommId, e.CommAgntSeqNum });

                entity.ToTable("DMT_COMM_AGNT");

                entity.Property(e => e.CommId).HasColumnName("COMM_ID");

                entity.Property(e => e.CommAgntSeqNum).HasColumnName("COMM_AGNT_SEQ_NUM");

                entity.Property(e => e.AgntCntrNum)
                    .HasColumnName("AGNT_CNTR_NUM")
                    .HasMaxLength(6);

                entity.Property(e => e.AgntNpn)
                    .HasColumnName("AGNT_NPN")
                    .HasMaxLength(10);

                entity.Property(e => e.AgntSplitPct)
                    .HasColumnName("AGNT_SPLIT_PCT")
                    .HasColumnType("decimal(10, 9)");

                entity.Property(e => e.AgntSsnTinNum)
                    .HasColumnName("AGNT_SSN_TIN_NUM")
                    .HasMaxLength(9);

                entity.Property(e => e.AgntSsnTinTypCd)
                    .HasColumnName("AGNT_SSN_TIN_TYP_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.CommAmt)
                    .HasColumnName("COMM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommPremAmt)
                    .HasColumnName("COMM_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommRt)
                    .HasColumnName("COMM_RT")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GrsPremAmt)
                    .HasColumnName("GRS_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ModById)
                    .HasColumnName("MOD_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.SrcTinTypCd)
                    .HasColumnName("SRC_TIN_TYP_CD")
                    .HasMaxLength(3);

                entity.HasOne(d => d.AgntSsnTinTypCdNavigation)
                    .WithMany(p => p.DmtCommAgnt)
                    .HasForeignKey(d => d.AgntSsnTinTypCd)
                    .HasConstraintName("FK_DMT_COMM_AGNT_DMT_SSN_TIN_TYP_CD");

/*
                entity.HasOne(d => d.Comm)
                    .WithMany(p => p.DmtCommAgnt)
                    .HasForeignKey(d => d.CommId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_AGNT_DMT_COMM");
 */                   
            });

            modelBuilder.Entity<DmtCommClnt>(entity =>
            {
                entity.HasKey(e => new { e.CommId, e.CommClntSeqNum });

                entity.ToTable("DMT_COMM_CLNT");

                entity.Property(e => e.CommId).HasColumnName("COMM_ID");

                entity.Property(e => e.CommClntSeqNum).HasColumnName("COMM_CLNT_SEQ_NUM");

                entity.Property(e => e.ClntFirstName)
                    .HasColumnName("CLNT_FIRST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ClntFullName)
                    .HasColumnName("CLNT_FULL_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ClntLstName)
                    .HasColumnName("CLNT_LST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ClntMidName)
                    .HasColumnName("CLNT_MID_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ClntPrfxName)
                    .HasColumnName("CLNT_PRFX_NAME")
                    .HasMaxLength(25);

                entity.Property(e => e.ClntSfxName)
                    .HasColumnName("CLNT_SFX_NAME")
                    .HasMaxLength(25);

                entity.Property(e => e.ClntSsnTinNum)
                    .HasColumnName("CLNT_SSN_TIN_NUM")
                    .HasMaxLength(9);

                entity.Property(e => e.ClntSsnTinTypCd)
                    .HasColumnName("CLNT_SSN_TIN_TYP_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModById)
                    .HasColumnName("MOD_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.SrcSsnTinTypCd)
                    .HasColumnName("SRC_SSN_TIN_TYP_CD")
                    .HasMaxLength(3);

                entity.HasOne(d => d.ClntSsnTinTypCdNavigation)
                    .WithMany(p => p.DmtCommClnt)
                    .HasForeignKey(d => d.ClntSsnTinTypCd)
                    .HasConstraintName("FK_DMT_COMM_CLNT_DMT_SSN_TIN_TYP_CD");
/*
                entity.HasOne(d => d.Comm)
                    .WithMany(p => p.DmtCommClnt)
                    .HasForeignKey(d => d.CommId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_CLNT_DMT_COMM");
*/                    
            });

            modelBuilder.Entity<DmtCommCmnt>(entity =>
            {
                entity.HasKey(e => e.CommCmntId);

                entity.ToTable("DMT_COMM_CMNT");

                entity.Property(e => e.CommCmntId).HasColumnName("COMM_CMNT_ID");

                entity.Property(e => e.CmntTxt)
                    .IsRequired()
                    .HasColumnName("CMNT_TXT")
                    .HasMaxLength(4000);

                entity.Property(e => e.CommId).HasColumnName("COMM_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DmtCommErr>(entity =>
            {
                entity.HasKey(e => e.CommId)
                    .HasName("PK_DMT_COMM_ERR_1");

                entity.ToTable("DMT_COMM_ERR");

                entity.HasIndex(e => new { e.CarrId, e.CommId, e.PolNum })
                    .HasDatabaseName("NonClusteredIndex-20200115-124436");

                entity.Property(e => e.CommId).HasColumnName("COMM_ID");

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.AdjAmt)
                    .HasColumnName("ADJ_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ApplDt).HasColumnName("APPL_DT");

                entity.Property(e => e.ApplRt)
                    .HasColumnName("APPL_RT")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.AssocFmInd)
                    .HasColumnName("ASSOC_FM_IND")
                    .HasMaxLength(15);

                entity.Property(e => e.CarrId).HasColumnName("CARR_ID");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CntlNum)
                    .HasColumnName("CNTL_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.CommAmt)
                    .HasColumnName("COMM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommEvntTypCd)
                    .HasColumnName("COMM_EVNT_TYP_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.CommPremAmt)
                    .HasColumnName("COMM_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommRt)
                    .HasColumnName("COMM_RT")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.CommTypCd)
                    .HasColumnName("COMM_TYP_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.CompInd)
                    .HasColumnName("COMP_IND")
                    .HasMaxLength(2);

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CusipNum)
                    .HasColumnName("CUSIP_NUM")
                    .HasMaxLength(9);

                entity.Property(e => e.DueAmt)
                    .HasColumnName("DUE_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ExpCommAmt)
                    .HasColumnName("EXP_COMM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ExpCommRt)
                    .HasColumnName("EXP_COMM_RT")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.ExtrctDt).HasColumnName("EXTRCT_DT");

                entity.Property(e => e.GrpPolNum)
                    .HasColumnName("GRP_POL_NUM")
                    .HasMaxLength(30);

                entity.Property(e => e.GrsPremAmt)
                    .HasColumnName("GRS_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.IppDt).HasColumnName("IPP_DT");

                entity.Property(e => e.IssAgeNum).HasColumnName("ISS_AGE_NUM");

                entity.Property(e => e.IssDt).HasColumnName("ISS_DT");

                entity.Property(e => e.IssStCd)
                    .HasColumnName("ISS_ST_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.LnkCommId).HasColumnName("LNK_COMM_ID");

                entity.Property(e => e.LstReconDt).HasColumnName("LST_RECON_DT");

                entity.Property(e => e.ModById)
                    .HasColumnName("MOD_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.OrigPrcsDt).HasColumnName("ORIG_PRCS_DT");

                entity.Property(e => e.OrigReconDt).HasColumnName("ORIG_RECON_DT");

                entity.Property(e => e.PolDt).HasColumnName("POL_DT");

                entity.Property(e => e.PolNum)
                    .HasColumnName("POL_NUM")
                    .HasMaxLength(30);

                entity.Property(e => e.PremDueDt).HasColumnName("PREM_DUE_DT");

                entity.Property(e => e.PremModeCd)
                    .HasColumnName("PREM_MODE_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

                entity.Property(e => e.RcvrId)
                    .HasColumnName("RCVR_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.ResStCd)
                    .HasColumnName("RES_ST_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.SndrId)
                    .HasColumnName("SNDR_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.SrcActCd)
                    .HasColumnName("SRC_ACT_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.SrcCarrId)
                    .HasColumnName("SRC_CARR_ID")
                    .HasMaxLength(25);

                entity.Property(e => e.SrcCommExtCd)
                    .HasColumnName("SRC_COMM_EXT_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.SrcCommOptCd)
                    .HasColumnName("SRC_COMM_OPT_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.SrcFileName)
                    .HasColumnName("SRC_FILE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.SrcPremModeCd)
                    .HasColumnName("SRC_PREM_MODE_CD")
                    .HasMaxLength(15);

                entity.Property(e => e.SrcProdCd)
                    .HasColumnName("SRC_PROD_CD")
                    .HasMaxLength(25);

                entity.Property(e => e.SrcProdTypCd)
                    .HasColumnName("SRC_PROD_TYP_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.SrcTmCd)
                    .HasColumnName("SRC_TM_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.StatCd)
                    .HasColumnName("STAT_CD")
                    .HasMaxLength(1);

                entity.Property(e => e.StatDt).HasColumnName("STAT_DT");

                entity.Property(e => e.TmCd)
                    .HasColumnName("TM_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.TransDt).HasColumnName("TRANS_DT");

                entity.Property(e => e.TransSeqNum).HasColumnName("TRANS_SEQ_NUM");

                entity.Property(e => e.TrnmsnUniqId)
                    .HasColumnName("TRNMSN_UNIQ_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.YrNum).HasColumnName("YR_NUM");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.ActCd)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_ACT_CD");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.CarrId)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_CARR"); 

                entity.HasOne(d => d.PremModeCdNavigation)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.PremModeCd)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_PREM_MODE_CD");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_PROD");

                entity.HasOne(d => d.StatusCode)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.StatCd)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_STAT_CD");

                entity.HasOne(d => d.TmCdNavigation)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.TmCd)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_TM_CD");
            });

            modelBuilder.Entity<DmtCommErrAgnt>(entity =>
            {
                entity.HasKey(e => new { e.CommId, e.CommAgntSeqNum });

                entity.ToTable("DMT_COMM_ERR_AGNT");

                entity.Property(e => e.CommId).HasColumnName("COMM_ID");

                entity.Property(e => e.CommAgntSeqNum).HasColumnName("COMM_AGNT_SEQ_NUM");

                entity.Property(e => e.AgntCntrNum)
                    .HasColumnName("AGNT_CNTR_NUM")
                    .HasMaxLength(6);

                entity.Property(e => e.AgntCrdNum)
                    .HasColumnName("AGNT_CRD_NUM")
                    .HasMaxLength(10);

                entity.Property(e => e.AgntDistAssgnId)
                    .HasColumnName("AGNT_DIST_ASSGN_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.AgntNpn)
                    .HasColumnName("AGNT_NPN")
                    .HasMaxLength(10);

                entity.Property(e => e.AgntSplitPct)
                    .HasColumnName("AGNT_SPLIT_PCT")
                    .HasColumnType("decimal(10, 9)");

                entity.Property(e => e.AgntSsnTinNum)
                    .HasColumnName("AGNT_SSN_TIN_NUM")
                    .HasMaxLength(9);

                entity.Property(e => e.AgntSsnTinTypCd)
                    .HasColumnName("AGNT_SSN_TIN_TYP_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.CommAmt)
                    .HasColumnName("COMM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommPremAmt)
                    .HasColumnName("COMM_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommRt)
                    .HasColumnName("COMM_RT")
                    .HasColumnType("decimal(12, 9)");

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GrsPremAmt)
                    .HasColumnName("GRS_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ModById)
                    .HasColumnName("MOD_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.SrcTinTypCd)
                    .HasColumnName("SRC_TIN_TYP_CD")
                    .HasMaxLength(3);

                entity.HasOne(d => d.AgntSsnTinTypCdNavigation)
                    .WithMany(p => p.DmtCommErrAgnt)
                    .HasForeignKey(d => d.AgntSsnTinTypCd)
                    .HasConstraintName("FK_DMT_COMM_ERR_AGNT_DMT_SSN_TIN_TYP_CD");

                entity.HasOne(d => d.Comm)
                    .WithMany(p => p.DmtCommErrAgnt)
                    .HasForeignKey(d => d.CommId)                    
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DMT_COMM_ERR_AGNT_DMT_COMM_ERR");
            });

            modelBuilder.Entity<DmtCommErrClnt>(entity =>
            {
                entity.HasKey(e => new { e.CommId, e.CommClntSeqNum });

                entity.ToTable("DMT_COMM_ERR_CLNT");

                entity.Property(e => e.CommId).HasColumnName("COMM_ID");

                entity.Property(e => e.CommClntSeqNum).HasColumnName("COMM_CLNT_SEQ_NUM");

                entity.Property(e => e.ClntFirstName)
                    .HasColumnName("CLNT_FIRST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ClntFullName)
                    .HasColumnName("CLNT_FULL_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ClntLstName)
                    .HasColumnName("CLNT_LST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ClntMidName)
                    .HasColumnName("CLNT_MID_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ClntPrfxName)
                    .HasColumnName("CLNT_PRFX_NAME")
                    .HasMaxLength(25);

                entity.Property(e => e.ClntSfxName)
                    .HasColumnName("CLNT_SFX_NAME")
                    .HasMaxLength(25);

                entity.Property(e => e.ClntSsnTinNum)
                    .HasColumnName("CLNT_SSN_TIN_NUM")
                    .HasMaxLength(9);

                entity.Property(e => e.ClntSsnTinTypCd)
                    .HasColumnName("CLNT_SSN_TIN_TYP_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModById)
                    .HasColumnName("MOD_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.SrcSsnTinTypCd)
                    .HasColumnName("SRC_SSN_TIN_TYP_CD")
                    .HasMaxLength(3);

                entity.HasOne(d => d.ClntSsnTinTypCdNavigation)
                    .WithMany(p => p.DmtCommErrClnt)
                    .HasForeignKey(d => d.ClntSsnTinTypCd)
                    .HasConstraintName("FK_DMT_COMM_ERR_CLNT_DMT_SSN_TIN_TYP_CD");

                entity.HasOne(d => d.Comm)
                    .WithMany(p => p.DmtCommErrClnt)
                    .HasForeignKey(d => d.CommId)                    
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DMT_COMM_ERR_CLNT_DMT_COMM_ERR");
            });

            modelBuilder.Entity<DmtCommMsg>(entity =>
            {
                entity.HasKey(e => e.CommMsgId);

                entity.ToTable("DMT_COMM_MSG");

                entity.Property(e => e.CommMsgId)
                    .HasColumnName("COMM_MSG_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccptInd).HasColumnName("ACCPT_IND");

                entity.Property(e => e.CommId).HasColumnName("COMM_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.MsgCd)
                    .IsRequired()
                    .HasColumnName("MSG_CD")
                    .HasMaxLength(25);

                entity.Property(e => e.MsgTxt)
                    .HasColumnName("MSG_TXT")
                    .HasMaxLength(4000);

                entity.Property(e => e.MsgTypCd)
                    .HasColumnName("MSG_TYP_CD")
                    .HasMaxLength(10);

                entity.Property(e => e.TechMsgTxt)
                    .HasColumnName("TECH_MSG_TXT")
                    .HasMaxLength(4000);

                entity.HasOne(d => d.MsgCdNavigation)
                    .WithMany(p => p.DmtCommMsg)
                    .HasForeignKey(d => d.MsgCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_MSG_DMT_MSG_CD");

                entity.HasOne(d => d.MsgTypCdNavigation)
                    .WithMany(p => p.DmtCommMsg)
                    .HasForeignKey(d => d.MsgTypCd)
                    .HasConstraintName("FK_DMT_COMM_MSG_DMT_MSG_TYP_CD");
            });

            modelBuilder.Entity<DmtMsgCd>(entity =>
            {
                entity.HasKey(e => e.MsgCd);

                entity.ToTable("DMT_MSG_CD");

                entity.Property(e => e.MsgCd)
                    .HasColumnName("MSG_CD")
                    .HasMaxLength(25);

                entity.Property(e => e.AccptInd).HasColumnName("ACCPT_IND");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.MsgTxt)
                    .IsRequired()
                    .HasColumnName("MSG_TXT")
                    .HasMaxLength(1000);

                entity.Property(e => e.MsgTypCd)
                    .IsRequired()
                    .HasColumnName("MSG_TYP_CD")
                    .HasMaxLength(10);

                entity.HasOne(d => d.MsgTypCdNavigation)
                    .WithMany(p => p.DmtMsgCd)
                    .HasForeignKey(d => d.MsgTypCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_MSG_CD_DMT_MSG_TYP_CD");
            });

            modelBuilder.Entity<DmtMsgTypCd>(entity =>
            {
                entity.HasKey(e => e.MsgTypCd);

                entity.ToTable("DMT_MSG_TYP_CD");

                entity.Property(e => e.MsgTypCd)
                    .HasColumnName("MSG_TYP_CD")
                    .HasMaxLength(10);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescTxt)
                    .IsRequired()
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(25);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");
            });

            modelBuilder.Entity<DmtPay>(entity =>
            {
                entity.HasKey(e => e.PayId);

                entity.ToTable("DMT_PAY");

                entity.Property(e => e.PayId).HasColumnName("PAY_ID");

                entity.Property(e => e.CarrId).HasColumnName("CARR_ID");

                entity.Property(e => e.ChkWireNum)
                    .HasColumnName("CHK_WIRE_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepDt).HasColumnName("DEP_DT");

                entity.Property(e => e.EftOvrAmt)
                    .HasColumnName("EFT_OVR_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ModById)
                    .HasColumnName("MOD_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.PayDt).HasColumnName("PAY_DT");

                entity.Property(e => e.StmntId)
                    .HasColumnName("STMNT_ID")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValStmntById)
                    .HasColumnName("VAL_STMNT_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ValStmntDt)
                    .HasColumnName("VAL_STMNT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ValStmntInd).HasColumnName("VAL_STMNT_IND");

                entity.HasOne(d => d.Carr)
                    .WithMany(p => p.DmtPay)
                    .HasForeignKey(d => d.CarrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PAY_DMT_CARR");
            });

            modelBuilder.Entity<DmtPayCmnt>(entity =>
            {
                entity.HasKey(e => e.PayCmntId);

                entity.ToTable("DMT_PAY_CMNT");

                entity.Property(e => e.PayCmntId).HasColumnName("PAY_CMNT_ID");

                entity.Property(e => e.CmntTxt)
                    .IsRequired()
                    .HasColumnName("CMNT_TXT")
                    .HasMaxLength(4000);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PayId).HasColumnName("PAY_ID");

                entity.HasOne(d => d.Pay)
                    .WithMany(p => p.DmtPayCmnt)
                    .HasForeignKey(d => d.PayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PAY_CMNT_DMT_PAY");
            });

            modelBuilder.Entity<DmtPremModeCd>(entity =>
            {
                entity.HasKey(e => e.PremModeCd);

                entity.ToTable("DMT_PREM_MODE_CD");

                entity.Property(e => e.PremModeCd)
                    .HasColumnName("PREM_MODE_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.CrtDt).HasColumnName("CRT_DT");

                entity.Property(e => e.DescTxt)
                    .IsRequired()
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(25);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");
            });

            modelBuilder.Entity<DmtProd>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("DMT_PROD");

                entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

                entity.Property(e => e.CarrId).HasColumnName("CARR_ID");

                entity.Property(e => e.Carrierid)
                    .HasColumnName("CARRIERID")
                    .HasMaxLength(6);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.ProdCd)
                    .IsRequired()
                    .HasColumnName("PROD_CD")
                    .HasMaxLength(25);

                entity.Property(e => e.ProdRtInd)
                    .IsRequired()
                    .HasColumnName("PROD_RT_IND")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProdTypId).HasColumnName("PROD_TYP_ID");

                entity.Property(e => e.ProdTypRtInd).HasColumnName("PROD_TYP_RT_IND");

                entity.HasOne(d => d.Carr)
                    .WithMany(p => p.DmtProd)
                    .HasForeignKey(d => d.CarrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PROD_DMT_CARR");

                entity.HasOne(d => d.ProdTyp)
                    .WithMany(p => p.DmtProd)
                    .HasForeignKey(d => d.ProdTypId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PROD_DMT_PROD_TYP");
            });

            modelBuilder.Entity<DmtProdAltName>(entity =>
            {
                entity.HasKey(e => e.ProdAltNameId)
                    .HasName("PK_PROD_ALT_NAME");

                entity.ToTable("DMT_PROD_ALT_NAME");

                entity.Property(e => e.ProdAltNameId).HasColumnName("PROD_ALT_NAME_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.DmtProdAltName)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PROD_ALT_NAME_DMT_PROD");
            });            

            modelBuilder.Entity<DmtProdRt>(entity =>
            {
                entity.HasKey(e => e.ProdRtId);

                entity.ToTable("DMT_PROD_RT");

                entity.Property(e => e.ProdRtId).HasColumnName("PROD_RT_ID");

                entity.Property(e => e.ActCd)
                    .IsRequired()
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.AgeEndNum).HasColumnName("AGE_END_NUM");

                entity.Property(e => e.AgeStartNum).HasColumnName("AGE_START_NUM");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffDt).HasColumnName("EFF_DT");

                entity.Property(e => e.ExpDt).HasColumnName("EXP_DT");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

                entity.Property(e => e.Rate)
                    .HasColumnName("RATE")
                    .HasColumnType("decimal(10, 9)");

                entity.Property(e => e.StCd)
                    .HasColumnName("ST_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.TmCd)
                    .HasColumnName("TM_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.YrEndNum).HasColumnName("YR_END_NUM");

                entity.Property(e => e.YrStartNum).HasColumnName("YR_START_NUM");

                entity.HasOne(d => d.ActCdNavigation)
                    .WithMany(p => p.DmtProdRt)
                    .HasForeignKey(d => d.ActCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PROD_RT_DMT_ACT_CD");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.DmtProdRt)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PROD_RT_DMT_PROD");

                entity.HasOne(d => d.StCdNavigation)
                    .WithMany(p => p.DmtProdRt)
                    .HasForeignKey(d => d.StCd)
                    .HasConstraintName("FK_DMT_PROD_RT_DMT_ST_CD");

                entity.HasOne(d => d.TmCdNavigation)
                    .WithMany(p => p.DmtProdRt)
                    .HasForeignKey(d => d.TmCd)
                    .HasConstraintName("FK_DMT_PROD_RT_DMT_TM_CD");
            });

            modelBuilder.Entity<DmtProdTyp>(entity =>
            {
                entity.HasKey(e => e.ProdTypId);

                entity.ToTable("DMT_PROD_TYP");

                entity.Property(e => e.ProdTypId).HasColumnName("PROD_TYP_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.ProdTypCd)
                    .IsRequired()
                    .HasColumnName("PROD_TYP_CD")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<DmtProdTypRt>(entity =>
            {
                entity.HasKey(e => e.ProdTypRtId);

                entity.ToTable("DMT_PROD_TYP_RT");

                entity.Property(e => e.ProdTypRtId).HasColumnName("PROD_TYP_RT_ID");

                entity.Property(e => e.ActCd)
                    .IsRequired()
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.AgeEndNum).HasColumnName("AGE_END_NUM");

                entity.Property(e => e.AgeStartNum).HasColumnName("AGE_START_NUM");

                entity.Property(e => e.CarrId).HasColumnName("CARR_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffDt).HasColumnName("EFF_DT");

                entity.Property(e => e.ExpDt).HasColumnName("EXP_DT");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.ProdTypId).HasColumnName("PROD_TYP_ID");

                entity.Property(e => e.Rate)
                    .HasColumnName("RATE")
                    .HasColumnType("decimal(10, 9)");

                entity.Property(e => e.StCd)
                    .HasColumnName("ST_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.TmCd)
                    .HasColumnName("TM_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.YrEndNum).HasColumnName("YR_END_NUM");

                entity.Property(e => e.YrStartNum).HasColumnName("YR_START_NUM");

                entity.HasOne(d => d.ActCdNavigation)
                    .WithMany(p => p.DmtProdTypRt)
                    .HasForeignKey(d => d.ActCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PROD_TYP_RT_DMT_ACT_CD");

                entity.HasOne(d => d.Carr)
                    .WithMany(p => p.DmtProdTypRt)
                    .HasForeignKey(d => d.CarrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PROD_TYP_RT_DMT_CARR");

                entity.HasOne(d => d.StCdNavigation)
                    .WithMany(p => p.DmtProdTypRt)
                    .HasForeignKey(d => d.StCd)
                    .HasConstraintName("FK_DMT_PROD_TYP_RT_DMT_ST_CD");

                entity.HasOne(d => d.TmCdNavigation)
                    .WithMany(p => p.DmtProdTypRt)
                    .HasForeignKey(d => d.TmCd)
                    .HasConstraintName("FK_DMT_PROD_TYP_RT_DMT_TM_CD");
            });

            modelBuilder.Entity<DmtSsnTinTypCd>(entity =>
            {
                entity.HasKey(e => e.SsnTinTypCd);

                entity.ToTable("DMT_SSN_TIN_TYP_CD");

                entity.Property(e => e.SsnTinTypCd)
                    .HasColumnName("SSN_TIN_TYP_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescTxt)
                    .IsRequired()
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(25);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");
            });

            modelBuilder.Entity<DmtStCd>(entity =>
            {
                entity.HasKey(e => e.StCd);

                entity.ToTable("DMT_ST_CD");

                entity.Property(e => e.StCd)
                    .HasColumnName("ST_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DmtStatCd>(entity =>
            {
                entity.HasKey(e => e.StatCd);

                entity.ToTable("DMT_STAT_CD");

                entity.Property(e => e.StatCd)
                    .HasColumnName("STAT_CD")
                    .HasMaxLength(1);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescTxt)
                    .IsRequired()
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(25);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");
            });            

            modelBuilder.Entity<DmtTmCd>(entity =>
            {
                entity.HasKey(e => e.TmCd);

                entity.ToTable("DMT_TM_CD");

                entity.Property(e => e.TmCd)
                    .HasColumnName("TM_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescTxt)
                    .IsRequired()
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(100);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
