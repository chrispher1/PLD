using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PLD.WebApi.Models
{
    public partial class DMTPLDContext : DbContext
    {
        public DMTPLDContext()
        {
        }

        public DMTPLDContext(DbContextOptions<DMTPLDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DmtActCd> DmtActCd { get; set; }
        public virtual DbSet<DmtAdt> DmtAdt { get; set; }
        public virtual DbSet<DmtAdtDtl> DmtAdtDtl { get; set; }
        public virtual DbSet<DmtAdtTypCd> DmtAdtTypCd { get; set; }
        public virtual DbSet<DmtCal> DmtCal { get; set; }
        public virtual DbSet<DmtCalEntry> DmtCalEntry { get; set; }
        public virtual DbSet<DmtCarr> DmtCarr { get; set; }
        public virtual DbSet<DmtCarrFbga> DmtCarrFbga { get; set; }
        public virtual DbSet<DmtCarrSchedLog> DmtCarrSchedLog { get; set; }
        public virtual DbSet<DmtCase> DmtCase { get; set; }
        public virtual DbSet<DmtCaseAddCov> DmtCaseAddCov { get; set; }
        public virtual DbSet<DmtCaseAddCovHist> DmtCaseAddCovHist { get; set; }
        public virtual DbSet<DmtCaseAgnt> DmtCaseAgnt { get; set; }
        public virtual DbSet<DmtCaseAgntHist> DmtCaseAgntHist { get; set; }
        public virtual DbSet<DmtCaseCmnt> DmtCaseCmnt { get; set; }
        public virtual DbSet<DmtCaseHist> DmtCaseHist { get; set; }
        public virtual DbSet<DmtCaseLifePartic> DmtCaseLifePartic { get; set; }
        public virtual DbSet<DmtCaseLifeParticHist> DmtCaseLifeParticHist { get; set; }
        public virtual DbSet<DmtCaseMsg> DmtCaseMsg { get; set; }
        public virtual DbSet<DmtCaseRsvp> DmtCaseRsvp { get; set; }
        public virtual DbSet<DmtCaseRsvpHist> DmtCaseRsvpHist { get; set; }
        public virtual DbSet<DmtCaseWp> DmtCaseWp { get; set; }
        public virtual DbSet<DmtCaseWpCmnt> DmtCaseWpCmnt { get; set; }
        public virtual DbSet<DmtCaseWpNet> DmtCaseWpNet { get; set; }
        public virtual DbSet<DmtCaseWpRsvp> DmtCaseWpRsvp { get; set; }
        public virtual DbSet<DmtCaseWpSnpsht> DmtCaseWpSnpsht { get; set; }
        public virtual DbSet<DmtCaseWpSnpshtHist> DmtCaseWpSnpshtHist { get; set; }
        public virtual DbSet<DmtCaserep> DmtCaserep { get; set; }
        public virtual DbSet<DmtCasestg> DmtCasestg { get; set; }
        public virtual DbSet<DmtCashRecon> DmtCashRecon { get; set; }
        public virtual DbSet<DmtCashReconCmnt> DmtCashReconCmnt { get; set; }
        public virtual DbSet<DmtCashReconPay> DmtCashReconPay { get; set; }
        public virtual DbSet<DmtCashReconStmnt> DmtCashReconStmnt { get; set; }
        public virtual DbSet<DmtComm> DmtComm { get; set; }
        public virtual DbSet<DmtCommAgnt> DmtCommAgnt { get; set; }
        public virtual DbSet<DmtCommClnt> DmtCommClnt { get; set; }
        public virtual DbSet<DmtCommCmnt> DmtCommCmnt { get; set; }
        public virtual DbSet<DmtCommErr> DmtCommErr { get; set; }
        public virtual DbSet<DmtCommErrAgnt> DmtCommErrAgnt { get; set; }
        public virtual DbSet<DmtCommErrClnt> DmtCommErrClnt { get; set; }
        public virtual DbSet<DmtCommMsg> DmtCommMsg { get; set; }
        public virtual DbSet<DmtCommStmnt> DmtCommStmnt { get; set; }
        public virtual DbSet<DmtCommWpSnpsht> DmtCommWpSnpsht { get; set; }
        public virtual DbSet<DmtCommWpSnpshtHist> DmtCommWpSnpshtHist { get; set; }
        public virtual DbSet<DmtCusipProdMap> DmtCusipProdMap { get; set; }
        public virtual DbSet<DmtFb> DmtFb { get; set; }
        public virtual DbSet<DmtFbga> DmtFbga { get; set; }
        public virtual DbSet<DmtFeed> DmtFeed { get; set; }
        public virtual DbSet<DmtFeedFile> DmtFeedFile { get; set; }
        public virtual DbSet<DmtFeedSchedLog> DmtFeedSchedLog { get; set; }
        public virtual DbSet<DmtGa> DmtGa { get; set; }
        public virtual DbSet<DmtMsgCd> DmtMsgCd { get; set; }
        public virtual DbSet<DmtMsgTypCd> DmtMsgTypCd { get; set; }
        public virtual DbSet<DmtPay> DmtPay { get; set; }
        public virtual DbSet<DmtPayCmnt> DmtPayCmnt { get; set; }
        public virtual DbSet<DmtPremModeCd> DmtPremModeCd { get; set; }
        public virtual DbSet<DmtProd> DmtProd { get; set; }
        public virtual DbSet<DmtProdAltName> DmtProdAltName { get; set; }
        public virtual DbSet<DmtProdFbga> DmtProdFbga { get; set; }
        public virtual DbSet<DmtProdRt> DmtProdRt { get; set; }
        public virtual DbSet<DmtProdTyp> DmtProdTyp { get; set; }
        public virtual DbSet<DmtProdTypRt> DmtProdTypRt { get; set; }
        public virtual DbSet<DmtPrtnr> DmtPrtnr { get; set; }
        public virtual DbSet<DmtPrtnrFeed> DmtPrtnrFeed { get; set; }
        public virtual DbSet<DmtPrtnrFeedFile> DmtPrtnrFeedFile { get; set; }
        public virtual DbSet<DmtSsnTinTypCd> DmtSsnTinTypCd { get; set; }
        public virtual DbSet<DmtStCd> DmtStCd { get; set; }
        public virtual DbSet<DmtStatCd> DmtStatCd { get; set; }
        public virtual DbSet<DmtTmActMap> DmtTmActMap { get; set; }
        public virtual DbSet<DmtTmCd> DmtTmCd { get; set; }
        public virtual DbSet<DmtValMap> DmtValMap { get; set; }
        public virtual DbSet<DmtWpCalcCd> DmtWpCalcCd { get; set; }
        public virtual DbSet<DmtWpCalcRule> DmtWpCalcRule { get; set; }
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

            modelBuilder.Entity<DmtAdt>(entity =>
            {
                entity.HasKey(e => e.AdtId);

                entity.ToTable("DMT_ADT");

                entity.Property(e => e.AdtId).HasColumnName("ADT_ID");

                entity.Property(e => e.AdtTypCd)
                    .IsRequired()
                    .HasColumnName("ADT_TYP_CD")
                    .HasMaxLength(1);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Pk1Id)
                    .HasColumnName("PK1_ID")
                    .HasMaxLength(25);

                entity.Property(e => e.Pk2Id)
                    .HasColumnName("PK2_ID")
                    .HasMaxLength(25);

                entity.Property(e => e.Pk3Id)
                    .HasColumnName("PK3_ID")
                    .HasMaxLength(25);

                entity.Property(e => e.Pk4Id)
                    .HasColumnName("PK4_ID")
                    .HasMaxLength(25);

                entity.Property(e => e.Pk5Id)
                    .HasColumnName("PK5_ID")
                    .HasMaxLength(25);

                entity.Property(e => e.Pk6Id)
                    .HasColumnName("PK6_ID")
                    .HasMaxLength(25);

                entity.Property(e => e.Pk7Id)
                    .HasColumnName("PK7_ID")
                    .HasMaxLength(25);

                entity.Property(e => e.SrcName)
                    .IsRequired()
                    .HasColumnName("SRC_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.TblName)
                    .IsRequired()
                    .HasColumnName("TBL_NAME")
                    .HasMaxLength(128);

                entity.HasOne(d => d.AdtTypCdNavigation)
                    .WithMany(p => p.DmtAdt)
                    .HasForeignKey(d => d.AdtTypCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_ADT_DMT_ADT_TYP_CD");
            });

            modelBuilder.Entity<DmtAdtDtl>(entity =>
            {
                entity.HasKey(e => e.AdtDtlId);

                entity.ToTable("DMT_ADT_DTL");

                entity.Property(e => e.AdtDtlId).HasColumnName("ADT_DTL_ID");

                entity.Property(e => e.AdtId).HasColumnName("ADT_ID");

                entity.Property(e => e.FldName)
                    .IsRequired()
                    .HasColumnName("FLD_NAME")
                    .HasMaxLength(128);

                entity.Property(e => e.NewVal)
                    .HasColumnName("NEW_VAL")
                    .HasMaxLength(4000);

                entity.Property(e => e.OldVal)
                    .HasColumnName("OLD_VAL")
                    .HasMaxLength(4000);

                entity.HasOne(d => d.Adt)
                    .WithMany(p => p.DmtAdtDtl)
                    .HasForeignKey(d => d.AdtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_ADT_DTL_DMT_ADT");
            });

            modelBuilder.Entity<DmtAdtTypCd>(entity =>
            {
                entity.HasKey(e => e.AdtTypCd);

                entity.ToTable("DMT_ADT_TYP_CD");

                entity.Property(e => e.AdtTypCd)
                    .HasColumnName("ADT_TYP_CD")
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
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(25);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");
            });

            modelBuilder.Entity<DmtCal>(entity =>
            {
                entity.HasKey(e => e.CalId);

                entity.ToTable("DMT_CAL");

                entity.Property(e => e.CalId).HasColumnName("CAL_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CsrPrvdr)
                    .HasColumnName("CSR_PRVDR")
                    .HasMaxLength(100);

                entity.Property(e => e.DescTxt)
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(500);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt).HasColumnName("MOD_DT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DmtCalEntry>(entity =>
            {
                entity.HasKey(e => e.CalEntryId);

                entity.ToTable("DMT_CAL_ENTRY");

                entity.Property(e => e.CalEntryId).HasColumnName("CAL_ENTRY_ID");

                entity.Property(e => e.CalId).HasColumnName("CAL_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescTxt)
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(4000);

                entity.Property(e => e.EndDt)
                    .HasColumnName("END_DT")
                    .HasColumnType("date");

                entity.Property(e => e.EndTm)
                    .HasColumnName("END_TM")
                    .HasColumnType("time(0)");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.PrntCalEntryId).HasColumnName("PRNT_CAL_ENTRY_ID");

                entity.Property(e => e.RruleTxt)
                    .HasColumnName("RRULE_TXT")
                    .HasMaxLength(4000);

                entity.Property(e => e.StartDt)
                    .HasColumnName("START_DT")
                    .HasColumnType("date");

                entity.Property(e => e.StartTm)
                    .HasColumnName("START_TM")
                    .HasColumnType("time(0)");

                entity.Property(e => e.SubjRefId).HasColumnName("SUBJ_REF_ID");

                entity.Property(e => e.SubjTxt)
                    .IsRequired()
                    .HasColumnName("SUBJ_TXT")
                    .HasMaxLength(500);
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

            modelBuilder.Entity<DmtCarrFbga>(entity =>
            {
                entity.HasKey(e => new { e.CarrId, e.FbId, e.GaId });

                entity.ToTable("DMT_CARR_FBGA");

                entity.Property(e => e.CarrId).HasColumnName("CARR_ID");

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.GaId).HasColumnName("GA_ID");

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

                entity.HasOne(d => d.Carr)
                    .WithMany(p => p.DmtCarrFbga)
                    .HasForeignKey(d => d.CarrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CARR_FBGA_DMT_CARR");

                entity.HasOne(d => d.Fb)
                    .WithMany(p => p.DmtCarrFbga)
                    .HasForeignKey(d => d.FbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CARR_FBGA_DMT_FB");

                entity.HasOne(d => d.Ga)
                    .WithMany(p => p.DmtCarrFbga)
                    .HasForeignKey(d => d.GaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CARR_FBGA_DMT_GA");
            });

            modelBuilder.Entity<DmtCarrSchedLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMT_CARR_SCHED_LOG");

                entity.Property(e => e.CalEntryId).HasColumnName("CAL_ENTRY_ID");

                entity.Property(e => e.CarrId).HasColumnName("CARR_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)");
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

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.FlatEndDate)
                    .HasColumnName("FLAT_END_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FlatExtraAmount)
                    .HasColumnName("FLAT_EXTRA_AMOUNT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.GaId).HasColumnName("GA_ID");

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

                entity.HasOne(d => d.Fb)
                    .WithMany(p => p.DmtCase)
                    .HasForeignKey(d => d.FbId)
                    .HasConstraintName("FK_DMT_CASE_DMT_FB");

                entity.HasOne(d => d.Ga)
                    .WithMany(p => p.DmtCase)
                    .HasForeignKey(d => d.GaId)
                    .HasConstraintName("FK_DMT_CASE_DMT_GA");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.DmtCase)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK_DMT_CASE_DMT_PROD");

                entity.HasOne(d => d.ProdTyp)
                    .WithMany(p => p.DmtCase)
                    .HasForeignKey(d => d.ProdTypId)
                    .HasConstraintName("FK_DMT_CASE_DMT_PROD_TYP");
            });

            modelBuilder.Entity<DmtCaseAddCov>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.AddCovSeqRecNum });

                entity.ToTable("DMT_CASE_ADD_COV");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.AddCovSeqRecNum).HasColumnName("ADD_COV_SEQ_REC_NUM");

                entity.Property(e => e.AddlCvgCaseNum)
                    .HasColumnName("ADDL_CVG_CASE_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.AddlCvgCoverage)
                    .HasColumnName("ADDL_CVG_COVERAGE")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCoverageLives)
                    .HasColumnName("ADDL_CVG_COVERAGE_LIVES")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCoverageType)
                    .HasColumnName("ADDL_CVG_COVERAGE_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCurrNumUnits).HasColumnName("ADDL_CVG_CURR_NUM_UNITS");

                entity.Property(e => e.AddlCvgCurrentAmt)
                    .HasColumnName("ADDL_CVG_CURRENT_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AddlCvgDeathBeneAmt)
                    .HasColumnName("ADDL_CVG_DEATH_BENE_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AddlCvgPlanName)
                    .HasColumnName("ADDL_CVG_PLAN_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgSlId)
                    .HasColumnName("ADDL_CVG_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.AddlCvgValuePerUnit)
                    .HasColumnName("ADDL_CVG_VALUE_PER_UNIT")
                    .HasMaxLength(20);

                entity.Property(e => e.AddlLastmodifiedDate)
                    .HasColumnName("ADDL_LASTMODIFIED_DATE")
                    .HasColumnType("datetime2(0)");

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

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.DmtCaseAddCov)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_ADD_COV_DMT_CASE");
            });

            modelBuilder.Entity<DmtCaseAddCovHist>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.CaseHistTs, e.AddCovSeqReqNum });

                entity.ToTable("DMT_CASE_ADD_COV_HIST");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CaseHistTs)
                    .HasColumnName("CASE_HIST_TS")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.AddCovSeqReqNum).HasColumnName("ADD_COV_SEQ_REQ_NUM");

                entity.Property(e => e.AddlCvgCaseNum)
                    .HasColumnName("ADDL_CVG_CASE_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.AddlCvgCoverage)
                    .HasColumnName("ADDL_CVG_COVERAGE")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCoverageLives)
                    .HasColumnName("ADDL_CVG_COVERAGE_LIVES")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCoverageType)
                    .HasColumnName("ADDL_CVG_COVERAGE_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCurrNumUnits).HasColumnName("ADDL_CVG_CURR_NUM_UNITS");

                entity.Property(e => e.AddlCvgCurrentAmt)
                    .HasColumnName("ADDL_CVG_CURRENT_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AddlCvgDeathBeneAmt)
                    .HasColumnName("ADDL_CVG_DEATH_BENE_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AddlCvgLastmodifiedDate)
                    .HasColumnName("ADDL_CVG_LASTMODIFIED_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.AddlCvgPlanName)
                    .HasColumnName("ADDL_CVG_PLAN_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgSlId)
                    .HasColumnName("ADDL_CVG_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.AddlCvgValuePerUnits)
                    .HasColumnName("ADDL_CVG_VALUE_PER_UNITS")
                    .HasMaxLength(20);

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

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.DmtCaseAddCovHist)
                    .HasForeignKey(d => new { d.CaseId, d.CaseHistTs })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_ADD_COV_HIST_DMT_CASE_HIST");
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

            modelBuilder.Entity<DmtCaseAgntHist>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.CaseHistTs });

                entity.ToTable("DMT_CASE_AGNT_HIST");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CaseHistTs)
                    .HasColumnName("CASE_HIST_TS")
                    .HasColumnType("datetime2(0)");

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
                    .WithMany(p => p.DmtCaseAgntHist)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_AGNT_HIST_DMT_CASE");

                entity.HasOne(d => d.CaseNavigation)
                    .WithOne(p => p.DmtCaseAgntHist)
                    .HasForeignKey<DmtCaseAgntHist>(d => new { d.CaseId, d.CaseHistTs })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_AGNT_HIST_DMT_CASE_HIST");
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

            modelBuilder.Entity<DmtCaseHist>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.CaseHistTs });

                entity.ToTable("DMT_CASE_HIST");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CaseHistTs)
                    .HasColumnName("CASE_HIST_TS")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.AdditionalCoveragesIndicator)
                    .HasColumnName("ADDITIONAL_COVERAGES_INDICATOR")
                    .HasMaxLength(5);

                entity.Property(e => e.Amount1035)
                    .HasColumnName("AMOUNT_1035")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AnnualizedPremium)
                    .HasColumnName("ANNUALIZED_PREMIUM")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AppReceiptDate)
                    .HasColumnName("APP_RECEIPT_DATE")
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

                entity.Property(e => e.CarrierAcctName)
                    .HasColumnName("CARRIER_ACCT_NAME")
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
                    .HasColumnName("CARRIERID")
                    .HasMaxLength(6);

                entity.Property(e => e.CaseIdC)
                    .HasColumnName("CASE_ID_C")
                    .HasMaxLength(20);

                entity.Property(e => e.CaseMgrName)
                    .HasColumnName("CASE_MGR_NAME")
                    .HasMaxLength(80);

                entity.Property(e => e.CaseMgrSlId)
                    .HasColumnName("CASE_MGR_SL_ID")
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
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
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

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.FlatEndDate)
                    .HasColumnName("FLAT_END_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.FlatExtraAmount)
                    .HasColumnName("FLAT_EXTRA_AMOUNT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.GaId).HasColumnName("GA_ID");

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
                    .HasColumnType("datetime2(0)");

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
                    .WithMany(p => p.DmtCaseHist)
                    .HasForeignKey(d => d.CarrId)
                    .HasConstraintName("FK_DMT_CASE_HIST_DMT_CARR");

                entity.HasOne(d => d.Case)
                    .WithMany(p => p.DmtCaseHist)
                    .HasForeignKey(d => d.CaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_HIST_DMT_CASE");

                entity.HasOne(d => d.Fb)
                    .WithMany(p => p.DmtCaseHist)
                    .HasForeignKey(d => d.FbId)
                    .HasConstraintName("FK_DMT_CASE_HIST_DMT_FB");

                entity.HasOne(d => d.Ga)
                    .WithMany(p => p.DmtCaseHist)
                    .HasForeignKey(d => d.GaId)
                    .HasConstraintName("FK_DMT_CASE_HIST_DMT_GA");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.DmtCaseHist)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK_DMT_CASE_HIST_DMT_PROD");

                entity.HasOne(d => d.ProdTyp)
                    .WithMany(p => p.DmtCaseHist)
                    .HasForeignKey(d => d.ProdTypId)
                    .HasConstraintName("FK_DMT_CASE_HIST_DMT_PROD_TYP");
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

            modelBuilder.Entity<DmtCaseLifeParticHist>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.CaseHistTs, e.LifeParticSeqRecNum });

                entity.ToTable("DMT_CASE_LIFE_PARTIC_HIST");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CaseHistTs)
                    .HasColumnName("CASE_HIST_TS")
                    .HasColumnType("datetime2(0)");

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
                    .WithMany(p => p.DmtCaseLifeParticHist)
                    .HasForeignKey(d => new { d.CaseId, d.CaseHistTs })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_LIFE_PARTIC_HIST_DMT_CASE_HIST");
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

            modelBuilder.Entity<DmtCaseRsvpHist>(entity =>
            {
                entity.HasKey(e => new { e.CaseId, e.CaseHistTs, e.RsvpSeqRecNum });

                entity.ToTable("DMT_CASE_RSVP_HIST");

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CaseHistTs)
                    .HasColumnName("CASE_HIST_TS")
                    .HasColumnType("datetime2(0)");

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
                    .WithMany(p => p.DmtCaseRsvpHist)
                    .HasForeignKey(d => new { d.CaseId, d.CaseHistTs })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASE_RSVP_HIST_DMT_CASE_HIST");
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

            modelBuilder.Entity<DmtCaseWpSnpsht>(entity =>
            {
                entity.HasKey(e => e.CaseWpId);

                entity.ToTable("DMT_CASE_WP_SNPSHT");

                entity.Property(e => e.CaseWpId)
                    .HasColumnName("CASE_WP_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarrName)
                    .HasColumnName("CARR_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Carrierid)
                    .HasColumnName("CARRIERID")
                    .HasMaxLength(6);

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CaseType)
                    .HasColumnName("CASE_TYPE")
                    .HasMaxLength(15);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrtTs).HasColumnName("CRT_TS");

                entity.Property(e => e.EffDt)
                    .HasColumnName("EFF_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.RsvpContractNumber)
                    .HasColumnName("RSVP_CONTRACT_NUMBER")
                    .HasMaxLength(6);

                entity.Property(e => e.RsvpName)
                    .HasColumnName("RSVP_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.RsvpStaffCd)
                    .IsRequired()
                    .HasColumnName("RSVP_STAFF_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.WpAmt)
                    .HasColumnName("WP_AMT")
                    .HasColumnType("numeric(16, 2)");
            });

            modelBuilder.Entity<DmtCaseWpSnpshtHist>(entity =>
            {
                entity.HasKey(e => e.CaseWpId);

                entity.ToTable("DMT_CASE_WP_SNPSHT_HIST");

                entity.Property(e => e.CaseWpId)
                    .HasColumnName("CASE_WP_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarrName)
                    .HasColumnName("CARR_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Carrierid)
                    .IsRequired()
                    .HasColumnName("CARRIERID")
                    .HasMaxLength(6);

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CaseType)
                    .IsRequired()
                    .HasColumnName("CASE_TYPE")
                    .HasMaxLength(15);

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CrtTs).HasColumnName("CRT_TS");

                entity.Property(e => e.EffDt)
                    .HasColumnName("EFF_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.RsvpContractNumber)
                    .HasColumnName("RSVP_CONTRACT_NUMBER")
                    .HasMaxLength(6);

                entity.Property(e => e.RsvpName)
                    .HasColumnName("RSVP_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.RsvpStaffCd)
                    .IsRequired()
                    .HasColumnName("RSVP_STAFF_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.WpAmt)
                    .HasColumnName("WP_AMT")
                    .HasColumnType("numeric(16, 2)");
            });

            modelBuilder.Entity<DmtCaserep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMT_CASEREP");

                entity.Property(e => e.AdditionalCoverages)
                    .HasColumnName("ADDITIONAL_COVERAGES")
                    .HasMaxLength(30);

                entity.Property(e => e.AdditionalCoveragesIndicator)
                    .HasColumnName("ADDITIONAL_COVERAGES_INDICATOR")
                    .HasMaxLength(5);

                entity.Property(e => e.AddlCvgCaseNum)
                    .HasColumnName("ADDL_CVG_CASE_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.AddlCvgCoverage)
                    .HasColumnName("ADDL_CVG_COVERAGE")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCoverageLives)
                    .HasColumnName("ADDL_CVG_COVERAGE_LIVES")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCoverageType)
                    .HasColumnName("ADDL_CVG_COVERAGE_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCurrNumUnits).HasColumnName("ADDL_CVG_CURR_NUM_UNITS");

                entity.Property(e => e.AddlCvgCurrentAmt)
                    .HasColumnName("ADDL_CVG_CURRENT_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AddlCvgDeathBeneAmt)
                    .HasColumnName("ADDL_CVG_DEATH_BENE_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AddlCvgLastmodifiedDate).HasColumnName("ADDL_CVG_LASTMODIFIED_DATE");

                entity.Property(e => e.AddlCvgPlanName)
                    .HasColumnName("ADDL_CVG_PLAN_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgSlId)
                    .HasColumnName("ADDL_CVG_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.AddlCvgValuePerUnit)
                    .HasColumnName("ADDL_CVG_VALUE_PER_UNIT")
                    .HasMaxLength(20);

                entity.Property(e => e.Amount1035)
                    .HasColumnName("AMOUNT_1035")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AnnualizedPremium)
                    .HasColumnName("ANNUALIZED_PREMIUM")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AppReceiptDate).HasColumnName("APP_RECEIPT_DATE");

                entity.Property(e => e.AppSignDate).HasColumnName("APP_SIGN_DATE");

                entity.Property(e => e.ApplicationDate).HasColumnName("APPLICATION_DATE");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("APPLICATION_ID")
                    .HasMaxLength(12);

                entity.Property(e => e.ApplicationType)
                    .HasColumnName("APPLICATION_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.ApprovalDate).HasColumnName("APPROVAL_DATE");

                entity.Property(e => e.BalanceOfPremiumDue)
                    .HasColumnName("BALANCE_OF_PREMIUM_DUE")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CarrierAcctName)
                    .HasColumnName("CARRIER_ACCT_NAME")
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

                entity.Property(e => e.CarrierInfo)
                    .HasColumnName("CARRIER_INFO")
                    .HasMaxLength(30);

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
                    .HasColumnName("CARRIERID")
                    .HasMaxLength(6);

                entity.Property(e => e.CaseIdC)
                    .HasColumnName("CASE_ID_C")
                    .HasMaxLength(20);

                entity.Property(e => e.CaseMgrEmail)
                    .HasColumnName("CASE_MGR_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CaseMgrName)
                    .HasColumnName("CASE_MGR_NAME")
                    .HasMaxLength(80);

                entity.Property(e => e.CaseMgrPhone)
                    .HasColumnName("CASE_MGR_PHONE")
                    .HasMaxLength(14);

                entity.Property(e => e.CaseMgrRolename)
                    .HasColumnName("CASE_MGR_ROLENAME")
                    .HasMaxLength(20);

                entity.Property(e => e.CaseMgrSlId)
                    .HasColumnName("CASE_MGR_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.CaseStatus)
                    .HasColumnName("CASE_STATUS")
                    .HasMaxLength(20);

                entity.Property(e => e.CaseType)
                    .HasColumnName("CASE_TYPE")
                    .HasMaxLength(15);

                entity.Property(e => e.CashWithApp)
                    .HasColumnName("CASH_WITH_APP")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ClassName)
                    .HasColumnName("CLASS_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.CmSlId)
                    .HasColumnName("CM_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.CommPaidDate).HasColumnName("COMM_PAID_DATE");

                entity.Property(e => e.CoverageType)
                    .HasColumnName("COVERAGE_TYPE")
                    .HasMaxLength(60);

                entity.Property(e => e.CoveredLives)
                    .HasColumnName("COVERED_LIVES")
                    .HasMaxLength(25);

                entity.Property(e => e.DateEnteredC).HasColumnName("DATE_ENTERED_C");

                entity.Property(e => e.DeathBenefitAmt)
                    .HasColumnName("DEATH_BENEFIT_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.DeathBenefitType)
                    .HasColumnName("DEATH_BENEFIT_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.DistributionCompany)
                    .HasColumnName("DISTRIBUTION_COMPANY")
                    .HasMaxLength(30);

                entity.Property(e => e.DistributionCompany2)
                    .HasColumnName("DISTRIBUTION_COMPANY_2")
                    .HasMaxLength(30);

                entity.Property(e => e.ExcessPremium)
                    .HasColumnName("EXCESS_PREMIUM")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ExtractDt)
                    .HasColumnName("EXTRACT_DT")
                    .HasColumnType("datetime");

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

                entity.Property(e => e.FaceAmt)
                    .HasColumnName("FACE_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.FinancialAdvisorInfo)
                    .HasColumnName("FINANCIAL_ADVISOR_INFO")
                    .HasMaxLength(30);

                entity.Property(e => e.FlatEndDate).HasColumnName("FLAT_END_DATE");

                entity.Property(e => e.FlatExtraAmount)
                    .HasColumnName("FLAT_EXTRA_AMOUNT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ImportantDates)
                    .HasColumnName("IMPORTANT_DATES")
                    .HasMaxLength(25);

                entity.Property(e => e.InitialPremiumPayment)
                    .HasColumnName("INITIAL_PREMIUM_PAYMENT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.IssueAge).HasColumnName("ISSUE_AGE");

                entity.Property(e => e.IssueDate).HasColumnName("ISSUE_DATE");

                entity.Property(e => e.IssueState)
                    .HasColumnName("ISSUE_STATE")
                    .HasMaxLength(2);

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

                entity.Property(e => e.LastActivityDate).HasColumnName("LAST_ACTIVITY_DATE");

                entity.Property(e => e.LastUwActivity)
                    .HasColumnName("LAST_UW_ACTIVITY")
                    .HasMaxLength(20);

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

                entity.Property(e => e.LifeParticipant)
                    .HasColumnName("LIFE_PARTICIPANT")
                    .HasMaxLength(25);

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

                entity.Property(e => e.PlacementExpDate).HasColumnName("PLACEMENT_EXP_DATE");

                entity.Property(e => e.PolicyDetailPolicyBaseCoverage)
                    .HasColumnName("POLICY_DETAIL_POLICY_BASE_COVERAGE")
                    .HasMaxLength(50);

                entity.Property(e => e.PolicyEffDate).HasColumnName("POLICY_EFF_DATE");

                entity.Property(e => e.PolicyNumber)
                    .HasColumnName("POLICY_NUMBER")
                    .HasMaxLength(30);

                entity.Property(e => e.PolicyPlacedDate).HasColumnName("POLICY_PLACED_DATE");

                entity.Property(e => e.PremiumInfo)
                    .HasColumnName("PREMIUM_INFO")
                    .HasMaxLength(18);

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

                entity.Property(e => e.PrimaryInsured)
                    .HasColumnName("PRIMARY_INSURED")
                    .HasMaxLength(30);

                entity.Property(e => e.ProductName)
                    .HasColumnName("PRODUCT_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.ProductType)
                    .HasColumnName("PRODUCT_TYPE")
                    .HasMaxLength(40);

                entity.Property(e => e.RecordType)
                    .HasColumnName("RECORD_TYPE")
                    .HasMaxLength(15);

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

                entity.Property(e => e.SlCarrierCmContactid)
                    .HasColumnName("SL_CARRIER_CM_CONTACTID")
                    .HasMaxLength(18);

                entity.Property(e => e.SlCaseId)
                    .HasColumnName("SL_CASE_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusDateC).HasColumnName("STATUS_DATE_C");

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
            });

            modelBuilder.Entity<DmtCasestg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DMT_CASESTG");

                entity.Property(e => e.AdditionalCoverages)
                    .HasColumnName("ADDITIONAL_COVERAGES")
                    .HasMaxLength(30);

                entity.Property(e => e.AdditionalCoveragesIndicator)
                    .HasColumnName("ADDITIONAL_COVERAGES_INDICATOR")
                    .HasMaxLength(5);

                entity.Property(e => e.AddlCvgCaseNum)
                    .HasColumnName("ADDL_CVG_CASE_NUM")
                    .HasMaxLength(20);

                entity.Property(e => e.AddlCvgCoverage)
                    .HasColumnName("ADDL_CVG_COVERAGE")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCoverageLives)
                    .HasColumnName("ADDL_CVG_COVERAGE_LIVES")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCoverageType)
                    .HasColumnName("ADDL_CVG_COVERAGE_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgCurrNumUnits).HasColumnName("ADDL_CVG_CURR_NUM_UNITS");

                entity.Property(e => e.AddlCvgCurrentAmt)
                    .HasColumnName("ADDL_CVG_CURRENT_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AddlCvgDeathBeneAmt)
                    .HasColumnName("ADDL_CVG_DEATH_BENE_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AddlCvgLastmodifiedDate).HasColumnName("ADDL_CVG_LASTMODIFIED_DATE");

                entity.Property(e => e.AddlCvgPlanName)
                    .HasColumnName("ADDL_CVG_PLAN_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.AddlCvgSlId)
                    .HasColumnName("ADDL_CVG_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.AddlCvgValuePerUnit)
                    .HasColumnName("ADDL_CVG_VALUE_PER_UNIT")
                    .HasMaxLength(20);

                entity.Property(e => e.Amount1035)
                    .HasColumnName("AMOUNT_1035")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AnnualizedPremium)
                    .HasColumnName("ANNUALIZED_PREMIUM")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.AppReceiptDate).HasColumnName("APP_RECEIPT_DATE");

                entity.Property(e => e.AppSignDate).HasColumnName("APP_SIGN_DATE");

                entity.Property(e => e.ApplicationDate).HasColumnName("APPLICATION_DATE");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("APPLICATION_ID")
                    .HasMaxLength(12);

                entity.Property(e => e.ApplicationType)
                    .HasColumnName("APPLICATION_TYPE")
                    .HasMaxLength(50);

                entity.Property(e => e.ApprovalDate).HasColumnName("APPROVAL_DATE");

                entity.Property(e => e.BalanceOfPremiumDue)
                    .HasColumnName("BALANCE_OF_PREMIUM_DUE")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CarrierAcctName)
                    .HasColumnName("CARRIER_ACCT_NAME")
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

                entity.Property(e => e.CarrierInfo)
                    .HasColumnName("CARRIER_INFO")
                    .HasMaxLength(30);

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
                    .HasColumnName("CARRIERID")
                    .HasMaxLength(6);

                entity.Property(e => e.CaseIdC)
                    .HasColumnName("CASE_ID_C")
                    .HasMaxLength(20);

                entity.Property(e => e.CaseMgrEmail)
                    .HasColumnName("CASE_MGR_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CaseMgrName)
                    .HasColumnName("CASE_MGR_NAME")
                    .HasMaxLength(80);

                entity.Property(e => e.CaseMgrPhone)
                    .HasColumnName("CASE_MGR_PHONE")
                    .HasMaxLength(14);

                entity.Property(e => e.CaseMgrRolename)
                    .HasColumnName("CASE_MGR_ROLENAME")
                    .HasMaxLength(20);

                entity.Property(e => e.CaseMgrSlId)
                    .HasColumnName("CASE_MGR_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.CaseStatus)
                    .HasColumnName("CASE_STATUS")
                    .HasMaxLength(20);

                entity.Property(e => e.CaseType)
                    .HasColumnName("CASE_TYPE")
                    .HasMaxLength(15);

                entity.Property(e => e.CashWithApp)
                    .HasColumnName("CASH_WITH_APP")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ClassName)
                    .HasColumnName("CLASS_NAME")
                    .HasMaxLength(30);

                entity.Property(e => e.CmSlId)
                    .HasColumnName("CM_SL_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.CommPaidDate).HasColumnName("COMM_PAID_DATE");

                entity.Property(e => e.CoverageType)
                    .HasColumnName("COVERAGE_TYPE")
                    .HasMaxLength(60);

                entity.Property(e => e.CoveredLives)
                    .HasColumnName("COVERED_LIVES")
                    .HasMaxLength(25);

                entity.Property(e => e.DateEnteredC).HasColumnName("DATE_ENTERED_C");

                entity.Property(e => e.DeathBenefitAmt)
                    .HasColumnName("DEATH_BENEFIT_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.DeathBenefitType)
                    .HasColumnName("DEATH_BENEFIT_TYPE")
                    .HasMaxLength(30);

                entity.Property(e => e.DistributionCompany)
                    .HasColumnName("DISTRIBUTION_COMPANY")
                    .HasMaxLength(30);

                entity.Property(e => e.DistributionCompany2)
                    .HasColumnName("DISTRIBUTION_COMPANY_2")
                    .HasMaxLength(30);

                entity.Property(e => e.ExcessPremium)
                    .HasColumnName("EXCESS_PREMIUM")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ExtractDt)
                    .HasColumnName("EXTRACT_DT")
                    .HasColumnType("datetime");

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

                entity.Property(e => e.FaceAmt)
                    .HasColumnName("FACE_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.FinancialAdvisorInfo)
                    .HasColumnName("FINANCIAL_ADVISOR_INFO")
                    .HasMaxLength(30);

                entity.Property(e => e.FlatEndDate).HasColumnName("FLAT_END_DATE");

                entity.Property(e => e.FlatExtraAmount)
                    .HasColumnName("FLAT_EXTRA_AMOUNT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ImportantDates)
                    .HasColumnName("IMPORTANT_DATES")
                    .HasMaxLength(25);

                entity.Property(e => e.InitialPremiumPayment)
                    .HasColumnName("INITIAL_PREMIUM_PAYMENT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.IssueAge).HasColumnName("ISSUE_AGE");

                entity.Property(e => e.IssueDate).HasColumnName("ISSUE_DATE");

                entity.Property(e => e.IssueState)
                    .HasColumnName("ISSUE_STATE")
                    .HasMaxLength(2);

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

                entity.Property(e => e.LastActivityDate).HasColumnName("LAST_ACTIVITY_DATE");

                entity.Property(e => e.LastUwActivity)
                    .HasColumnName("LAST_UW_ACTIVITY")
                    .HasMaxLength(20);

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

                entity.Property(e => e.LifeParticipant)
                    .HasColumnName("LIFE_PARTICIPANT")
                    .HasMaxLength(25);

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

                entity.Property(e => e.PlacementExpDate).HasColumnName("PLACEMENT_EXP_DATE");

                entity.Property(e => e.PolicyDetailPolicyBaseCoverage)
                    .HasColumnName("POLICY_DETAIL_POLICY_BASE_COVERAGE")
                    .HasMaxLength(50);

                entity.Property(e => e.PolicyEffDate).HasColumnName("POLICY_EFF_DATE");

                entity.Property(e => e.PolicyNumber)
                    .HasColumnName("POLICY_NUMBER")
                    .HasMaxLength(30);

                entity.Property(e => e.PolicyPlacedDate).HasColumnName("POLICY_PLACED_DATE");

                entity.Property(e => e.PremiumInfo)
                    .HasColumnName("PREMIUM_INFO")
                    .HasMaxLength(18);

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

                entity.Property(e => e.PrimaryInsured)
                    .HasColumnName("PRIMARY_INSURED")
                    .HasMaxLength(30);

                entity.Property(e => e.ProductName)
                    .HasColumnName("PRODUCT_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.ProductType)
                    .HasColumnName("PRODUCT_TYPE")
                    .HasMaxLength(40);

                entity.Property(e => e.RecordType)
                    .HasColumnName("RECORD_TYPE")
                    .HasMaxLength(15);

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

                entity.Property(e => e.SlCarrierCmContactid)
                    .HasColumnName("SL_CARRIER_CM_CONTACTID")
                    .HasMaxLength(18);

                entity.Property(e => e.SlCaseId)
                    .HasColumnName("SL_CASE_ID")
                    .HasMaxLength(18);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusDateC).HasColumnName("STATUS_DATE_C");

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
            });

            modelBuilder.Entity<DmtCashRecon>(entity =>
            {
                entity.HasKey(e => e.CashReconId);

                entity.ToTable("DMT_CASH_RECON");

                entity.Property(e => e.CashReconId).HasColumnName("CASH_RECON_ID");

                entity.Property(e => e.AttstBalById)
                    .HasColumnName("ATTST_BAL_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.AttstBalDt)
                    .HasColumnName("ATTST_BAL_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.AttstBalInd).HasColumnName("ATTST_BAL_IND");

                entity.Property(e => e.BalAmt)
                    .HasColumnName("BAL_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CarrId).HasColumnName("CARR_ID");

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.GaId).HasColumnName("GA_ID");

                entity.Property(e => e.ModById)
                    .HasColumnName("MOD_BY_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaySumAmt)
                    .HasColumnName("PAY_SUM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.StmntSumAmt)
                    .HasColumnName("STMNT_SUM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.HasOne(d => d.Carr)
                    .WithMany(p => p.DmtCashRecon)
                    .HasForeignKey(d => d.CarrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASH_RECON_DMT_CARR");

                entity.HasOne(d => d.Fb)
                    .WithMany(p => p.DmtCashRecon)
                    .HasForeignKey(d => d.FbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASH_RECON_DMT_FB");

                entity.HasOne(d => d.Ga)
                    .WithMany(p => p.DmtCashRecon)
                    .HasForeignKey(d => d.GaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASH_RECON_DMT_GA");
            });

            modelBuilder.Entity<DmtCashReconCmnt>(entity =>
            {
                entity.HasKey(e => e.CashReconCmntId);

                entity.ToTable("DMT_CASH_RECON_CMNT");

                entity.Property(e => e.CashReconCmntId).HasColumnName("CASH_RECON_CMNT_ID");

                entity.Property(e => e.CashReconId).HasColumnName("CASH_RECON_ID");

                entity.Property(e => e.CmntTxt)
                    .HasColumnName("CMNT_TXT")
                    .HasMaxLength(4000);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CashRecon)
                    .WithMany(p => p.DmtCashReconCmnt)
                    .HasForeignKey(d => d.CashReconId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASH_RECON_CMNT_DMT_CASH_RECON");
            });

            modelBuilder.Entity<DmtCashReconPay>(entity =>
            {
                entity.HasKey(e => new { e.CashReconId, e.PayId });

                entity.ToTable("DMT_CASH_RECON_PAY");

                entity.Property(e => e.CashReconId).HasColumnName("CASH_RECON_ID");

                entity.Property(e => e.PayId).HasColumnName("PAY_ID");

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CashRecon)
                    .WithMany(p => p.DmtCashReconPay)
                    .HasForeignKey(d => d.CashReconId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASH_RECON_PAY_DMT_CASH_RECON");

                entity.HasOne(d => d.Pay)
                    .WithMany(p => p.DmtCashReconPay)
                    .HasForeignKey(d => d.PayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASH_RECON_PAY_DMT_PAY");
            });

            modelBuilder.Entity<DmtCashReconStmnt>(entity =>
            {
                entity.HasKey(e => new { e.CashReconId, e.CommStmntId });

                entity.ToTable("DMT_CASH_RECON_STMNT");

                entity.Property(e => e.CashReconId).HasColumnName("CASH_RECON_ID");

                entity.Property(e => e.CommStmntId).HasColumnName("COMM_STMNT_ID");

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CashRecon)
                    .WithMany(p => p.DmtCashReconStmnt)
                    .HasForeignKey(d => d.CashReconId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASH_RECON_STMNT_DMT_CASH_RECON");

                entity.HasOne(d => d.CommStmnt)
                    .WithMany(p => p.DmtCashReconStmnt)
                    .HasForeignKey(d => d.CommStmntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_CASH_RECON_STMNT_DMT_COMM_STMNT");
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

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.GaId).HasColumnName("GA_ID");

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
                    .IsRequired()
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

                entity.HasOne(d => d.ActCdNavigation)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.ActCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_DMT_ACT_CD");

                entity.HasOne(d => d.Carr)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.CarrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_DMT_CARR");

                entity.HasOne(d => d.Fb)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.FbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_DMT_FB");

                entity.HasOne(d => d.Ga)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.GaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_DMT_GA");

                entity.HasOne(d => d.PremModeCdNavigation)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.PremModeCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_DMT_PREM_MODE_CD");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_DMT_PROD");

                entity.HasOne(d => d.StatCdNavigation)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.StatCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_DMT_STAT_CD");

                entity.HasOne(d => d.TmCdNavigation)
                    .WithMany(p => p.DmtComm)
                    .HasForeignKey(d => d.TmCd)
                    .HasConstraintName("FK_DMT_COMM_DMT_TM_CD");
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

                entity.HasOne(d => d.Comm)
                    .WithMany(p => p.DmtCommAgnt)
                    .HasForeignKey(d => d.CommId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_AGNT_DMT_COMM");
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

                entity.HasOne(d => d.Comm)
                    .WithMany(p => p.DmtCommClnt)
                    .HasForeignKey(d => d.CommId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_CLNT_DMT_COMM");
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
                    .HasName("NonClusteredIndex-20200115-124436");

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

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.GaId).HasColumnName("GA_ID");

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

                entity.HasOne(d => d.ActCdNavigation)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.ActCd)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_ACT_CD");

                entity.HasOne(d => d.Carr)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.CarrId)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_CARR");

                entity.HasOne(d => d.Fb)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.FbId)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_FB");

                entity.HasOne(d => d.Ga)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.GaId)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_GA");

                entity.HasOne(d => d.PremModeCdNavigation)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.PremModeCd)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_PREM_MODE_CD");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.DmtCommErr)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK_DMT_COMM_ERR_DMT_PROD");

                entity.HasOne(d => d.StatCdNavigation)
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

            modelBuilder.Entity<DmtCommStmnt>(entity =>
            {
                entity.HasKey(e => e.CommStmntId);

                entity.ToTable("DMT_COMM_STMNT");

                entity.Property(e => e.CommStmntId).HasColumnName("COMM_STMNT_ID");

                entity.Property(e => e.CarrId).HasColumnName("CARR_ID");

                entity.Property(e => e.CrtById)
                    .IsRequired()
                    .HasColumnName("CRT_BY_ID")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExtrctDt)
                    .HasColumnName("EXTRCT_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.GaId).HasColumnName("GA_ID");

                entity.Property(e => e.SndrId)
                    .HasColumnName("SNDR_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.SrcFileName)
                    .IsRequired()
                    .HasColumnName("SRC_FILE_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.SumCommAmt)
                    .HasColumnName("SUM_COMM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.SumPremAmt)
                    .HasColumnName("SUM_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.TotRecCnt).HasColumnName("TOT_REC_CNT");

                entity.HasOne(d => d.Carr)
                    .WithMany(p => p.DmtCommStmnt)
                    .HasForeignKey(d => d.CarrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_STMNT_DMT_CARR");

                entity.HasOne(d => d.Fb)
                    .WithMany(p => p.DmtCommStmnt)
                    .HasForeignKey(d => d.FbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_STMNT_DMT_FB");

                entity.HasOne(d => d.Ga)
                    .WithMany(p => p.DmtCommStmnt)
                    .HasForeignKey(d => d.GaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_COMM_STMNT_DMT_GA");
            });

            modelBuilder.Entity<DmtCommWpSnpsht>(entity =>
            {
                entity.HasKey(e => e.CommWpSnpshtId);

                entity.ToTable("DMT_COMM_WP_SNPSHT");

                entity.Property(e => e.CommWpSnpshtId)
                    .HasColumnName("COMM_WP_SNPSHT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.AgntCntrNum)
                    .HasColumnName("AGNT_CNTR_NUM")
                    .HasMaxLength(6);

                entity.Property(e => e.AgntNpn)
                    .HasColumnName("AGNT_NPN")
                    .HasMaxLength(10);

                entity.Property(e => e.AgntSplitPct)
                    .HasColumnName("AGNT_SPLIT_PCT")
                    .HasColumnType("numeric(10, 9)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CarrName)
                    .HasColumnName("CARR_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Carrierid)
                    .HasColumnName("CARRIERID")
                    .HasMaxLength(6);

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CaseType)
                    .IsRequired()
                    .HasColumnName("CASE_TYPE")
                    .HasMaxLength(15);

                entity.Property(e => e.CaseWpId).HasColumnName("CASE_WP_ID");

                entity.Property(e => e.CommAmt)
                    .HasColumnName("COMM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommId).HasColumnName("COMM_ID");

                entity.Property(e => e.CommPremAmt)
                    .HasColumnName("COMM_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommRt)
                    .HasColumnName("COMM_RT")
                    .HasColumnType("numeric(12, 9)");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrtTs).HasColumnName("CRT_TS");

                entity.Property(e => e.EffDt)
                    .HasColumnName("EFF_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpCommAmt)
                    .HasColumnName("EXP_COMM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ExpCommRt)
                    .HasColumnName("EXP_COMM_RT")
                    .HasColumnType("numeric(12, 9)");

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.PolDt)
                    .HasColumnName("POL_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.PremModeCd)
                    .HasColumnName("PREM_MODE_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.RsvpContractNumber)
                    .HasColumnName("RSVP_CONTRACT_NUMBER")
                    .HasMaxLength(6);

                entity.Property(e => e.RsvpName)
                    .HasColumnName("RSVP_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.RsvpStaffCd)
                    .IsRequired()
                    .HasColumnName("RSVP_STAFF_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.TransDt)
                    .HasColumnName("TRANS_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.WpAmt)
                    .HasColumnName("WP_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.YrNum).HasColumnName("YR_NUM");
            });

            modelBuilder.Entity<DmtCommWpSnpshtHist>(entity =>
            {
                entity.HasKey(e => e.CommWpSnpshtId);

                entity.ToTable("DMT_COMM_WP_SNPSHT_HIST");

                entity.Property(e => e.CommWpSnpshtId)
                    .HasColumnName("COMM_WP_SNPSHT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.AgntCntrNum)
                    .HasColumnName("AGNT_CNTR_NUM")
                    .HasMaxLength(6);

                entity.Property(e => e.AgntNpn)
                    .HasColumnName("AGNT_NPN")
                    .HasMaxLength(10);

                entity.Property(e => e.AgntSplitPct)
                    .HasColumnName("AGNT_SPLIT_PCT")
                    .HasColumnType("numeric(10, 9)");

                entity.Property(e => e.CarrName)
                    .HasColumnName("CARR_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Carrierid)
                    .HasColumnName("CARRIERID")
                    .HasMaxLength(6);

                entity.Property(e => e.CaseId).HasColumnName("CASE_ID");

                entity.Property(e => e.CaseType)
                    .IsRequired()
                    .HasColumnName("CASE_TYPE")
                    .HasMaxLength(15);

                entity.Property(e => e.CaseWpId).HasColumnName("CASE_WP_ID");

                entity.Property(e => e.CommAmt)
                    .HasColumnName("COMM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommId).HasColumnName("COMM_ID");

                entity.Property(e => e.CommPremAmt)
                    .HasColumnName("COMM_PREM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.CommRt)
                    .HasColumnName("COMM_RT")
                    .HasColumnType("numeric(12, 9)");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrtTs).HasColumnName("CRT_TS");

                entity.Property(e => e.EffDt)
                    .HasColumnName("EFF_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpCommAmt)
                    .HasColumnName("EXP_COMM_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ExpCommRt)
                    .HasColumnName("EXP_COMM_RT")
                    .HasColumnType("numeric(12, 9)");

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.PolDt)
                    .HasColumnName("POL_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.PremModeCd)
                    .HasColumnName("PREM_MODE_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.RsvpContractNumber)
                    .HasColumnName("RSVP_CONTRACT_NUMBER")
                    .HasMaxLength(6);

                entity.Property(e => e.RsvpName)
                    .HasColumnName("RSVP_NAME")
                    .HasMaxLength(60);

                entity.Property(e => e.RsvpStaffCd)
                    .IsRequired()
                    .HasColumnName("RSVP_STAFF_CD")
                    .HasMaxLength(3);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.TransDt)
                    .HasColumnName("TRANS_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.WpAmt)
                    .HasColumnName("WP_AMT")
                    .HasColumnType("numeric(16, 2)");

                entity.Property(e => e.YrNum).HasColumnName("YR_NUM");
            });

            modelBuilder.Entity<DmtCusipProdMap>(entity =>
            {
                entity.HasKey(e => new { e.SndrId, e.CusipNum, e.CommOptCd, e.CommExtCd, e.ProdTypCd });

                entity.ToTable("DMT_CUSIP_PROD_MAP");

                entity.Property(e => e.SndrId)
                    .HasColumnName("SNDR_ID")
                    .HasMaxLength(10);

                entity.Property(e => e.CusipNum)
                    .HasColumnName("CUSIP_NUM")
                    .HasMaxLength(9);

                entity.Property(e => e.CommOptCd)
                    .HasColumnName("COMM_OPT_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.CommExtCd)
                    .HasColumnName("COMM_EXT_CD")
                    .HasMaxLength(10);

                entity.Property(e => e.ProdTypCd)
                    .HasColumnName("PROD_TYP_CD")
                    .HasMaxLength(10);

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

                entity.Property(e => e.ProdId).HasColumnName("PROD_ID");
            });

            modelBuilder.Entity<DmtFb>(entity =>
            {
                entity.HasKey(e => e.FbId);

                entity.ToTable("DMT_FB");

                entity.Property(e => e.FbId)
                    .HasColumnName("FB_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FbCd)
                    .IsRequired()
                    .HasColumnName("FB_CD")
                    .HasMaxLength(25);

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

            modelBuilder.Entity<DmtFbga>(entity =>
            {
                entity.HasKey(e => new { e.FbId, e.GaId });

                entity.ToTable("DMT_FBGA");

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.GaId).HasColumnName("GA_ID");

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

                entity.HasOne(d => d.Fb)
                    .WithMany(p => p.DmtFbga)
                    .HasForeignKey(d => d.FbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_FBGA_DMT_FB");

                entity.HasOne(d => d.Ga)
                    .WithMany(p => p.DmtFbga)
                    .HasForeignKey(d => d.GaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_FBGA_DMT_GA");
            });

            modelBuilder.Entity<DmtFeed>(entity =>
            {
                entity.HasKey(e => e.FeedId);

                entity.ToTable("DMT_FEED");

                entity.Property(e => e.FeedId).HasColumnName("FEED_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrtnrFeedId).HasColumnName("PRTNR_FEED_ID");

                entity.HasOne(d => d.PrtnrFeed)
                    .WithMany(p => p.DmtFeed)
                    .HasForeignKey(d => d.PrtnrFeedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_FEED_DMT_PRTNR_FEED");
            });

            modelBuilder.Entity<DmtFeedFile>(entity =>
            {
                entity.HasKey(e => e.FeedFileId);

                entity.ToTable("DMT_FEED_FILE");

                entity.Property(e => e.FeedFileId)
                    .HasColumnName("FEED_FILE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FeedId).HasColumnName("FEED_ID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(250);

                entity.Property(e => e.PrtnrFeedFileId).HasColumnName("PRTNR_FEED_FILE_ID");

                entity.HasOne(d => d.Feed)
                    .WithMany(p => p.DmtFeedFile)
                    .HasForeignKey(d => d.FeedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_FEED_FILE_DMT_FEED");

                entity.HasOne(d => d.PrtnrFeedFile)
                    .WithMany(p => p.DmtFeedFile)
                    .HasForeignKey(d => d.PrtnrFeedFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_FEED_FILE_DMT_PRTNR_FEED_FILE");
            });

            modelBuilder.Entity<DmtFeedSchedLog>(entity =>
            {
                entity.HasKey(e => new { e.FeedId, e.CalEntryId });

                entity.ToTable("DMT_FEED_SCHED_LOG");

                entity.Property(e => e.FeedId).HasColumnName("FEED_ID");

                entity.Property(e => e.CalEntryId).HasColumnName("CAL_ENTRY_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CalEntry)
                    .WithMany(p => p.DmtFeedSchedLog)
                    .HasForeignKey(d => d.CalEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_FEED_SCHED_LOG_DMT_CAL_ENTRY");

                entity.HasOne(d => d.Feed)
                    .WithMany(p => p.DmtFeedSchedLog)
                    .HasForeignKey(d => d.FeedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_FEED_SCHED_LOG_DMT_FEED");
            });

            modelBuilder.Entity<DmtGa>(entity =>
            {
                entity.HasKey(e => e.GaId);

                entity.ToTable("DMT_GA");

                entity.Property(e => e.GaId)
                    .HasColumnName("GA_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GaCd)
                    .IsRequired()
                    .HasColumnName("GA_CD")
                    .HasMaxLength(25);

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

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.GaId).HasColumnName("GA_ID");

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

                entity.HasOne(d => d.Fb)
                    .WithMany(p => p.DmtPay)
                    .HasForeignKey(d => d.FbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PAY_DMT_FB");

                entity.HasOne(d => d.Ga)
                    .WithMany(p => p.DmtPay)
                    .HasForeignKey(d => d.GaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PAY_DMT_GA");
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

            modelBuilder.Entity<DmtProdFbga>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.FbId, e.GaId });

                entity.ToTable("DMT_PROD_FBGA");

                entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

                entity.Property(e => e.FbId).HasColumnName("FB_ID");

                entity.Property(e => e.GaId).HasColumnName("GA_ID");

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

                entity.HasOne(d => d.Fb)
                    .WithMany(p => p.DmtProdFbga)
                    .HasForeignKey(d => d.FbId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PROD_FBGA_DMT_FB");

                entity.HasOne(d => d.Ga)
                    .WithMany(p => p.DmtProdFbga)
                    .HasForeignKey(d => d.GaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PROD_FBGA_DMT_GA");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.DmtProdFbga)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PROD_FBGA_DMT_PROD");
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

            modelBuilder.Entity<DmtPrtnr>(entity =>
            {
                entity.HasKey(e => e.PrtnrId);

                entity.ToTable("DMT_PRTNR");

                entity.Property(e => e.PrtnrId).HasColumnName("PRTNR_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescTxt)
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(500);

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

                entity.Property(e => e.RcvrId).HasColumnName("RCVR_ID");

                entity.Property(e => e.SndrId).HasColumnName("SNDR_ID");
            });

            modelBuilder.Entity<DmtPrtnrFeed>(entity =>
            {
                entity.HasKey(e => e.PrtnrFeedId);

                entity.ToTable("DMT_PRTNR_FEED");

                entity.Property(e => e.PrtnrFeedId).HasColumnName("PRTNR_FEED_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescTxt)
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(500);

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

                entity.Property(e => e.PrtnrId).HasColumnName("PRTNR_ID");

                entity.Property(e => e.SrcAdptr)
                    .HasColumnName("SRC_ADPTR")
                    .HasMaxLength(100);

                entity.Property(e => e.SrcInd).HasColumnName("SRC_IND");

                entity.Property(e => e.TrgtAdptr)
                    .HasColumnName("TRGT_ADPTR")
                    .HasMaxLength(100);

                entity.Property(e => e.TrgtInd).HasColumnName("TRGT_IND");

                entity.HasOne(d => d.Prtnr)
                    .WithMany(p => p.DmtPrtnrFeed)
                    .HasForeignKey(d => d.PrtnrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PRTNR_FEED_DMT_PRTNR");
            });

            modelBuilder.Entity<DmtPrtnrFeedFile>(entity =>
            {
                entity.HasKey(e => e.PrtnrFeedFileId);

                entity.ToTable("DMT_PRTNR_FEED_FILE");

                entity.Property(e => e.PrtnrFeedFileId).HasColumnName("PRTNR_FEED_FILE_ID");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescTxt)
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(500);

                entity.Property(e => e.FileNameExt)
                    .HasColumnName("FILE_NAME_EXT")
                    .HasMaxLength(250);

                entity.Property(e => e.FileNamePttrn)
                    .IsRequired()
                    .HasColumnName("FILE_NAME_PTTRN")
                    .HasMaxLength(250);

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

                entity.Property(e => e.PathName)
                    .IsRequired()
                    .HasColumnName("PATH_NAME")
                    .HasMaxLength(250);

                entity.Property(e => e.PrtnrFeedId).HasColumnName("PRTNR_FEED_ID");

                entity.Property(e => e.ReqdInd).HasColumnName("REQD_IND");

                entity.Property(e => e.TstInd)
                    .HasColumnName("TST_IND")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.HasOne(d => d.PrtnrFeed)
                    .WithMany(p => p.DmtPrtnrFeedFile)
                    .HasForeignKey(d => d.PrtnrFeedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_PRTNR_FEED_FILE_DMT_PRTNR_FEED");
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

            modelBuilder.Entity<DmtTmActMap>(entity =>
            {
                entity.HasKey(e => new { e.CarrId, e.SrcTmCd, e.SrcActCd });

                entity.ToTable("DMT_TM_ACT_MAP");

                entity.Property(e => e.CarrId).HasColumnName("CARR_ID");

                entity.Property(e => e.SrcTmCd)
                    .HasColumnName("SRC_TM_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.SrcActCd)
                    .HasColumnName("SRC_ACT_CD")
                    .HasMaxLength(5);

                entity.Property(e => e.ActCd)
                    .IsRequired()
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.CompInd)
                    .IsRequired()
                    .HasColumnName("COMP_IND")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('N')");

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

                entity.Property(e => e.SrcTransKey)
                    .HasColumnName("SRC_TRANS_KEY")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TmCd)
                    .HasColumnName("TM_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.YrEndNum).HasColumnName("YR_END_NUM");

                entity.Property(e => e.YrStartNum).HasColumnName("YR_START_NUM");

                entity.HasOne(d => d.ActCdNavigation)
                    .WithMany(p => p.DmtTmActMap)
                    .HasForeignKey(d => d.ActCd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DMT_TM_ACT_MAP_DMT_ACT_CD");

                entity.HasOne(d => d.TmCdNavigation)
                    .WithMany(p => p.DmtTmActMap)
                    .HasForeignKey(d => d.TmCd)
                    .HasConstraintName("FK_DMT_TM_ACT_MAP_DMT_TM_CD");
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

            modelBuilder.Entity<DmtValMap>(entity =>
            {
                entity.HasKey(e => new { e.SrcName, e.SrcVal, e.TrgtName });

                entity.ToTable("DMT_VAL_MAP");

                entity.Property(e => e.SrcName)
                    .HasColumnName("SRC_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.SrcVal)
                    .HasColumnName("SRC_VAL")
                    .HasMaxLength(100);

                entity.Property(e => e.TrgtName)
                    .HasColumnName("TRGT_NAME")
                    .HasMaxLength(100);

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

                entity.Property(e => e.TrgtVal)
                    .IsRequired()
                    .HasColumnName("TRGT_VAL")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DmtWpCalcCd>(entity =>
            {
                entity.HasKey(e => e.WpCalcCd);

                entity.ToTable("DMT_WP_CALC_CD");

                entity.Property(e => e.WpCalcCd)
                    .HasColumnName("WP_CALC_CD")
                    .HasMaxLength(10);

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DescTxt)
                    .IsRequired()
                    .HasColumnName("DESC_TXT")
                    .HasMaxLength(100);

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DmtWpCalcRule>(entity =>
            {
                entity.HasKey(e => e.WpCalcRuleId);

                entity.ToTable("DMT_WP_CALC_RULE");

                entity.Property(e => e.WpCalcRuleId).HasColumnName("WP_CALC_RULE_ID");

                entity.Property(e => e.ActCd)
                    .HasColumnName("ACT_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.CaseAmtName)
                    .HasColumnName("CASE_AMT_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.CommAmtName)
                    .HasColumnName("COMM_AMT_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.CompInd).HasColumnName("COMP_IND");

                entity.Property(e => e.CrtBy)
                    .IsRequired()
                    .HasColumnName("CRT_BY")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CrtDt)
                    .HasColumnName("CRT_DT")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FactorRt)
                    .HasColumnName("FACTOR_RT")
                    .HasColumnType("decimal(12, 9)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModBy)
                    .HasColumnName("MOD_BY")
                    .HasMaxLength(100);

                entity.Property(e => e.ModDt)
                    .HasColumnName("MOD_DT")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProdId).HasColumnName("PROD_ID");

                entity.Property(e => e.ProdTypId).HasColumnName("PROD_TYP_ID");

                entity.Property(e => e.TmCd)
                    .HasColumnName("TM_CD")
                    .HasMaxLength(4);

                entity.Property(e => e.WpCalcCd)
                    .IsRequired()
                    .HasColumnName("WP_CALC_CD")
                    .HasMaxLength(10);

                entity.Property(e => e.YrInfrcNum).HasColumnName("YR_INFRC_NUM");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
