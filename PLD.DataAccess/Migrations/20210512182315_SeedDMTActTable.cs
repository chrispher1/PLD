using Microsoft.EntityFrameworkCore.Migrations;

namespace PLD.DataAccess.Migrations
{
    public partial class SeedDMTActTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_ACT_CD] ([ACT_CD],[DESC_TXT])"+
                        " VALUES('A','Adjustment')");  

            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_ACT_CD] ([ACT_CD],[DESC_TXT])"+
                        " VALUES('E','Excess')");  
                
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_ACT_CD] ([ACT_CD],[DESC_TXT])"+
                        " VALUES('R','Renewal')");  

            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_ACT_CD] ([ACT_CD],[DESC_TXT])"+
                        " VALUES('T','Target')");  
                        
                
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[DMT_ACT_CD]");
        }
    }
}
