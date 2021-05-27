using Microsoft.EntityFrameworkCore.Migrations;

namespace PLD.DataAccess.Migrations
{
    public partial class SeedDMTCarrTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.Sql("INSERT INTO DMT_CARR (CARR_ID, CARR_CD, NAME)" +
                    " VALUES (1,'AIG','AIG')");
                migrationBuilder.Sql("INSERT INTO DMT_CARR (CARR_ID, CARR_CD, NAME)" +
                    " VALUES (2,'JH','John Hancock')");
                migrationBuilder.Sql("INSERT INTO DMT_CARR (CARR_ID, CARR_CD, NAME)" +
                    " VALUES (3,'LIN','Lincoln')");
                migrationBuilder.Sql("INSERT INTO DMT_CARR (CARR_ID, CARR_CD, NAME)" +
                    " VALUES (4,'PAC','Pacific Life')");
                migrationBuilder.Sql("INSERT INTO DMT_CARR (CARR_ID, CARR_CD, NAME)" +
                    " VALUES (5,'PROT','Protective')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM DMT_CARR");
        }
    }
}
