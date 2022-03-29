using Microsoft.EntityFrameworkCore.Migrations;

namespace JqueryAjaxCRUDInASPNETCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(12)", nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SWIFTCode = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
