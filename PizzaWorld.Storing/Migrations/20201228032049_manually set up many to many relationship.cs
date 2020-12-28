using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class manuallysetupmanytomanyrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447031279541202L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447031279572599L);

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "Orders");

            migrationBuilder.CreateTable(
                name: "OrderAPizzaModel",
                columns: table => new
                {
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    PizzaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAPizzaModel", x => new { x.OrderId, x.PizzaId });
                    table.ForeignKey(
                        name: "FK_OrderAPizzaModel_APizzaModel_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "APizzaModel",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderAPizzaModel_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447044495304209L, "Dominos", 0L });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447044495339250L, "Pizza Hut", 0L });

            migrationBuilder.CreateIndex(
                name: "IX_OrderAPizzaModel_PizzaId",
                table: "OrderAPizzaModel",
                column: "PizzaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderAPizzaModel");

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447044495304209L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447044495339250L);

            migrationBuilder.AddColumn<long>(
                name: "PizzaId",
                table: "Orders",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447031279541202L, "Dominos", 0L });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447031279572599L, "Pizza Hut", 0L });
        }
    }
}
