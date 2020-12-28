using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class removedorderidfromstore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447124153276460L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447124153308432L);

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Stores");

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 637447125145571039L, "Dominos" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 637447125145603137L, "Pizza Hut" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447125145571039L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447125145603137L);

            migrationBuilder.AddColumn<long>(
                name: "OrderId",
                table: "Stores",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447124153276460L, "Dominos", 0L });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447124153308432L, "Pizza Hut", 0L });
        }
    }
}
