using Microsoft.EntityFrameworkCore.Migrations;

namespace PLD.DataAccess.Migrations
{
    public partial class SeedDMTProdTypTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD_TYP] ([PROD_TYP_CD],[NAME])"+
            " VALUES(1, 'Unknown')");
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD_TYP] ([PROD_TYP_CD],[NAME])"+
            " VALUES(2, 'Whole Life')");
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD_TYP] ([PROD_TYP_CD],[NAME])"+
            " VALUES(3, 'Term')");
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD_TYP] ([PROD_TYP_CD],[NAME])"+
            " VALUES(4, 'Universal Life')");
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD_TYP] ([PROD_TYP_CD],[NAME])"+
            " VALUES(5, 'Variable Universal Life2')");
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD_TYP] ([PROD_TYP_CD],[NAME])"+
            " VALUES(6, 'Indexed Universal Life')");
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD_TYP] ([PROD_TYP_CD],[NAME])"+
            " VALUES(7, 'Interest Sensitive Whole Life')");
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD_TYP] ([PROD_TYP_CD],[NAME])"+
            " VALUES(8, 'Excess Interest Life')");
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD_TYP] ([PROD_TYP_CD],[NAME])"+
            " VALUES(9, 'Variable Whole Life')");
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD_TYP] ([PROD_TYP_CD],[NAME])"+
            " VALUES(10, 'Term with Cash Value')");
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD_TYP] ([PROD_TYP_CD],[NAME])"+
            " VALUES(11, 'Guaranteed Insurability')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.Sql("DELETE FROM [dbo].[DMT_PROD_TYP]");
        }
    }
}
