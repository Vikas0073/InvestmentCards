using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nextinvesting.Data.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GetPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SecurityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestmentMultiple = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Maturity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinInvestment = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investment", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investment");
        }
    }
}
