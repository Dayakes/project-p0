using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class removeduserpropertiesforselectsforrealthistime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Users_UserId",
                table: "APizzaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Stores_SelectedStoreStoreId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SelectedStoreStoreId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_APizzaModel_UserId",
                table: "APizzaModel");

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447004637277327L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447004637308875L);

            migrationBuilder.DropColumn(
                name: "SelectedStoreStoreId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "APizzaModel");

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 637447005830193136L, "Dominos" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 637447005830227360L, "Pizza Hut" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447005830193136L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "StoreId",
                keyValue: 637447005830227360L);

            migrationBuilder.AddColumn<long>(
                name: "SelectedStoreStoreId",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "APizzaModel",
                type: "bigint",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 637447004637277327L, "Dominos" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "StoreId", "Name" },
                values: new object[] { 637447004637308875L, "Pizza Hut" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_SelectedStoreStoreId",
                table: "Users",
                column: "SelectedStoreStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_APizzaModel_UserId",
                table: "APizzaModel",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Users_UserId",
                table: "APizzaModel",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Stores_SelectedStoreStoreId",
                table: "Users",
                column: "SelectedStoreStoreId",
                principalTable: "Stores",
                principalColumn: "StoreId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
