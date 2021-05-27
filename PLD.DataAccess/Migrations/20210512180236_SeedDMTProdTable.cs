using Microsoft.EntityFrameworkCore.Migrations;

namespace PLD.DataAccess.Migrations
{
    public partial class SeedDMTProdTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD] ([CARR_ID],[PROD_TYP_ID],[PROD_CD],[NAME],[PROD_RT_IND],[PROD_TYP_RT_IND])"+
                        " VALUES(1,5,'PLTNCHCV','AG Platinum Choice - CV',1,1)");

            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD] ([CARR_ID],[PROD_TYP_ID],[PROD_CD],[NAME],[PROD_RT_IND],[PROD_TYP_RT_IND])"+
                        " VALUES(1,5,'PLTNCHCGL','AG Platinum Choice - GL',1,1)");            
            
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD] ([CARR_ID],[PROD_TYP_ID],[PROD_CD],[NAME],[PROD_RT_IND],[PROD_TYP_RT_IND])"+
                        " VALUES(1,5,'PLTNCHVUL','Platinum Choice VUL',1,1)"); 
            
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD] ([CARR_ID],[PROD_TYP_ID],[PROD_CD],[NAME],[PROD_RT_IND],[PROD_TYP_RT_IND])"+
                        " VALUES(2,4,'SECGUL3','AG Security Lifetime GUL 3',1,1)"); 
        
            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD] ([CARR_ID],[PROD_TYP_ID],[PROD_CD],[NAME],[PROD_RT_IND],[PROD_TYP_RT_IND])"+
                        " VALUES(1,4,'SECGULNY','Secure Lifetime GUL 3 NY',1,1)"); 

            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD] ([CARR_ID],[PROD_TYP_ID],[PROD_CD],[NAME],[PROD_RT_IND],[PROD_TYP_RT_IND])"+
                        " VALUES(1,4,'SECSGULII','SECURE SURVIVOR GUL II-CV',1,1)");     

            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD] ([CARR_ID],[PROD_TYP_ID],[PROD_CD],[NAME],[PROD_RT_IND],[PROD_TYP_RT_IND])"+
                        " VALUES(1,3,'SAT1015','AG Select-a-Term Nov 2015 10 YR',1,1)");    

            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD] ([CARR_ID],[PROD_TYP_ID],[PROD_CD],[NAME],[PROD_RT_IND],[PROD_TYP_RT_IND])"+
                        " VALUES(1,3,'SAT1515','AG Select-a-Term Nov 2015 15 YR',1,1)");   

            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD] ([CARR_ID],[PROD_TYP_ID],[PROD_CD],[NAME],[PROD_RT_IND],[PROD_TYP_RT_IND])"+
                        " VALUES(1,3,'SAT2015','AG Select-a-Term Nov 2015 20 YR',1,1)");      

            migrationBuilder.Sql("INSERT INTO [dbo].[DMT_PROD] ([CARR_ID],[PROD_TYP_ID],[PROD_CD],[NAME],[PROD_RT_IND],[PROD_TYP_RT_IND])"+
                        " VALUES(1,3,'SAT2515','AG Select-a-Term Nov 2015 25 YR',1,1)");                       
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[DMT_PROD]");
        }
    }
}
