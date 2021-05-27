using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PLD.DataAccess.Migrations
{
    public partial class InitializedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DMT_ACT_CD",
                columns: table => new
                {
                    ACT_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DESC_TXT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_ACT_CD", x => x.ACT_CD);
                });

            migrationBuilder.CreateTable(
                name: "DMT_CARR",
                columns: table => new
                {
                    CARR_ID = table.Column<int>(type: "int", nullable: false),
                    CARR_CD = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_CARR", x => x.CARR_ID);
                });

            migrationBuilder.CreateTable(
                name: "DMT_CASE_WP",
                columns: table => new
                {
                    CASE_WP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CASE_ID = table.Column<int>(type: "int", nullable: false),
                    RSVP_STAFF_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    COMM_ID = table.Column<int>(type: "int", nullable: true),
                    WP_TYP_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    WP_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    EFF_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    VOID_IND = table.Column<bool>(type: "bit", nullable: false),
                    VOID_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    VOID_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    APPROV_IND = table.Column<bool>(type: "bit", nullable: false),
                    APPROV_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    APPROV_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    MOD_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    STAT_CD = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    STAT_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    SYS_STAT_CD = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    SYS_STAT_DT = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_CASE_WP", x => x.CASE_WP_ID);
                });

            migrationBuilder.CreateTable(
                name: "DMT_CASE_WP_CMNT",
                columns: table => new
                {
                    CASE_WP_CMNT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CASE_WP_ID = table.Column<int>(type: "int", nullable: false),
                    CMNT_TXT = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('SYSTEM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_CASE_WP_CMNT", x => x.CASE_WP_CMNT_ID);
                });

            migrationBuilder.CreateTable(
                name: "DMT_CASE_WP_NET",
                columns: table => new
                {
                    CASE_WP_NET_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CASE_ID = table.Column<int>(type: "int", nullable: false),
                    WP_TYP_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    WP_NET_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    AS_OF_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CRY_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_CASE_WP_NET", x => x.CASE_WP_NET_ID);
                });

            migrationBuilder.CreateTable(
                name: "DMT_COMM_CMNT",
                columns: table => new
                {
                    COMM_CMNT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COMM_ID = table.Column<int>(type: "int", nullable: false),
                    CMNT_TXT = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_COMM_CMNT", x => x.COMM_CMNT_ID);
                });

            migrationBuilder.CreateTable(
                name: "DMT_MSG_TYP_CD",
                columns: table => new
                {
                    MSG_TYP_CD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DESC_TXT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_MSG_TYP_CD", x => x.MSG_TYP_CD);
                });

            migrationBuilder.CreateTable(
                name: "DMT_PREM_MODE_CD",
                columns: table => new
                {
                    PREM_MODE_CD = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    DESC_TXT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_PREM_MODE_CD", x => x.PREM_MODE_CD);
                });

            migrationBuilder.CreateTable(
                name: "DMT_PROD_TYP",
                columns: table => new
                {
                    PROD_TYP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROD_TYP_CD = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_PROD_TYP", x => x.PROD_TYP_ID);
                });

            migrationBuilder.CreateTable(
                name: "DMT_SSN_TIN_TYP_CD",
                columns: table => new
                {
                    SSN_TIN_TYP_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    DESC_TXT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_SSN_TIN_TYP_CD", x => x.SSN_TIN_TYP_CD);
                });

            migrationBuilder.CreateTable(
                name: "DMT_ST_CD",
                columns: table => new
                {
                    ST_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_ST_CD", x => x.ST_CD);
                });

            migrationBuilder.CreateTable(
                name: "DMT_STAT_CD",
                columns: table => new
                {
                    STAT_CD = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DESC_TXT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_STAT_CD", x => x.STAT_CD);
                });

            migrationBuilder.CreateTable(
                name: "DMT_TM_CD",
                columns: table => new
                {
                    TM_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DESC_TXT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_TM_CD", x => x.TM_CD);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DMT_PAY",
                columns: table => new
                {
                    PAY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARR_ID = table.Column<int>(type: "int", nullable: false),
                    PAY_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CHK_WIRE_NUM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DEP_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EFT_OVR_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VAL_STMNT_IND = table.Column<bool>(type: "bit", nullable: true),
                    VAL_STMNT_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    VAL_STMNT_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    STMNT_ID = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_PAY", x => x.PAY_ID);
                    table.ForeignKey(
                        name: "FK_DMT_PAY_DMT_CARR",
                        column: x => x.CARR_ID,
                        principalTable: "DMT_CARR",
                        principalColumn: "CARR_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_MSG_CD",
                columns: table => new
                {
                    MSG_CD = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MSG_TYP_CD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MSG_TXT = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ACCPT_IND = table.Column<bool>(type: "bit", nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_MSG_CD", x => x.MSG_CD);
                    table.ForeignKey(
                        name: "FK_DMT_MSG_CD_DMT_MSG_TYP_CD",
                        column: x => x.MSG_TYP_CD,
                        principalTable: "DMT_MSG_TYP_CD",
                        principalColumn: "MSG_TYP_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_PROD",
                columns: table => new
                {
                    PROD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARR_ID = table.Column<int>(type: "int", nullable: false),
                    PROD_TYP_ID = table.Column<int>(type: "int", nullable: false),
                    PROD_CD = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CARRIERID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    PROD_RT_IND = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "((0))"),
                    PROD_TYP_RT_IND = table.Column<bool>(type: "bit", nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_PROD", x => x.PROD_ID);
                    table.ForeignKey(
                        name: "FK_DMT_PROD_DMT_CARR",
                        column: x => x.CARR_ID,
                        principalTable: "DMT_CARR",
                        principalColumn: "CARR_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_PROD_DMT_PROD_TYP",
                        column: x => x.PROD_TYP_ID,
                        principalTable: "DMT_PROD_TYP",
                        principalColumn: "PROD_TYP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_PROD_TYP_RT",
                columns: table => new
                {
                    PROD_TYP_RT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARR_ID = table.Column<int>(type: "int", nullable: false),
                    PROD_TYP_ID = table.Column<int>(type: "int", nullable: false),
                    ST_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    EFF_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TM_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ACT_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    YR_START_NUM = table.Column<int>(type: "int", nullable: false),
                    YR_END_NUM = table.Column<int>(type: "int", nullable: false),
                    AGE_START_NUM = table.Column<int>(type: "int", nullable: true),
                    AGE_END_NUM = table.Column<int>(type: "int", nullable: true),
                    RATE = table.Column<decimal>(type: "decimal(10,9)", nullable: false),
                    EXP_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_PROD_TYP_RT", x => x.PROD_TYP_RT_ID);
                    table.ForeignKey(
                        name: "FK_DMT_PROD_TYP_RT_DMT_ACT_CD",
                        column: x => x.ACT_CD,
                        principalTable: "DMT_ACT_CD",
                        principalColumn: "ACT_CD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_PROD_TYP_RT_DMT_CARR",
                        column: x => x.CARR_ID,
                        principalTable: "DMT_CARR",
                        principalColumn: "CARR_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_PROD_TYP_RT_DMT_ST_CD",
                        column: x => x.ST_CD,
                        principalTable: "DMT_ST_CD",
                        principalColumn: "ST_CD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_PROD_TYP_RT_DMT_TM_CD",
                        column: x => x.TM_CD,
                        principalTable: "DMT_TM_CD",
                        principalColumn: "TM_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_PAY_CMNT",
                columns: table => new
                {
                    PAY_CMNT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PAY_ID = table.Column<int>(type: "int", nullable: false),
                    CMNT_TXT = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_PAY_CMNT", x => x.PAY_CMNT_ID);
                    table.ForeignKey(
                        name: "FK_DMT_PAY_CMNT_DMT_PAY",
                        column: x => x.PAY_ID,
                        principalTable: "DMT_PAY",
                        principalColumn: "PAY_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_CASE_MSG",
                columns: table => new
                {
                    CASE_MSG_ID = table.Column<int>(type: "int", nullable: false),
                    CASE_ID = table.Column<int>(type: "int", nullable: false),
                    MSG_CD = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MSG_TYP_CD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MSG_TXT = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    TECH_MSG_TXT = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ACCPT_IND = table.Column<bool>(type: "bit", nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_CASE_MSG", x => x.CASE_MSG_ID);
                    table.ForeignKey(
                        name: "FK_DMT_CASE_MSG_DMT_MSG_CD",
                        column: x => x.MSG_CD,
                        principalTable: "DMT_MSG_CD",
                        principalColumn: "MSG_CD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_CASE_MSG_DMT_MSG_TYP_CD",
                        column: x => x.MSG_TYP_CD,
                        principalTable: "DMT_MSG_TYP_CD",
                        principalColumn: "MSG_TYP_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_COMM_MSG",
                columns: table => new
                {
                    COMM_MSG_ID = table.Column<int>(type: "int", nullable: false),
                    COMM_ID = table.Column<int>(type: "int", nullable: false),
                    MSG_CD = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MSG_TYP_CD = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    MSG_TXT = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    TECH_MSG_TXT = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    ACCPT_IND = table.Column<bool>(type: "bit", nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_COMM_MSG", x => x.COMM_MSG_ID);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_MSG_DMT_MSG_CD",
                        column: x => x.MSG_CD,
                        principalTable: "DMT_MSG_CD",
                        principalColumn: "MSG_CD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_MSG_DMT_MSG_TYP_CD",
                        column: x => x.MSG_TYP_CD,
                        principalTable: "DMT_MSG_TYP_CD",
                        principalColumn: "MSG_TYP_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_CASE",
                columns: table => new
                {
                    CASE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARR_ID = table.Column<int>(type: "int", nullable: true),
                    PROD_ID = table.Column<int>(type: "int", nullable: true),
                    PROD_TYP_ID = table.Column<int>(type: "int", nullable: true),
                    RECORD_TYPE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CASE_TYPE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SL_CASE_ID = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    APPLICATION_ID = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    CASE_ID_C = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CASE_MGR_NAME = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    DATE_ENTERED_C = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    CASE_MGR_SL_ID_C = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    APPLICATION_TYPE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SUB_STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS_DATE_C = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    STATUS_REASON_C = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CARRIER_ACT_NAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CARRIER_CASEMGR_NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CARRIER_CASEMGR_EMAIL = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    CARRIER_CASEMGR_PHONE = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    SL_CARRIER_CM_CONTACTID = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    CARRIERID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    CARRIER_UNDERWRITER_NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    CARRIER_UNDERWRITER_EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CARRIER_UNDERWRITER_PHONE = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    CARRIER_UW_ROLE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CARRIER_UW_CONTACTID = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    PRIM_INS_FIRSTNAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRIM_INS_MIDDLENAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRIM_INS_LASTNAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRIM_INS_SUFFIX = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    PRIM_INS_CITY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PRIM_INS_STATE = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    PRIM_INS_ZIP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PRIM_INS_ISSUE_AGE = table.Column<int>(type: "int", nullable: true),
                    POLICY_NUMBER = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PRODUCT_TYPE = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    PRODUCT_NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FACE_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    DEATH_BENEFIT_TYPE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DEATH_BENEFIT_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    COVERAGE_TYPE = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ISSUE_STATE = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ISSUE_AGE = table.Column<int>(type: "int", nullable: true),
                    UW_CLASS = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    TOBACCO_USAGE = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PERMANENT_TABLE_RATING = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FLAT_EXTRA_AMOUNT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    FLAT_END_DATE = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    ADDITIONAL_COVERAGES_INDICATOR = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    AMOUNT_1035 = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    CLASS_NAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    COVERED_LIVES = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    MODAL_PREMIUM = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    PREMIUM_MODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TARGET_PREM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    ANNUALIZED_PREMIUM = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    PAYMENT_METHOD = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    CASH_WITH_APP = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    TOTAL_CASH_WITH_APP = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    MONEY_TRANSFER_TYPE = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    INITIAL_PREMIUM_PAYMENT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    BALANCE_OF_PREMIUM_DUE = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    EXCESS_PREMIUM = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    WEIGHTED_PREMIUM_MEASURE = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    APPLICATION_DATE = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    APP_SIGN_DATE = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    APP_RECIEPT_DATE = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LAST_ACTIVITY_DATE = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    LAST_UW_ACTIVITY = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    COMM_PAID_DATE = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    APPROVAL_DATE = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    ISSUE_DATE = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    PLACEMENT_EXP_DATE = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    POLICY_EFF_DATE = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    POLICY_PLACED_DATE = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_CASE", x => x.CASE_ID);
                    table.ForeignKey(
                        name: "FK_DMT_CASE_DMT_CARR",
                        column: x => x.CARR_ID,
                        principalTable: "DMT_CARR",
                        principalColumn: "CARR_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_CASE_DMT_PROD",
                        column: x => x.PROD_ID,
                        principalTable: "DMT_PROD",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_CASE_DMT_PROD_TYP",
                        column: x => x.PROD_TYP_ID,
                        principalTable: "DMT_PROD_TYP",
                        principalColumn: "PROD_TYP_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_COMM",
                columns: table => new
                {
                    COMM_ID = table.Column<int>(type: "int", nullable: false),
                    CARR_ID = table.Column<int>(type: "int", nullable: false),
                    PROD_ID = table.Column<int>(type: "int", nullable: false),
                    CASE_ID = table.Column<int>(type: "int", nullable: true),
                    POL_NUM = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GRP_POL_NUM = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    APPL_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IPP_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ISS_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    POL_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ISS_ST_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    RES_ST_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ISS_AGE_NUM = table.Column<int>(type: "int", nullable: true),
                    YR_NUM = table.Column<int>(type: "int", nullable: false),
                    TM_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ACT_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    GRS_PREM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    COMM_PREM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: false),
                    COMM_RT = table.Column<decimal>(type: "decimal(12,9)", nullable: false),
                    COMM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: false),
                    PREM_DUE_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PREM_MODE_CD = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    TRANS_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LNK_COMM_ID = table.Column<int>(type: "int", nullable: true),
                    EXTRCT_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ORIG_PRCS_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STAT_CD = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    STAT_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SRC_FILE_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TRNSMSN_UNIQ_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SNDR_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RCVR_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SRC_CARR_CD = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CNTL_NUM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TRANS_SEQ_NUM = table.Column<int>(type: "int", nullable: true),
                    COMP_IND = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    APPL_RT = table.Column<decimal>(type: "decimal(12,9)", nullable: true),
                    EXP_COMM_RT = table.Column<decimal>(type: "decimal(12,9)", nullable: true),
                    EXP_COMM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    DUE_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    ORIG_RECON_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LST_RECON_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ADJ_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_COMM", x => x.COMM_ID);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_DMT_ACT_CD",
                        column: x => x.ACT_CD,
                        principalTable: "DMT_ACT_CD",
                        principalColumn: "ACT_CD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_DMT_CARR",
                        column: x => x.CARR_ID,
                        principalTable: "DMT_CARR",
                        principalColumn: "CARR_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_DMT_PROD",
                        column: x => x.PROD_ID,
                        principalTable: "DMT_PROD",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_DMT_STAT_CD",
                        column: x => x.STAT_CD,
                        principalTable: "DMT_STAT_CD",
                        principalColumn: "STAT_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_COMM_ERR",
                columns: table => new
                {
                    COMM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CARR_ID = table.Column<int>(type: "int", nullable: true),
                    PROD_ID = table.Column<int>(type: "int", nullable: true),
                    CASE_ID = table.Column<int>(type: "int", nullable: true),
                    POL_NUM = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    GRP_POL_NUM = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    APPL_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IPP_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ISS_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    POL_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ISS_ST_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    RES_ST_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ISS_AGE_NUM = table.Column<int>(type: "int", nullable: true),
                    YR_NUM = table.Column<int>(type: "int", nullable: true),
                    TM_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ACT_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    GRS_PREM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    COMM_PREM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    COMM_RT = table.Column<decimal>(type: "decimal(12,9)", nullable: true),
                    COMM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    PREM_DUE_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PREM_MODE_CD = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    TRANS_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LNK_COMM_ID = table.Column<int>(type: "int", nullable: true),
                    EXTRCT_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ORIG_PRCS_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    STAT_CD = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    STAT_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SRC_FILE_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TRNMSN_UNIQ_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SNDR_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RCVR_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SRC_CARR_ID = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CNTL_NUM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TRANS_SEQ_NUM = table.Column<int>(type: "int", nullable: true),
                    CUSIP_NUM = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    SRC_COMM_OPT_CD = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SRC_COMM_EXT_CD = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SRC_PROD_TYP_CD = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SRC_PROD_CD = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SRC_TM_CD = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SRC_ACT_CD = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    SRC_PREM_MODE_CD = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    COMP_IND = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ASSOC_FM_IND = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    COMM_TYP_CD = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    COMM_EVNT_TYP_CD = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    APPL_RT = table.Column<decimal>(type: "decimal(12,9)", nullable: true),
                    EXP_COMM_RT = table.Column<decimal>(type: "decimal(12,9)", nullable: true),
                    EXP_COMM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    DUE_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    ORIG_RECON_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LST_RECON_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ADJ_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_COMM_ERR_1", x => x.COMM_ID);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_ERR_DMT_ACT_CD",
                        column: x => x.ACT_CD,
                        principalTable: "DMT_ACT_CD",
                        principalColumn: "ACT_CD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_ERR_DMT_CARR",
                        column: x => x.CARR_ID,
                        principalTable: "DMT_CARR",
                        principalColumn: "CARR_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_ERR_DMT_PREM_MODE_CD",
                        column: x => x.PREM_MODE_CD,
                        principalTable: "DMT_PREM_MODE_CD",
                        principalColumn: "PREM_MODE_CD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_ERR_DMT_PROD",
                        column: x => x.PROD_ID,
                        principalTable: "DMT_PROD",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_ERR_DMT_STAT_CD",
                        column: x => x.STAT_CD,
                        principalTable: "DMT_STAT_CD",
                        principalColumn: "STAT_CD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_ERR_DMT_TM_CD",
                        column: x => x.TM_CD,
                        principalTable: "DMT_TM_CD",
                        principalColumn: "TM_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_PROD_ALT_NAME",
                columns: table => new
                {
                    PROD_ALT_NAME_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROD_ID = table.Column<int>(type: "int", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROD_ALT_NAME", x => x.PROD_ALT_NAME_ID);
                    table.ForeignKey(
                        name: "FK_DMT_PROD_ALT_NAME_DMT_PROD",
                        column: x => x.PROD_ID,
                        principalTable: "DMT_PROD",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_PROD_RT",
                columns: table => new
                {
                    PROD_RT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROD_ID = table.Column<int>(type: "int", nullable: false),
                    ST_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    EFF_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TM_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    ACT_CD = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    YR_START_NUM = table.Column<int>(type: "int", nullable: false),
                    YR_END_NUM = table.Column<int>(type: "int", nullable: false),
                    AGE_START_NUM = table.Column<int>(type: "int", nullable: true),
                    AGE_END_NUM = table.Column<int>(type: "int", nullable: true),
                    RATE = table.Column<decimal>(type: "decimal(10,9)", nullable: false),
                    EXP_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_PROD_RT", x => x.PROD_RT_ID);
                    table.ForeignKey(
                        name: "FK_DMT_PROD_RT_DMT_ACT_CD",
                        column: x => x.ACT_CD,
                        principalTable: "DMT_ACT_CD",
                        principalColumn: "ACT_CD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_PROD_RT_DMT_PROD",
                        column: x => x.PROD_ID,
                        principalTable: "DMT_PROD",
                        principalColumn: "PROD_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_PROD_RT_DMT_ST_CD",
                        column: x => x.ST_CD,
                        principalTable: "DMT_ST_CD",
                        principalColumn: "ST_CD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DMT_PROD_RT_DMT_TM_CD",
                        column: x => x.TM_CD,
                        principalTable: "DMT_TM_CD",
                        principalColumn: "TM_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_CASE_AGNT",
                columns: table => new
                {
                    CASE_ID = table.Column<int>(type: "int", nullable: false),
                    AGNT_SEQ_REC_NUM = table.Column<int>(type: "int", nullable: false),
                    FA_NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FA_PHONE = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    FA_EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FA_ASSTNAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FA_ASST_EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FA_ASST_PHONE = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    FA_FIRM_REGION = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    FA_NPN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FA_BUSINESS_STREET_1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FA_BUSINESS_STREET_2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FA_BUSINESS_CITY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FA_BUSINESS_STATE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    FA_BUSINESS_ZIP_CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FA_BUSINESS_COUNTRY = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    FA_LATITUDE = table.Column<decimal>(type: "decimal(13,10)", nullable: true),
                    FA_LONGTITUDE = table.Column<decimal>(type: "decimal(13,10)", nullable: true),
                    FA_POSITION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FA_SL_CONTACT_ID = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: false),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MOD_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_CASE_AGNT", x => new { x.CASE_ID, x.AGNT_SEQ_REC_NUM });
                    table.ForeignKey(
                        name: "FK_DMT_CASE_AGNT_DMT_CASE",
                        column: x => x.CASE_ID,
                        principalTable: "DMT_CASE",
                        principalColumn: "CASE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_CASE_CMNT",
                columns: table => new
                {
                    CASE_CMNT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CASE_ID = table.Column<int>(type: "int", nullable: false),
                    CMNT_TXT = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_CASE_CMNT", x => x.CASE_CMNT_ID);
                    table.ForeignKey(
                        name: "FK_DMT_CASE_CMNT_DMT_CASE",
                        column: x => x.CASE_ID,
                        principalTable: "DMT_CASE",
                        principalColumn: "CASE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_CASE_LIFE_PARTIC",
                columns: table => new
                {
                    CASE_ID = table.Column<int>(type: "int", nullable: false),
                    LIFE_PARTIC_SEQ_REC_NUM = table.Column<int>(type: "int", nullable: false),
                    LIFE_PART_COVERAGE_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LIFE_PART_ROLE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LIFE_PART_ISSUE_AGE = table.Column<int>(type: "int", nullable: true),
                    LIFE_PART_ISSUE_GENDER = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LIFE_PART_CLASS_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LIFE_PART_UW_CLASS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LIFE_PART_UW_SUB_CLASS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LIFE_PART_TOBACCO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LIFE_PART_TEMP_RATING = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LIFE_PART_PERM_RATING = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LIFE_PART_PERM_TABLE_RATING = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LIFE_PART_LAST_MODIFIED_DATE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    LIFE_PART_SL_ID = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_CASE_LIFE_PARTIC", x => new { x.CASE_ID, x.LIFE_PARTIC_SEQ_REC_NUM });
                    table.ForeignKey(
                        name: "FK_DMT_CASE_LIFE_PARTIC_DMT_CASE",
                        column: x => x.CASE_ID,
                        principalTable: "DMT_CASE",
                        principalColumn: "CASE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_CASE_RSVP",
                columns: table => new
                {
                    CASE_ID = table.Column<int>(type: "int", nullable: false),
                    RSVP_SEQ_REC_NUM = table.Column<int>(type: "int", nullable: false),
                    RSVP_NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    RSVP_TERRITORY = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    RSVP_PHONE = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    RSVP_EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RSVP_STAFF_CODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    RSVP_CONTRACT_NUMBER = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    RSVP_ROLE_NAME = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    RSVP_SL_ID = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    IW_NAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    IW_PHONE = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    IW_EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IW_ROLE_NAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IW_SL_ID = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    CASE_MGR_PHONE = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    CASE_MGR_EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CASE_MGR_ROLENAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CM_SL_ID = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2(0)", nullable: true),
                    MOD_BY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_CASE_RSVP", x => new { x.CASE_ID, x.RSVP_SEQ_REC_NUM });
                    table.ForeignKey(
                        name: "FK_DMT_CASE_RSVP_DMT_CASE",
                        column: x => x.CASE_ID,
                        principalTable: "DMT_CASE",
                        principalColumn: "CASE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_CASE_WP_RSVP",
                columns: table => new
                {
                    CASE_WP_RSVP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CASE_ID = table.Column<int>(type: "int", nullable: true),
                    RSVP_STAFF_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CRT_DT = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime", nullable: true),
                    MOD_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_CASE_WP_RSVP", x => x.CASE_WP_RSVP_ID);
                    table.ForeignKey(
                        name: "FK_DMT_CASE_WP_RSVP_DMT_CASE",
                        column: x => x.CASE_ID,
                        principalTable: "DMT_CASE",
                        principalColumn: "CASE_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_COMM_AGNT",
                columns: table => new
                {
                    COMM_ID = table.Column<int>(type: "int", nullable: false),
                    COMM_AGNT_SEQ_NUM = table.Column<int>(type: "int", nullable: false),
                    AGNT_SSN_TIN_NUM = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    AGNT_SSN_TIN_TYP_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    AGNT_NPN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AGNT_CNTR_NUM = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    AGNT_SPLIT_PCT = table.Column<decimal>(type: "decimal(10,9)", nullable: true),
                    GRS_PREM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    COMM_PREM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    COMM_RT = table.Column<decimal>(type: "decimal(12,9)", nullable: true),
                    COMM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SRC_TIN_TYP_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_COMM_AGNT", x => new { x.COMM_ID, x.COMM_AGNT_SEQ_NUM });
                    table.ForeignKey(
                        name: "FK_DMT_COMM_AGNT_DMT_COMM_COMM_ID",
                        column: x => x.COMM_ID,
                        principalTable: "DMT_COMM",
                        principalColumn: "COMM_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_AGNT_DMT_SSN_TIN_TYP_CD",
                        column: x => x.AGNT_SSN_TIN_TYP_CD,
                        principalTable: "DMT_SSN_TIN_TYP_CD",
                        principalColumn: "SSN_TIN_TYP_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_COMM_CLNT",
                columns: table => new
                {
                    COMM_ID = table.Column<int>(type: "int", nullable: false),
                    COMM_CLNT_SEQ_NUM = table.Column<int>(type: "int", nullable: false),
                    CLNT_SSN_TIN_NUM = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    CLNT_SSN_TIN_TYP_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CLNT_PRFX_NAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CLNT_FIRST_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CLNT_MID_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CLNT_LST_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CLNT_SFX_NAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CLNT_FULL_NAME = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MOD_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SRC_SSN_TIN_TYP_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_COMM_CLNT", x => new { x.COMM_ID, x.COMM_CLNT_SEQ_NUM });
                    table.ForeignKey(
                        name: "FK_DMT_COMM_CLNT_DMT_COMM_COMM_ID",
                        column: x => x.COMM_ID,
                        principalTable: "DMT_COMM",
                        principalColumn: "COMM_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_CLNT_DMT_SSN_TIN_TYP_CD",
                        column: x => x.CLNT_SSN_TIN_TYP_CD,
                        principalTable: "DMT_SSN_TIN_TYP_CD",
                        principalColumn: "SSN_TIN_TYP_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_COMM_ERR_AGNT",
                columns: table => new
                {
                    COMM_ID = table.Column<int>(type: "int", nullable: false),
                    COMM_AGNT_SEQ_NUM = table.Column<int>(type: "int", nullable: false),
                    AGNT_SSN_TIN_NUM = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    AGNT_SSN_TIN_TYP_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    AGNT_NPN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AGNT_CNTR_NUM = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    AGNT_SPLIT_PCT = table.Column<decimal>(type: "decimal(10,9)", nullable: true),
                    GRS_PREM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    COMM_PREM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    COMM_RT = table.Column<decimal>(type: "decimal(12,9)", nullable: true),
                    COMM_AMT = table.Column<decimal>(type: "numeric(16,2)", nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MOD_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SRC_TIN_TYP_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    AGNT_CRD_NUM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AGNT_DIST_ASSGN_ID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_COMM_ERR_AGNT", x => new { x.COMM_ID, x.COMM_AGNT_SEQ_NUM });
                    table.ForeignKey(
                        name: "FK_DMT_COMM_ERR_AGNT_DMT_COMM_ERR",
                        column: x => x.COMM_ID,
                        principalTable: "DMT_COMM_ERR",
                        principalColumn: "COMM_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_ERR_AGNT_DMT_SSN_TIN_TYP_CD",
                        column: x => x.AGNT_SSN_TIN_TYP_CD,
                        principalTable: "DMT_SSN_TIN_TYP_CD",
                        principalColumn: "SSN_TIN_TYP_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DMT_COMM_ERR_CLNT",
                columns: table => new
                {
                    COMM_ID = table.Column<int>(type: "int", nullable: false),
                    COMM_CLNT_SEQ_NUM = table.Column<int>(type: "int", nullable: false),
                    CLNT_SSN_TIN_NUM = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    CLNT_SSN_TIN_TYP_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CLNT_PRFX_NAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CLNT_FIRST_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CLNT_MID_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CLNT_LST_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CLNT_SFX_NAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CLNT_FULL_NAME = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CRT_DT = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    CRT_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('SYSTEM')"),
                    MOD_DT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MOD_BY_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SRC_SSN_TIN_TYP_CD = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMT_COMM_ERR_CLNT", x => new { x.COMM_ID, x.COMM_CLNT_SEQ_NUM });
                    table.ForeignKey(
                        name: "FK_DMT_COMM_ERR_CLNT_DMT_COMM_ERR",
                        column: x => x.COMM_ID,
                        principalTable: "DMT_COMM_ERR",
                        principalColumn: "COMM_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DMT_COMM_ERR_CLNT_DMT_SSN_TIN_TYP_CD",
                        column: x => x.CLNT_SSN_TIN_TYP_CD,
                        principalTable: "DMT_SSN_TIN_TYP_CD",
                        principalColumn: "SSN_TIN_TYP_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DMT_CASE_CARR_ID",
                table: "DMT_CASE",
                column: "CARR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_CASE_PROD_ID",
                table: "DMT_CASE",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_CASE_PROD_TYP_ID",
                table: "DMT_CASE",
                column: "PROD_TYP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_CASE_CMNT_CASE_ID",
                table: "DMT_CASE_CMNT",
                column: "CASE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_CASE_MSG_MSG_CD",
                table: "DMT_CASE_MSG",
                column: "MSG_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_CASE_MSG_MSG_TYP_CD",
                table: "DMT_CASE_MSG",
                column: "MSG_TYP_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_CASE_WP_RSVP_CASE_ID",
                table: "DMT_CASE_WP_RSVP",
                column: "CASE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_ACT_CD",
                table: "DMT_COMM",
                column: "ACT_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_CARR_ID",
                table: "DMT_COMM",
                column: "CARR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_PROD_ID",
                table: "DMT_COMM",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_STAT_CD",
                table: "DMT_COMM",
                column: "STAT_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_AGNT_AGNT_SSN_TIN_TYP_CD",
                table: "DMT_COMM_AGNT",
                column: "AGNT_SSN_TIN_TYP_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_CLNT_CLNT_SSN_TIN_TYP_CD",
                table: "DMT_COMM_CLNT",
                column: "CLNT_SSN_TIN_TYP_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_ERR_ACT_CD",
                table: "DMT_COMM_ERR",
                column: "ACT_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_ERR_PREM_MODE_CD",
                table: "DMT_COMM_ERR",
                column: "PREM_MODE_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_ERR_PROD_ID",
                table: "DMT_COMM_ERR",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_ERR_STAT_CD",
                table: "DMT_COMM_ERR",
                column: "STAT_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_ERR_TM_CD",
                table: "DMT_COMM_ERR",
                column: "TM_CD");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20200115-124436",
                table: "DMT_COMM_ERR",
                columns: new[] { "CARR_ID", "COMM_ID", "POL_NUM" });

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_ERR_AGNT_AGNT_SSN_TIN_TYP_CD",
                table: "DMT_COMM_ERR_AGNT",
                column: "AGNT_SSN_TIN_TYP_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_ERR_CLNT_CLNT_SSN_TIN_TYP_CD",
                table: "DMT_COMM_ERR_CLNT",
                column: "CLNT_SSN_TIN_TYP_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_MSG_MSG_CD",
                table: "DMT_COMM_MSG",
                column: "MSG_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_COMM_MSG_MSG_TYP_CD",
                table: "DMT_COMM_MSG",
                column: "MSG_TYP_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_MSG_CD_MSG_TYP_CD",
                table: "DMT_MSG_CD",
                column: "MSG_TYP_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PAY_CARR_ID",
                table: "DMT_PAY",
                column: "CARR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PAY_CMNT_PAY_ID",
                table: "DMT_PAY_CMNT",
                column: "PAY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PROD_CARR_ID",
                table: "DMT_PROD",
                column: "CARR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PROD_PROD_TYP_ID",
                table: "DMT_PROD",
                column: "PROD_TYP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PROD_ALT_NAME_PROD_ID",
                table: "DMT_PROD_ALT_NAME",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PROD_RT_ACT_CD",
                table: "DMT_PROD_RT",
                column: "ACT_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PROD_RT_PROD_ID",
                table: "DMT_PROD_RT",
                column: "PROD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PROD_RT_ST_CD",
                table: "DMT_PROD_RT",
                column: "ST_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PROD_RT_TM_CD",
                table: "DMT_PROD_RT",
                column: "TM_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PROD_TYP_RT_ACT_CD",
                table: "DMT_PROD_TYP_RT",
                column: "ACT_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PROD_TYP_RT_CARR_ID",
                table: "DMT_PROD_TYP_RT",
                column: "CARR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PROD_TYP_RT_ST_CD",
                table: "DMT_PROD_TYP_RT",
                column: "ST_CD");

            migrationBuilder.CreateIndex(
                name: "IX_DMT_PROD_TYP_RT_TM_CD",
                table: "DMT_PROD_TYP_RT",
                column: "TM_CD");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DMT_CASE_AGNT");

            migrationBuilder.DropTable(
                name: "DMT_CASE_CMNT");

            migrationBuilder.DropTable(
                name: "DMT_CASE_LIFE_PARTIC");

            migrationBuilder.DropTable(
                name: "DMT_CASE_MSG");

            migrationBuilder.DropTable(
                name: "DMT_CASE_RSVP");

            migrationBuilder.DropTable(
                name: "DMT_CASE_WP");

            migrationBuilder.DropTable(
                name: "DMT_CASE_WP_CMNT");

            migrationBuilder.DropTable(
                name: "DMT_CASE_WP_NET");

            migrationBuilder.DropTable(
                name: "DMT_CASE_WP_RSVP");

            migrationBuilder.DropTable(
                name: "DMT_COMM_AGNT");

            migrationBuilder.DropTable(
                name: "DMT_COMM_CLNT");

            migrationBuilder.DropTable(
                name: "DMT_COMM_CMNT");

            migrationBuilder.DropTable(
                name: "DMT_COMM_ERR_AGNT");

            migrationBuilder.DropTable(
                name: "DMT_COMM_ERR_CLNT");

            migrationBuilder.DropTable(
                name: "DMT_COMM_MSG");

            migrationBuilder.DropTable(
                name: "DMT_PAY_CMNT");

            migrationBuilder.DropTable(
                name: "DMT_PROD_ALT_NAME");

            migrationBuilder.DropTable(
                name: "DMT_PROD_RT");

            migrationBuilder.DropTable(
                name: "DMT_PROD_TYP_RT");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "DMT_CASE");

            migrationBuilder.DropTable(
                name: "DMT_COMM");

            migrationBuilder.DropTable(
                name: "DMT_COMM_ERR");

            migrationBuilder.DropTable(
                name: "DMT_SSN_TIN_TYP_CD");

            migrationBuilder.DropTable(
                name: "DMT_MSG_CD");

            migrationBuilder.DropTable(
                name: "DMT_PAY");

            migrationBuilder.DropTable(
                name: "DMT_ST_CD");

            migrationBuilder.DropTable(
                name: "DMT_ACT_CD");

            migrationBuilder.DropTable(
                name: "DMT_PREM_MODE_CD");

            migrationBuilder.DropTable(
                name: "DMT_PROD");

            migrationBuilder.DropTable(
                name: "DMT_STAT_CD");

            migrationBuilder.DropTable(
                name: "DMT_TM_CD");

            migrationBuilder.DropTable(
                name: "DMT_MSG_TYP_CD");

            migrationBuilder.DropTable(
                name: "DMT_CARR");

            migrationBuilder.DropTable(
                name: "DMT_PROD_TYP");
        }
    }
}
