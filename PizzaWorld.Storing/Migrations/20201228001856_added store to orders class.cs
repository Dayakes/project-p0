using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class addedstoretoordersclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stores_StoreEntityId",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637444180524726154L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637444180524764879L);

            migrationBuilder.RenameColumn(
                name: "StoreEntityId",
                table: "Order",
                newName: "storeEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_StoreEntityId",
                table: "Order",
                newName: "IX_Order_storeEntityId");

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 637446935365840548L, "Dominos" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 637446935365875100L, "Pizza Hut" });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Stores_storeEntityId",
                table: "Order",
                column: "storeEntityId",
                principalTable: "Stores",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stores_storeEntityId",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637446935365840548L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637446935365875100L);

            migrationBuilder.RenameColumn(
                name: "storeEntityId",
                table: "Order",
                newName: "StoreEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_storeEntityId",
                table: "Order",
                newName: "IX_Order_StoreEntityId");

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 637444180524726154L, "Dominos" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 637444180524764879L, "Pizza Hut" });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Stores_StoreEntityId",
                table: "Order",
                column: "StoreEntityId",
                principalTable: "Stores",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
