using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class changedpriceworkability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447499787597263L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447499787667413L);

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Pizzas",
                newName: "Price");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Sizes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Crusts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 637450057057614530L, "Dominos" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 637450057057648623L, "Pizza Hut" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637450057057614530L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637450057057648623L);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Crusts");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Pizzas",
                newName: "price");

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 637447499787597263L, "Dominos" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 637447499787667413L, "Pizza Hut" });
        }
    }
}
