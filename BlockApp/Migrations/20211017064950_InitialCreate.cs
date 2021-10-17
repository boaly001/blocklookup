using Microsoft.EntityFrameworkCore.Migrations;

namespace BlockApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EthereumTransaction",
                columns: table => new
                {
                    BlockHash = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BlockNumber = table.Column<long>(type: "bigint", nullable: false),
                    Gas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EthereumTransaction", x => new { x.BlockHash, x.BlockNumber });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EthereumTransaction");
        }
    }
}
