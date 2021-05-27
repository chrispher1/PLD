IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_ACT_CD] (
        [ACT_CD] nvarchar(4) NOT NULL,
        [DESC_TXT] nvarchar(100) NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_ACT_CD] PRIMARY KEY ([ACT_CD])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_CARR] (
        [CARR_ID] int NOT NULL,
        [CARR_CD] nvarchar(25) NOT NULL,
        [NAME] nvarchar(100) NOT NULL,
        [CRT_DT] datetime2(0) NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2(0) NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_CARR] PRIMARY KEY ([CARR_ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_CASE_WP] (
        [CASE_WP_ID] int NOT NULL IDENTITY,
        [CASE_ID] int NOT NULL,
        [RSVP_STAFF_CD] nvarchar(3) NOT NULL,
        [COMM_ID] int NULL,
        [WP_TYP_CD] nvarchar(4) NULL,
        [WP_AMT] numeric(16,2) NULL,
        [EFF_DT] datetime NULL,
        [VOID_IND] bit NOT NULL,
        [VOID_DT] datetime NULL,
        [VOID_BY_ID] nvarchar(100) NULL,
        [APPROV_IND] bit NOT NULL,
        [APPROV_DT] datetime NULL,
        [APPROV_BY_ID] nvarchar(100) NULL,
        [CRT_DT] datetime NOT NULL DEFAULT ((getdate())),
        [CRT_BY_ID] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime NULL,
        [MOD_BY_ID] nvarchar(100) NULL,
        [STAT_CD] nvarchar(1) NULL,
        [STAT_DT] datetime NULL,
        [SYS_STAT_CD] nvarchar(1) NULL,
        [SYS_STAT_DT] datetime NULL,
        CONSTRAINT [PK_DMT_CASE_WP] PRIMARY KEY ([CASE_WP_ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_CASE_WP_CMNT] (
        [CASE_WP_CMNT_ID] int NOT NULL IDENTITY,
        [CASE_WP_ID] int NOT NULL,
        [CMNT_TXT] nvarchar(4000) NULL,
        [CRT_DT] datetime NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NULL DEFAULT (('SYSTEM')),
        CONSTRAINT [PK_DMT_CASE_WP_CMNT] PRIMARY KEY ([CASE_WP_CMNT_ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_CASE_WP_NET] (
        [CASE_WP_NET_ID] int NOT NULL IDENTITY,
        [CASE_ID] int NOT NULL,
        [WP_TYP_CD] nvarchar(4) NULL,
        [WP_NET_AMT] numeric(16,2) NULL,
        [AS_OF_DT] datetime NULL,
        [CRT_DT] datetime NOT NULL DEFAULT ((getdate())),
        [CRY_BY_ID] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        CONSTRAINT [PK_DMT_CASE_WP_NET] PRIMARY KEY ([CASE_WP_NET_ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_COMM_CMNT] (
        [COMM_CMNT_ID] int NOT NULL IDENTITY,
        [COMM_ID] int NOT NULL,
        [CMNT_TXT] nvarchar(4000) NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        CONSTRAINT [PK_DMT_COMM_CMNT] PRIMARY KEY ([COMM_CMNT_ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_MSG_TYP_CD] (
        [MSG_TYP_CD] nvarchar(10) NOT NULL,
        [DESC_TXT] nvarchar(25) NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_MSG_TYP_CD] PRIMARY KEY ([MSG_TYP_CD])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_PREM_MODE_CD] (
        [PREM_MODE_CD] nvarchar(5) NOT NULL,
        [DESC_TXT] nvarchar(25) NOT NULL,
        [CRT_DT] datetime2 NOT NULL,
        [CRT_BY] nvarchar(100) NOT NULL,
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_PREM_MODE_CD] PRIMARY KEY ([PREM_MODE_CD])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_PROD_TYP] (
        [PROD_TYP_ID] int NOT NULL IDENTITY,
        [PROD_TYP_CD] nvarchar(25) NOT NULL,
        [NAME] nvarchar(100) NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_PROD_TYP] PRIMARY KEY ([PROD_TYP_ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_SSN_TIN_TYP_CD] (
        [SSN_TIN_TYP_CD] nvarchar(3) NOT NULL,
        [DESC_TXT] nvarchar(25) NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_SSN_TIN_TYP_CD] PRIMARY KEY ([SSN_TIN_TYP_CD])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_ST_CD] (
        [ST_CD] nvarchar(3) NOT NULL,
        [NAME] nvarchar(100) NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_ST_CD] PRIMARY KEY ([ST_CD])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_STAT_CD] (
        [STAT_CD] nvarchar(1) NOT NULL,
        [DESC_TXT] nvarchar(25) NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_STAT_CD] PRIMARY KEY ([STAT_CD])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_TM_CD] (
        [TM_CD] nvarchar(4) NOT NULL,
        [DESC_TXT] nvarchar(100) NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_TM_CD] PRIMARY KEY ([TM_CD])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [User] (
        [Id] int NOT NULL IDENTITY,
        [FirstName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [BirthDate] datetime2 NULL,
        [Username] nvarchar(max) NULL,
        [PasswordHash] varbinary(max) NULL,
        [PasswordSalt] varbinary(max) NULL,
        CONSTRAINT [PK_User] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_PAY] (
        [PAY_ID] int NOT NULL IDENTITY,
        [CARR_ID] int NOT NULL,
        [PAY_DT] datetime2 NOT NULL,
        [CHK_WIRE_NUM] nvarchar(20) NULL,
        [DEP_DT] datetime2 NULL,
        [EFT_OVR_AMT] numeric(16,2) NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY_ID] nvarchar(100) NULL,
        [VAL_STMNT_IND] bit NULL,
        [VAL_STMNT_DT] datetime NULL,
        [VAL_STMNT_BY_ID] nvarchar(100) NULL,
        [STMNT_ID] datetime NULL,
        CONSTRAINT [PK_DMT_PAY] PRIMARY KEY ([PAY_ID]),
        CONSTRAINT [FK_DMT_PAY_DMT_CARR] FOREIGN KEY ([CARR_ID]) REFERENCES [DMT_CARR] ([CARR_ID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_MSG_CD] (
        [MSG_CD] nvarchar(25) NOT NULL,
        [MSG_TYP_CD] nvarchar(10) NOT NULL,
        [MSG_TXT] nvarchar(1000) NOT NULL,
        [ACCPT_IND] bit NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_MSG_CD] PRIMARY KEY ([MSG_CD]),
        CONSTRAINT [FK_DMT_MSG_CD_DMT_MSG_TYP_CD] FOREIGN KEY ([MSG_TYP_CD]) REFERENCES [DMT_MSG_TYP_CD] ([MSG_TYP_CD]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_PROD] (
        [PROD_ID] int NOT NULL IDENTITY,
        [CARR_ID] int NOT NULL,
        [PROD_TYP_ID] int NOT NULL,
        [PROD_CD] nvarchar(25) NOT NULL,
        [NAME] nvarchar(100) NOT NULL,
        [CARRIERID] nvarchar(6) NULL,
        [PROD_RT_IND] char(1) NOT NULL DEFAULT (((0))),
        [PROD_TYP_RT_IND] bit NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_PROD] PRIMARY KEY ([PROD_ID]),
        CONSTRAINT [FK_DMT_PROD_DMT_CARR] FOREIGN KEY ([CARR_ID]) REFERENCES [DMT_CARR] ([CARR_ID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_PROD_DMT_PROD_TYP] FOREIGN KEY ([PROD_TYP_ID]) REFERENCES [DMT_PROD_TYP] ([PROD_TYP_ID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_PROD_TYP_RT] (
        [PROD_TYP_RT_ID] int NOT NULL IDENTITY,
        [CARR_ID] int NOT NULL,
        [PROD_TYP_ID] int NOT NULL,
        [ST_CD] nvarchar(3) NULL,
        [EFF_DT] datetime2 NOT NULL,
        [TM_CD] nvarchar(4) NULL,
        [ACT_CD] nvarchar(4) NOT NULL,
        [YR_START_NUM] int NOT NULL,
        [YR_END_NUM] int NOT NULL,
        [AGE_START_NUM] int NULL,
        [AGE_END_NUM] int NULL,
        [RATE] decimal(10,9) NOT NULL,
        [EXP_DT] datetime2 NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_PROD_TYP_RT] PRIMARY KEY ([PROD_TYP_RT_ID]),
        CONSTRAINT [FK_DMT_PROD_TYP_RT_DMT_ACT_CD] FOREIGN KEY ([ACT_CD]) REFERENCES [DMT_ACT_CD] ([ACT_CD]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_PROD_TYP_RT_DMT_CARR] FOREIGN KEY ([CARR_ID]) REFERENCES [DMT_CARR] ([CARR_ID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_PROD_TYP_RT_DMT_ST_CD] FOREIGN KEY ([ST_CD]) REFERENCES [DMT_ST_CD] ([ST_CD]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_PROD_TYP_RT_DMT_TM_CD] FOREIGN KEY ([TM_CD]) REFERENCES [DMT_TM_CD] ([TM_CD]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_PAY_CMNT] (
        [PAY_CMNT_ID] int NOT NULL IDENTITY,
        [PAY_ID] int NOT NULL,
        [CMNT_TXT] nvarchar(4000) NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        CONSTRAINT [PK_DMT_PAY_CMNT] PRIMARY KEY ([PAY_CMNT_ID]),
        CONSTRAINT [FK_DMT_PAY_CMNT_DMT_PAY] FOREIGN KEY ([PAY_ID]) REFERENCES [DMT_PAY] ([PAY_ID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_CASE_MSG] (
        [CASE_MSG_ID] int NOT NULL,
        [CASE_ID] int NOT NULL,
        [MSG_CD] nvarchar(25) NOT NULL,
        [MSG_TYP_CD] nvarchar(10) NULL,
        [MSG_TXT] nvarchar(4000) NULL,
        [TECH_MSG_TXT] nvarchar(4000) NULL,
        [ACCPT_IND] bit NULL,
        [CRT_DT] datetime2(0) NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2(0) NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_CASE_MSG] PRIMARY KEY ([CASE_MSG_ID]),
        CONSTRAINT [FK_DMT_CASE_MSG_DMT_MSG_CD] FOREIGN KEY ([MSG_CD]) REFERENCES [DMT_MSG_CD] ([MSG_CD]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_CASE_MSG_DMT_MSG_TYP_CD] FOREIGN KEY ([MSG_TYP_CD]) REFERENCES [DMT_MSG_TYP_CD] ([MSG_TYP_CD]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_COMM_MSG] (
        [COMM_MSG_ID] int NOT NULL,
        [COMM_ID] int NOT NULL,
        [MSG_CD] nvarchar(25) NOT NULL,
        [MSG_TYP_CD] nvarchar(10) NULL,
        [MSG_TXT] nvarchar(4000) NULL,
        [TECH_MSG_TXT] nvarchar(4000) NULL,
        [ACCPT_IND] bit NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_COMM_MSG] PRIMARY KEY ([COMM_MSG_ID]),
        CONSTRAINT [FK_DMT_COMM_MSG_DMT_MSG_CD] FOREIGN KEY ([MSG_CD]) REFERENCES [DMT_MSG_CD] ([MSG_CD]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_COMM_MSG_DMT_MSG_TYP_CD] FOREIGN KEY ([MSG_TYP_CD]) REFERENCES [DMT_MSG_TYP_CD] ([MSG_TYP_CD]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_CASE] (
        [CASE_ID] int NOT NULL IDENTITY,
        [CARR_ID] int NULL,
        [PROD_ID] int NULL,
        [PROD_TYP_ID] int NULL,
        [RECORD_TYPE] nvarchar(15) NULL,
        [CASE_TYPE] nvarchar(15) NULL,
        [SL_CASE_ID] nvarchar(18) NULL,
        [APPLICATION_ID] nvarchar(12) NULL,
        [CASE_ID_C] nvarchar(20) NULL,
        [CASE_MGR_NAME] nvarchar(80) NULL,
        [DATE_ENTERED_C] datetime2(0) NULL,
        [CASE_MGR_SL_ID_C] nvarchar(18) NULL,
        [APPLICATION_TYPE] nvarchar(50) NULL,
        [STATUS] nvarchar(50) NULL,
        [SUB_STATUS] nvarchar(50) NULL,
        [STATUS_DATE_C] datetime2(0) NULL,
        [STATUS_REASON_C] nvarchar(100) NULL,
        [CARRIER_ACT_NAME] nvarchar(40) NULL,
        [CARRIER_CASEMGR_NAME] nvarchar(60) NULL,
        [CARRIER_CASEMGR_EMAIL] nvarchar(80) NULL,
        [CARRIER_CASEMGR_PHONE] nvarchar(14) NULL,
        [SL_CARRIER_CM_CONTACTID] nvarchar(18) NULL,
        [CARRIERID] nvarchar(6) NOT NULL,
        [CARRIER_UNDERWRITER_NAME] nvarchar(60) NULL,
        [CARRIER_UNDERWRITER_EMAIL] nvarchar(50) NULL,
        [CARRIER_UNDERWRITER_PHONE] nvarchar(14) NULL,
        [CARRIER_UW_ROLE] nvarchar(30) NULL,
        [CARRIER_UW_CONTACTID] nvarchar(18) NULL,
        [PRIM_INS_FIRSTNAME] nvarchar(30) NULL,
        [PRIM_INS_MIDDLENAME] nvarchar(30) NULL,
        [PRIM_INS_LASTNAME] nvarchar(30) NULL,
        [PRIM_INS_SUFFIX] nvarchar(3) NULL,
        [PRIM_INS_CITY] nvarchar(50) NULL,
        [PRIM_INS_STATE] nvarchar(2) NULL,
        [PRIM_INS_ZIP] nvarchar(10) NULL,
        [PRIM_INS_ISSUE_AGE] int NULL,
        [POLICY_NUMBER] nvarchar(30) NULL,
        [PRODUCT_TYPE] nvarchar(40) NULL,
        [PRODUCT_NAME] nvarchar(60) NULL,
        [FACE_AMT] numeric(16,2) NULL,
        [DEATH_BENEFIT_TYPE] nvarchar(30) NULL,
        [DEATH_BENEFIT_AMT] numeric(16,2) NULL,
        [COVERAGE_TYPE] nvarchar(60) NULL,
        [ISSUE_STATE] nvarchar(2) NULL,
        [ISSUE_AGE] int NULL,
        [UW_CLASS] nvarchar(60) NULL,
        [TOBACCO_USAGE] nvarchar(60) NULL,
        [PERMANENT_TABLE_RATING] nvarchar(60) NULL,
        [FLAT_EXTRA_AMOUNT] numeric(16,2) NULL,
        [FLAT_END_DATE] datetime2(0) NULL,
        [ADDITIONAL_COVERAGES_INDICATOR] nvarchar(5) NULL,
        [AMOUNT_1035] numeric(16,2) NULL,
        [CLASS_NAME] nvarchar(30) NULL,
        [COVERED_LIVES] nvarchar(25) NULL,
        [MODAL_PREMIUM] numeric(16,2) NULL,
        [PREMIUM_MODE] nvarchar(50) NULL,
        [TARGET_PREM_AMT] numeric(16,2) NULL,
        [ANNUALIZED_PREMIUM] numeric(16,2) NULL,
        [PAYMENT_METHOD] nvarchar(75) NULL,
        [CASH_WITH_APP] numeric(16,2) NULL,
        [TOTAL_CASH_WITH_APP] numeric(16,2) NULL,
        [MONEY_TRANSFER_TYPE] nvarchar(60) NULL,
        [INITIAL_PREMIUM_PAYMENT] numeric(16,2) NULL,
        [BALANCE_OF_PREMIUM_DUE] numeric(16,2) NULL,
        [EXCESS_PREMIUM] numeric(16,2) NULL,
        [WEIGHTED_PREMIUM_MEASURE] numeric(16,2) NULL,
        [APPLICATION_DATE] datetime2(0) NULL,
        [APP_SIGN_DATE] datetime2(0) NULL,
        [APP_RECIEPT_DATE] datetime2(0) NULL,
        [LAST_ACTIVITY_DATE] datetime2(0) NULL,
        [LAST_UW_ACTIVITY] nvarchar(20) NULL,
        [COMM_PAID_DATE] datetime2(0) NULL,
        [APPROVAL_DATE] datetime2(0) NULL,
        [ISSUE_DATE] datetime2(0) NULL,
        [PLACEMENT_EXP_DATE] datetime2(0) NULL,
        [POLICY_EFF_DATE] datetime2(0) NULL,
        [POLICY_PLACED_DATE] datetime2(0) NULL,
        [CRT_DT] datetime2 NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2(0) NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_CASE] PRIMARY KEY ([CASE_ID]),
        CONSTRAINT [FK_DMT_CASE_DMT_CARR] FOREIGN KEY ([CARR_ID]) REFERENCES [DMT_CARR] ([CARR_ID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_CASE_DMT_PROD] FOREIGN KEY ([PROD_ID]) REFERENCES [DMT_PROD] ([PROD_ID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_CASE_DMT_PROD_TYP] FOREIGN KEY ([PROD_TYP_ID]) REFERENCES [DMT_PROD_TYP] ([PROD_TYP_ID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_COMM] (
        [COMM_ID] int NOT NULL,
        [CARR_ID] int NOT NULL,
        [PROD_ID] int NOT NULL,
        [CASE_ID] int NULL,
        [POL_NUM] nvarchar(30) NOT NULL,
        [GRP_POL_NUM] nvarchar(30) NULL,
        [APPL_DT] datetime2 NULL,
        [IPP_DT] datetime2 NULL,
        [ISS_DT] datetime2 NULL,
        [POL_DT] datetime2 NULL,
        [ISS_ST_CD] nvarchar(3) NULL,
        [RES_ST_CD] nvarchar(3) NULL,
        [ISS_AGE_NUM] int NULL,
        [YR_NUM] int NOT NULL,
        [TM_CD] nvarchar(4) NULL,
        [ACT_CD] nvarchar(4) NOT NULL,
        [GRS_PREM_AMT] numeric(16,2) NULL,
        [COMM_PREM_AMT] numeric(16,2) NOT NULL,
        [COMM_RT] decimal(12,9) NOT NULL,
        [COMM_AMT] numeric(16,2) NOT NULL,
        [PREM_DUE_DT] datetime2 NULL,
        [PREM_MODE_CD] nvarchar(5) NULL,
        [TRANS_DT] datetime2 NULL,
        [LNK_COMM_ID] int NULL,
        [EXTRCT_DT] datetime2 NULL,
        [ORIG_PRCS_DT] datetime2 NOT NULL,
        [STAT_CD] nvarchar(1) NOT NULL,
        [STAT_DT] datetime2 NOT NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY_ID] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY_ID] nvarchar(100) NULL,
        [SRC_FILE_NAME] nvarchar(100) NULL,
        [TRNSMSN_UNIQ_ID] nvarchar(50) NULL,
        [SNDR_ID] nvarchar(10) NULL,
        [RCVR_ID] nvarchar(10) NULL,
        [SRC_CARR_CD] nvarchar(25) NULL,
        [CNTL_NUM] nvarchar(20) NULL,
        [TRANS_SEQ_NUM] int NULL,
        [COMP_IND] nvarchar(2) NULL,
        [APPL_RT] decimal(12,9) NULL,
        [EXP_COMM_RT] decimal(12,9) NULL,
        [EXP_COMM_AMT] numeric(16,2) NULL,
        [DUE_AMT] numeric(16,2) NULL,
        [ORIG_RECON_DT] datetime2 NULL,
        [LST_RECON_DT] datetime2 NULL,
        [ADJ_AMT] numeric(16,2) NULL,
        CONSTRAINT [PK_DMT_COMM] PRIMARY KEY ([COMM_ID]),
        CONSTRAINT [FK_DMT_COMM_DMT_ACT_CD] FOREIGN KEY ([ACT_CD]) REFERENCES [DMT_ACT_CD] ([ACT_CD]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_COMM_DMT_CARR] FOREIGN KEY ([CARR_ID]) REFERENCES [DMT_CARR] ([CARR_ID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_COMM_DMT_PROD] FOREIGN KEY ([PROD_ID]) REFERENCES [DMT_PROD] ([PROD_ID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_COMM_DMT_STAT_CD] FOREIGN KEY ([STAT_CD]) REFERENCES [DMT_STAT_CD] ([STAT_CD]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_COMM_ERR] (
        [COMM_ID] int NOT NULL IDENTITY,
        [CARR_ID] int NULL,
        [PROD_ID] int NULL,
        [CASE_ID] int NULL,
        [POL_NUM] nvarchar(30) NULL,
        [GRP_POL_NUM] nvarchar(30) NULL,
        [APPL_DT] datetime2 NULL,
        [IPP_DT] datetime2 NULL,
        [ISS_DT] datetime2 NULL,
        [POL_DT] datetime2 NULL,
        [ISS_ST_CD] nvarchar(3) NULL,
        [RES_ST_CD] nvarchar(3) NULL,
        [ISS_AGE_NUM] int NULL,
        [YR_NUM] int NULL,
        [TM_CD] nvarchar(4) NULL,
        [ACT_CD] nvarchar(4) NULL,
        [GRS_PREM_AMT] numeric(16,2) NULL,
        [COMM_PREM_AMT] numeric(16,2) NULL,
        [COMM_RT] decimal(12,9) NULL,
        [COMM_AMT] numeric(16,2) NULL,
        [PREM_DUE_DT] datetime2 NULL,
        [PREM_MODE_CD] nvarchar(5) NULL,
        [TRANS_DT] datetime2 NULL,
        [LNK_COMM_ID] int NULL,
        [EXTRCT_DT] datetime2 NULL,
        [ORIG_PRCS_DT] datetime2 NULL,
        [STAT_CD] nvarchar(1) NULL,
        [STAT_DT] datetime2 NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY_ID] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY_ID] nvarchar(100) NULL,
        [SRC_FILE_NAME] nvarchar(100) NULL,
        [TRNMSN_UNIQ_ID] nvarchar(50) NULL,
        [SNDR_ID] nvarchar(10) NULL,
        [RCVR_ID] nvarchar(10) NULL,
        [SRC_CARR_ID] nvarchar(25) NULL,
        [CNTL_NUM] nvarchar(20) NULL,
        [TRANS_SEQ_NUM] int NULL,
        [CUSIP_NUM] nvarchar(9) NULL,
        [SRC_COMM_OPT_CD] nvarchar(5) NULL,
        [SRC_COMM_EXT_CD] nvarchar(5) NULL,
        [SRC_PROD_TYP_CD] nvarchar(5) NULL,
        [SRC_PROD_CD] nvarchar(25) NULL,
        [SRC_TM_CD] nvarchar(5) NULL,
        [SRC_ACT_CD] nvarchar(5) NULL,
        [SRC_PREM_MODE_CD] nvarchar(15) NULL,
        [COMP_IND] nvarchar(2) NULL,
        [ASSOC_FM_IND] nvarchar(15) NULL,
        [COMM_TYP_CD] nvarchar(5) NULL,
        [COMM_EVNT_TYP_CD] nvarchar(5) NULL,
        [APPL_RT] decimal(12,9) NULL,
        [EXP_COMM_RT] decimal(12,9) NULL,
        [EXP_COMM_AMT] numeric(16,2) NULL,
        [DUE_AMT] numeric(16,2) NULL,
        [ORIG_RECON_DT] datetime2 NULL,
        [LST_RECON_DT] datetime2 NULL,
        [ADJ_AMT] numeric(16,2) NULL,
        CONSTRAINT [PK_DMT_COMM_ERR_1] PRIMARY KEY ([COMM_ID]),
        CONSTRAINT [FK_DMT_COMM_ERR_DMT_ACT_CD] FOREIGN KEY ([ACT_CD]) REFERENCES [DMT_ACT_CD] ([ACT_CD]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_COMM_ERR_DMT_CARR] FOREIGN KEY ([CARR_ID]) REFERENCES [DMT_CARR] ([CARR_ID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_COMM_ERR_DMT_PREM_MODE_CD] FOREIGN KEY ([PREM_MODE_CD]) REFERENCES [DMT_PREM_MODE_CD] ([PREM_MODE_CD]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_COMM_ERR_DMT_PROD] FOREIGN KEY ([PROD_ID]) REFERENCES [DMT_PROD] ([PROD_ID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_COMM_ERR_DMT_STAT_CD] FOREIGN KEY ([STAT_CD]) REFERENCES [DMT_STAT_CD] ([STAT_CD]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_COMM_ERR_DMT_TM_CD] FOREIGN KEY ([TM_CD]) REFERENCES [DMT_TM_CD] ([TM_CD]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_PROD_ALT_NAME] (
        [PROD_ALT_NAME_ID] int NOT NULL IDENTITY,
        [PROD_ID] int NOT NULL,
        [NAME] nvarchar(100) NOT NULL,
        [CRT_DT] datetime2(0) NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2(0) NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_PROD_ALT_NAME] PRIMARY KEY ([PROD_ALT_NAME_ID]),
        CONSTRAINT [FK_DMT_PROD_ALT_NAME_DMT_PROD] FOREIGN KEY ([PROD_ID]) REFERENCES [DMT_PROD] ([PROD_ID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_PROD_RT] (
        [PROD_RT_ID] int NOT NULL IDENTITY,
        [PROD_ID] int NOT NULL,
        [ST_CD] nvarchar(3) NULL,
        [EFF_DT] datetime2 NOT NULL,
        [TM_CD] nvarchar(4) NULL,
        [ACT_CD] nvarchar(4) NOT NULL,
        [YR_START_NUM] int NOT NULL,
        [YR_END_NUM] int NOT NULL,
        [AGE_START_NUM] int NULL,
        [AGE_END_NUM] int NULL,
        [RATE] decimal(10,9) NOT NULL,
        [EXP_DT] datetime2 NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_PROD_RT] PRIMARY KEY ([PROD_RT_ID]),
        CONSTRAINT [FK_DMT_PROD_RT_DMT_ACT_CD] FOREIGN KEY ([ACT_CD]) REFERENCES [DMT_ACT_CD] ([ACT_CD]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_PROD_RT_DMT_PROD] FOREIGN KEY ([PROD_ID]) REFERENCES [DMT_PROD] ([PROD_ID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_PROD_RT_DMT_ST_CD] FOREIGN KEY ([ST_CD]) REFERENCES [DMT_ST_CD] ([ST_CD]) ON DELETE NO ACTION,
        CONSTRAINT [FK_DMT_PROD_RT_DMT_TM_CD] FOREIGN KEY ([TM_CD]) REFERENCES [DMT_TM_CD] ([TM_CD]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_CASE_AGNT] (
        [CASE_ID] int NOT NULL,
        [AGNT_SEQ_REC_NUM] int NOT NULL,
        [FA_NAME] nvarchar(60) NULL,
        [FA_PHONE] nvarchar(14) NULL,
        [FA_EMAIL] nvarchar(50) NULL,
        [FA_ASSTNAME] nvarchar(60) NULL,
        [FA_ASST_EMAIL] nvarchar(50) NULL,
        [FA_ASST_PHONE] nvarchar(14) NULL,
        [FA_FIRM_REGION] nvarchar(3) NULL,
        [FA_NPN] nvarchar(10) NULL,
        [FA_BUSINESS_STREET_1] nvarchar(50) NULL,
        [FA_BUSINESS_STREET_2] nvarchar(50) NULL,
        [FA_BUSINESS_CITY] nvarchar(50) NULL,
        [FA_BUSINESS_STATE] nvarchar(3) NULL,
        [FA_BUSINESS_ZIP_CODE] nvarchar(10) NULL,
        [FA_BUSINESS_COUNTRY] nvarchar(3) NULL,
        [FA_LATITUDE] decimal(13,10) NULL,
        [FA_LONGTITUDE] decimal(13,10) NULL,
        [FA_POSITION] nvarchar(100) NULL,
        [FA_SL_CONTACT_ID] nvarchar(18) NULL,
        [CRT_DT] datetime2(0) NOT NULL,
        [CRT_BY] nvarchar(100) NOT NULL,
        [MOD_DT] datetime2(0) NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_CASE_AGNT] PRIMARY KEY ([CASE_ID], [AGNT_SEQ_REC_NUM]),
        CONSTRAINT [FK_DMT_CASE_AGNT_DMT_CASE] FOREIGN KEY ([CASE_ID]) REFERENCES [DMT_CASE] ([CASE_ID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_CASE_CMNT] (
        [CASE_CMNT_ID] int NOT NULL IDENTITY,
        [CASE_ID] int NOT NULL,
        [CMNT_TXT] nvarchar(4000) NOT NULL,
        [CRT_DT] datetime2(0) NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        CONSTRAINT [PK_DMT_CASE_CMNT] PRIMARY KEY ([CASE_CMNT_ID]),
        CONSTRAINT [FK_DMT_CASE_CMNT_DMT_CASE] FOREIGN KEY ([CASE_ID]) REFERENCES [DMT_CASE] ([CASE_ID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_CASE_LIFE_PARTIC] (
        [CASE_ID] int NOT NULL,
        [LIFE_PARTIC_SEQ_REC_NUM] int NOT NULL,
        [LIFE_PART_COVERAGE_NAME] nvarchar(50) NULL,
        [LIFE_PART_ROLE] nvarchar(50) NULL,
        [LIFE_PART_ISSUE_AGE] int NULL,
        [LIFE_PART_ISSUE_GENDER] nvarchar(10) NULL,
        [LIFE_PART_CLASS_NAME] nvarchar(50) NULL,
        [LIFE_PART_UW_CLASS] nvarchar(50) NULL,
        [LIFE_PART_UW_SUB_CLASS] nvarchar(50) NULL,
        [LIFE_PART_TOBACCO] nvarchar(50) NULL,
        [LIFE_PART_TEMP_RATING] nvarchar(50) NULL,
        [LIFE_PART_PERM_RATING] nvarchar(50) NULL,
        [LIFE_PART_PERM_TABLE_RATING] nvarchar(50) NULL,
        [LIFE_PART_LAST_MODIFIED_DATE] nvarchar(25) NULL,
        [LIFE_PART_SL_ID] nvarchar(18) NULL,
        [CRT_DT] datetime2(0) NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2(0) NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_CASE_LIFE_PARTIC] PRIMARY KEY ([CASE_ID], [LIFE_PARTIC_SEQ_REC_NUM]),
        CONSTRAINT [FK_DMT_CASE_LIFE_PARTIC_DMT_CASE] FOREIGN KEY ([CASE_ID]) REFERENCES [DMT_CASE] ([CASE_ID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_CASE_RSVP] (
        [CASE_ID] int NOT NULL,
        [RSVP_SEQ_REC_NUM] int NOT NULL,
        [RSVP_NAME] nvarchar(60) NULL,
        [RSVP_TERRITORY] nvarchar(25) NULL,
        [RSVP_PHONE] nvarchar(14) NULL,
        [RSVP_EMAIL] nvarchar(50) NULL,
        [RSVP_STAFF_CODE] nvarchar(3) NULL,
        [RSVP_CONTRACT_NUMBER] nvarchar(6) NULL,
        [RSVP_ROLE_NAME] nvarchar(5) NULL,
        [RSVP_SL_ID] nvarchar(18) NULL,
        [IW_NAME] nvarchar(60) NULL,
        [IW_PHONE] nvarchar(14) NULL,
        [IW_EMAIL] nvarchar(50) NULL,
        [IW_ROLE_NAME] nvarchar(20) NULL,
        [IW_SL_ID] nvarchar(18) NULL,
        [CASE_MGR_PHONE] nvarchar(14) NULL,
        [CASE_MGR_EMAIL] nvarchar(50) NULL,
        [CASE_MGR_ROLENAME] nvarchar(20) NULL,
        [CM_SL_ID] nvarchar(18) NULL,
        [CRT_DT] datetime2(0) NOT NULL DEFAULT ((getdate())),
        [CRT_BY] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2(0) NULL,
        [MOD_BY] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_CASE_RSVP] PRIMARY KEY ([CASE_ID], [RSVP_SEQ_REC_NUM]),
        CONSTRAINT [FK_DMT_CASE_RSVP_DMT_CASE] FOREIGN KEY ([CASE_ID]) REFERENCES [DMT_CASE] ([CASE_ID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_CASE_WP_RSVP] (
        [CASE_WP_RSVP_ID] int NOT NULL IDENTITY,
        [CASE_ID] int NULL,
        [RSVP_STAFF_CD] nvarchar(3) NOT NULL,
        [CRT_DT] datetime NOT NULL DEFAULT ((getdate())),
        [CRT_BY_ID] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime NULL,
        [MOD_BY_ID] nvarchar(100) NULL,
        CONSTRAINT [PK_DMT_CASE_WP_RSVP] PRIMARY KEY ([CASE_WP_RSVP_ID]),
        CONSTRAINT [FK_DMT_CASE_WP_RSVP_DMT_CASE] FOREIGN KEY ([CASE_ID]) REFERENCES [DMT_CASE] ([CASE_ID]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_COMM_AGNT] (
        [COMM_ID] int NOT NULL,
        [COMM_AGNT_SEQ_NUM] int NOT NULL,
        [AGNT_SSN_TIN_NUM] nvarchar(9) NULL,
        [AGNT_SSN_TIN_TYP_CD] nvarchar(3) NULL,
        [AGNT_NPN] nvarchar(10) NULL,
        [AGNT_CNTR_NUM] nvarchar(6) NULL,
        [AGNT_SPLIT_PCT] decimal(10,9) NULL,
        [GRS_PREM_AMT] numeric(16,2) NULL,
        [COMM_PREM_AMT] numeric(16,2) NULL,
        [COMM_RT] decimal(12,9) NULL,
        [COMM_AMT] numeric(16,2) NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY_ID] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY_ID] nvarchar(100) NULL,
        [SRC_TIN_TYP_CD] nvarchar(3) NULL,
        CONSTRAINT [PK_DMT_COMM_AGNT] PRIMARY KEY ([COMM_ID], [COMM_AGNT_SEQ_NUM]),
        CONSTRAINT [FK_DMT_COMM_AGNT_DMT_COMM_COMM_ID] FOREIGN KEY ([COMM_ID]) REFERENCES [DMT_COMM] ([COMM_ID]) ON DELETE CASCADE,
        CONSTRAINT [FK_DMT_COMM_AGNT_DMT_SSN_TIN_TYP_CD] FOREIGN KEY ([AGNT_SSN_TIN_TYP_CD]) REFERENCES [DMT_SSN_TIN_TYP_CD] ([SSN_TIN_TYP_CD]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_COMM_CLNT] (
        [COMM_ID] int NOT NULL,
        [COMM_CLNT_SEQ_NUM] int NOT NULL,
        [CLNT_SSN_TIN_NUM] nvarchar(9) NULL,
        [CLNT_SSN_TIN_TYP_CD] nvarchar(3) NULL,
        [CLNT_PRFX_NAME] nvarchar(25) NULL,
        [CLNT_FIRST_NAME] nvarchar(50) NULL,
        [CLNT_MID_NAME] nvarchar(50) NULL,
        [CLNT_LST_NAME] nvarchar(50) NULL,
        [CLNT_SFX_NAME] nvarchar(25) NULL,
        [CLNT_FULL_NAME] nvarchar(200) NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY_ID] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NOT NULL,
        [MOD_BY_ID] nvarchar(100) NULL,
        [SRC_SSN_TIN_TYP_CD] nvarchar(3) NULL,
        CONSTRAINT [PK_DMT_COMM_CLNT] PRIMARY KEY ([COMM_ID], [COMM_CLNT_SEQ_NUM]),
        CONSTRAINT [FK_DMT_COMM_CLNT_DMT_COMM_COMM_ID] FOREIGN KEY ([COMM_ID]) REFERENCES [DMT_COMM] ([COMM_ID]) ON DELETE CASCADE,
        CONSTRAINT [FK_DMT_COMM_CLNT_DMT_SSN_TIN_TYP_CD] FOREIGN KEY ([CLNT_SSN_TIN_TYP_CD]) REFERENCES [DMT_SSN_TIN_TYP_CD] ([SSN_TIN_TYP_CD]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_COMM_ERR_AGNT] (
        [COMM_ID] int NOT NULL,
        [COMM_AGNT_SEQ_NUM] int NOT NULL,
        [AGNT_SSN_TIN_NUM] nvarchar(9) NULL,
        [AGNT_SSN_TIN_TYP_CD] nvarchar(3) NULL,
        [AGNT_NPN] nvarchar(10) NULL,
        [AGNT_CNTR_NUM] nvarchar(6) NULL,
        [AGNT_SPLIT_PCT] decimal(10,9) NULL,
        [GRS_PREM_AMT] numeric(16,2) NULL,
        [COMM_PREM_AMT] numeric(16,2) NULL,
        [COMM_RT] decimal(12,9) NULL,
        [COMM_AMT] numeric(16,2) NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY_ID] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NULL,
        [MOD_BY_ID] nvarchar(100) NULL,
        [SRC_TIN_TYP_CD] nvarchar(3) NULL,
        [AGNT_CRD_NUM] nvarchar(10) NULL,
        [AGNT_DIST_ASSGN_ID] nvarchar(10) NULL,
        CONSTRAINT [PK_DMT_COMM_ERR_AGNT] PRIMARY KEY ([COMM_ID], [COMM_AGNT_SEQ_NUM]),
        CONSTRAINT [FK_DMT_COMM_ERR_AGNT_DMT_COMM_ERR] FOREIGN KEY ([COMM_ID]) REFERENCES [DMT_COMM_ERR] ([COMM_ID]) ON DELETE CASCADE,
        CONSTRAINT [FK_DMT_COMM_ERR_AGNT_DMT_SSN_TIN_TYP_CD] FOREIGN KEY ([AGNT_SSN_TIN_TYP_CD]) REFERENCES [DMT_SSN_TIN_TYP_CD] ([SSN_TIN_TYP_CD]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE TABLE [DMT_COMM_ERR_CLNT] (
        [COMM_ID] int NOT NULL,
        [COMM_CLNT_SEQ_NUM] int NOT NULL,
        [CLNT_SSN_TIN_NUM] nvarchar(9) NULL,
        [CLNT_SSN_TIN_TYP_CD] nvarchar(3) NULL,
        [CLNT_PRFX_NAME] nvarchar(25) NULL,
        [CLNT_FIRST_NAME] nvarchar(50) NULL,
        [CLNT_MID_NAME] nvarchar(50) NULL,
        [CLNT_LST_NAME] nvarchar(50) NULL,
        [CLNT_SFX_NAME] nvarchar(25) NULL,
        [CLNT_FULL_NAME] nvarchar(200) NULL,
        [CRT_DT] datetime2 NOT NULL DEFAULT ((getdate())),
        [CRT_BY_ID] nvarchar(100) NOT NULL DEFAULT (('SYSTEM')),
        [MOD_DT] datetime2 NOT NULL,
        [MOD_BY_ID] nvarchar(100) NULL,
        [SRC_SSN_TIN_TYP_CD] nvarchar(3) NULL,
        CONSTRAINT [PK_DMT_COMM_ERR_CLNT] PRIMARY KEY ([COMM_ID], [COMM_CLNT_SEQ_NUM]),
        CONSTRAINT [FK_DMT_COMM_ERR_CLNT_DMT_COMM_ERR] FOREIGN KEY ([COMM_ID]) REFERENCES [DMT_COMM_ERR] ([COMM_ID]) ON DELETE CASCADE,
        CONSTRAINT [FK_DMT_COMM_ERR_CLNT_DMT_SSN_TIN_TYP_CD] FOREIGN KEY ([CLNT_SSN_TIN_TYP_CD]) REFERENCES [DMT_SSN_TIN_TYP_CD] ([SSN_TIN_TYP_CD]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_CASE_CARR_ID] ON [DMT_CASE] ([CARR_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_CASE_PROD_ID] ON [DMT_CASE] ([PROD_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_CASE_PROD_TYP_ID] ON [DMT_CASE] ([PROD_TYP_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_CASE_CMNT_CASE_ID] ON [DMT_CASE_CMNT] ([CASE_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_CASE_MSG_MSG_CD] ON [DMT_CASE_MSG] ([MSG_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_CASE_MSG_MSG_TYP_CD] ON [DMT_CASE_MSG] ([MSG_TYP_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_CASE_WP_RSVP_CASE_ID] ON [DMT_CASE_WP_RSVP] ([CASE_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_ACT_CD] ON [DMT_COMM] ([ACT_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_CARR_ID] ON [DMT_COMM] ([CARR_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_PROD_ID] ON [DMT_COMM] ([PROD_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_STAT_CD] ON [DMT_COMM] ([STAT_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_AGNT_AGNT_SSN_TIN_TYP_CD] ON [DMT_COMM_AGNT] ([AGNT_SSN_TIN_TYP_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_CLNT_CLNT_SSN_TIN_TYP_CD] ON [DMT_COMM_CLNT] ([CLNT_SSN_TIN_TYP_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_ERR_ACT_CD] ON [DMT_COMM_ERR] ([ACT_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_ERR_PREM_MODE_CD] ON [DMT_COMM_ERR] ([PREM_MODE_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_ERR_PROD_ID] ON [DMT_COMM_ERR] ([PROD_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_ERR_STAT_CD] ON [DMT_COMM_ERR] ([STAT_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_ERR_TM_CD] ON [DMT_COMM_ERR] ([TM_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [NonClusteredIndex-20200115-124436] ON [DMT_COMM_ERR] ([CARR_ID], [COMM_ID], [POL_NUM]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_ERR_AGNT_AGNT_SSN_TIN_TYP_CD] ON [DMT_COMM_ERR_AGNT] ([AGNT_SSN_TIN_TYP_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_ERR_CLNT_CLNT_SSN_TIN_TYP_CD] ON [DMT_COMM_ERR_CLNT] ([CLNT_SSN_TIN_TYP_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_MSG_MSG_CD] ON [DMT_COMM_MSG] ([MSG_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_COMM_MSG_MSG_TYP_CD] ON [DMT_COMM_MSG] ([MSG_TYP_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_MSG_CD_MSG_TYP_CD] ON [DMT_MSG_CD] ([MSG_TYP_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PAY_CARR_ID] ON [DMT_PAY] ([CARR_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PAY_CMNT_PAY_ID] ON [DMT_PAY_CMNT] ([PAY_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PROD_CARR_ID] ON [DMT_PROD] ([CARR_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PROD_PROD_TYP_ID] ON [DMT_PROD] ([PROD_TYP_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PROD_ALT_NAME_PROD_ID] ON [DMT_PROD_ALT_NAME] ([PROD_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PROD_RT_ACT_CD] ON [DMT_PROD_RT] ([ACT_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PROD_RT_PROD_ID] ON [DMT_PROD_RT] ([PROD_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PROD_RT_ST_CD] ON [DMT_PROD_RT] ([ST_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PROD_RT_TM_CD] ON [DMT_PROD_RT] ([TM_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PROD_TYP_RT_ACT_CD] ON [DMT_PROD_TYP_RT] ([ACT_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PROD_TYP_RT_CARR_ID] ON [DMT_PROD_TYP_RT] ([CARR_ID]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PROD_TYP_RT_ST_CD] ON [DMT_PROD_TYP_RT] ([ST_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    CREATE INDEX [IX_DMT_PROD_TYP_RT_TM_CD] ON [DMT_PROD_TYP_RT] ([TM_CD]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512171717_InitializedTables')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210512171717_InitializedTables', N'5.0.5');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512172247_SeedDMTCarrTable')
BEGIN
    INSERT INTO DMT_CARR (CARR_ID, CARR_CD, NAME) VALUES (1,'AIG','AIG')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512172247_SeedDMTCarrTable')
BEGIN
    INSERT INTO DMT_CARR (CARR_ID, CARR_CD, NAME) VALUES (2,'JH','John Hancock')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512172247_SeedDMTCarrTable')
BEGIN
    INSERT INTO DMT_CARR (CARR_ID, CARR_CD, NAME) VALUES (3,'LIN','Lincoln')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512172247_SeedDMTCarrTable')
BEGIN
    INSERT INTO DMT_CARR (CARR_ID, CARR_CD, NAME) VALUES (4,'PAC','Pacific Life')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512172247_SeedDMTCarrTable')
BEGIN
    INSERT INTO DMT_CARR (CARR_ID, CARR_CD, NAME) VALUES (5,'PROT','Protective')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210512172247_SeedDMTCarrTable')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210512172247_SeedDMTCarrTable', N'5.0.5');
END;
GO

COMMIT;
GO

