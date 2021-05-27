using Microsoft.EntityFrameworkCore.Migrations;

namespace PLD.DataAccess.Migrations
{
    public partial class SeedDMTStatCdTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_STAT_CD] ([STAT_CD],[DESC_TXT])"+
                                    " VALUES('E','Error')"); 

            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_STAT_CD] ([STAT_CD],[DESC_TXT])"+
                                    " VALUES('N','New')"); 

            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_STAT_CD] ([STAT_CD],[DESC_TXT])"+
                                    " VALUES('P','Processed')"); 

            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_STAT_CD] ([STAT_CD],[DESC_TXT])"+
                                    " VALUES('R','Reconciled')"); 
                                
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[DMT_STAT_CD]");

        }
    }
}
