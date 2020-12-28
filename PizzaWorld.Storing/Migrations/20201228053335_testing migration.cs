using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class testingmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447122052811911L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447122052844214L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447124153276460L, "Dominos", 0L });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447124153308432L, "Pizza Hut", 0L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447124153276460L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447124153308432L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447122052811911L, "Dominos", 0L });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447122052844214L, "Pizza Hut", 0L });
        }
    }
}
