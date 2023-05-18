using Microsoft.EntityFrameworkCore.Migrations;

namespace BasketServiceApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerBaskets",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBaskets", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    ProductName = table.Column<string>(type: "text", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    OldUnitPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    PictureUrl = table.Column<string>(type: "text", nullable: true),
                    BasketId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_CustomerBaskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "CustomerBaskets",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "CustomerBaskets");
        }
    }
}
