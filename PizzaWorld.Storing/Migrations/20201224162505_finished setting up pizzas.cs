using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class finishedsettinguppizzas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Topping");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Stores",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Sizes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Crusts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "APizzaModel",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 637444059052551375L, "Dominos" });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[] { 637444059052588137L, "Pizza Hut" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637444059052551375L);

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 637444059052588137L);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Crusts");

            migrationBuilder.DropColumn(
                name: "price",
                table: "APizzaModel");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Stores",
                newName: "name");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Topping",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
