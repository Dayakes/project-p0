using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Crust_crustEntityId",
                table: "APizzaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Size_sizeEntityId",
                table: "APizzaModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Size",
                table: "Size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crust",
                table: "Crust");

            migrationBuilder.RenameTable(
                name: "Size",
                newName: "Sizes");

            migrationBuilder.RenameTable(
                name: "Crust",
                newName: "Crusts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crusts",
                table: "Crusts",
                column: "EntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Crusts_crustEntityId",
                table: "APizzaModel",
                column: "crustEntityId",
                principalTable: "Crusts",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Sizes_sizeEntityId",
                table: "APizzaModel",
                column: "sizeEntityId",
                principalTable: "Sizes",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Crusts_crustEntityId",
                table: "APizzaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Sizes_sizeEntityId",
                table: "APizzaModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crusts",
                table: "Crusts");

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "Size");

            migrationBuilder.RenameTable(
                name: "Crusts",
                newName: "Crust");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Size",
                table: "Size",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crust",
                table: "Crust",
                column: "EntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Crust_crustEntityId",
                table: "APizzaModel",
                column: "crustEntityId",
                principalTable: "Crust",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Size_sizeEntityId",
                table: "APizzaModel",
                column: "sizeEntityId",
                principalTable: "Size",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
