using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class iamamoron : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447044495304209L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447044495339250L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447053949387579L, "Dominos", 0L });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447053949419657L, "Pizza Hut", 0L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447053949387579L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447053949419657L);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447044495304209L, "Dominos", 0L });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name", "OrderId" },
                values: new object[] { 637447044495339250L, "Pizza Hut", 0L });
        }
    }
}
