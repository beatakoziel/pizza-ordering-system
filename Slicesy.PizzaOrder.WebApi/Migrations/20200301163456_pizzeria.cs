using Microsoft.EntityFrameworkCore.Migrations;

namespace Slicesy.PizzaOrder.WebApi.Migrations
{
    public partial class pizzeria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Pizza_CustomPizzaId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Pizza_PizzaId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Pizzeria_PizzeriaId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzeria_Address_AddressId",
                table: "Pizzeria");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzeria_ContactData_ContactDataId",
                table: "Pizzeria");

            migrationBuilder.DropForeignKey(
                name: "FK_SizeAndPrice_Ingredient_IngredientId",
                table: "SizeAndPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_SizeAndPrice_Pizza_PizzaId",
                table: "SizeAndPrice");

            migrationBuilder.DropIndex(
                name: "IX_SizeAndPrice_IngredientId",
                table: "SizeAndPrice");

            migrationBuilder.DropIndex(
                name: "IX_SizeAndPrice_PizzaId",
                table: "SizeAndPrice");

            migrationBuilder.DropIndex(
                name: "IX_Pizzeria_AddressId",
                table: "Pizzeria");

            migrationBuilder.DropIndex(
                name: "IX_Pizzeria_ContactDataId",
                table: "Pizzeria");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_PizzeriaId",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_CustomPizzaId",
                table: "Ingredient");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_PizzaId",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "SizeAndPrice");

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "SizeAndPrice");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Pizzeria");

            migrationBuilder.DropColumn(
                name: "ContactDataId",
                table: "Pizzeria");

            migrationBuilder.DropColumn(
                name: "PizzeriaId",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "CustomPizzaId",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "Ingredient");

            migrationBuilder.AddColumn<long>(
                name: "IngredientPricesFK",
                table: "SizeAndPrice",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PizzaPricesFK",
                table: "SizeAndPrice",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PizzeriaAddressFK",
                table: "Pizzeria",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PizzeriaContactDataFK",
                table: "Pizzeria",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PizzaPizzeriaFK",
                table: "Pizza",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CustomPizzaFreeIngredientsFK",
                table: "Ingredient",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PizzaIngredientsFK",
                table: "Ingredient",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SizeAndPrice_IngredientPricesFK",
                table: "SizeAndPrice",
                column: "IngredientPricesFK");

            migrationBuilder.CreateIndex(
                name: "IX_SizeAndPrice_PizzaPricesFK",
                table: "SizeAndPrice",
                column: "PizzaPricesFK");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzeria_PizzeriaAddressFK",
                table: "Pizzeria",
                column: "PizzeriaAddressFK");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzeria_PizzeriaContactDataFK",
                table: "Pizzeria",
                column: "PizzeriaContactDataFK");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_PizzaPizzeriaFK",
                table: "Pizza",
                column: "PizzaPizzeriaFK");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_CustomPizzaFreeIngredientsFK",
                table: "Ingredient",
                column: "CustomPizzaFreeIngredientsFK");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_PizzaIngredientsFK",
                table: "Ingredient",
                column: "PizzaIngredientsFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Pizza_CustomPizzaFreeIngredientsFK",
                table: "Ingredient",
                column: "CustomPizzaFreeIngredientsFK",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Pizza_PizzaIngredientsFK",
                table: "Ingredient",
                column: "PizzaIngredientsFK",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Pizzeria_PizzaPizzeriaFK",
                table: "Pizza",
                column: "PizzaPizzeriaFK",
                principalTable: "Pizzeria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzeria_Address_PizzeriaAddressFK",
                table: "Pizzeria",
                column: "PizzeriaAddressFK",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzeria_ContactData_PizzeriaContactDataFK",
                table: "Pizzeria",
                column: "PizzeriaContactDataFK",
                principalTable: "ContactData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SizeAndPrice_Ingredient_IngredientPricesFK",
                table: "SizeAndPrice",
                column: "IngredientPricesFK",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SizeAndPrice_Pizza_PizzaPricesFK",
                table: "SizeAndPrice",
                column: "PizzaPricesFK",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Pizza_CustomPizzaFreeIngredientsFK",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Pizza_PizzaIngredientsFK",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Pizzeria_PizzaPizzeriaFK",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzeria_Address_PizzeriaAddressFK",
                table: "Pizzeria");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzeria_ContactData_PizzeriaContactDataFK",
                table: "Pizzeria");

            migrationBuilder.DropForeignKey(
                name: "FK_SizeAndPrice_Ingredient_IngredientPricesFK",
                table: "SizeAndPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_SizeAndPrice_Pizza_PizzaPricesFK",
                table: "SizeAndPrice");

            migrationBuilder.DropIndex(
                name: "IX_SizeAndPrice_IngredientPricesFK",
                table: "SizeAndPrice");

            migrationBuilder.DropIndex(
                name: "IX_SizeAndPrice_PizzaPricesFK",
                table: "SizeAndPrice");

            migrationBuilder.DropIndex(
                name: "IX_Pizzeria_PizzeriaAddressFK",
                table: "Pizzeria");

            migrationBuilder.DropIndex(
                name: "IX_Pizzeria_PizzeriaContactDataFK",
                table: "Pizzeria");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_PizzaPizzeriaFK",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_CustomPizzaFreeIngredientsFK",
                table: "Ingredient");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_PizzaIngredientsFK",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "IngredientPricesFK",
                table: "SizeAndPrice");

            migrationBuilder.DropColumn(
                name: "PizzaPricesFK",
                table: "SizeAndPrice");

            migrationBuilder.DropColumn(
                name: "PizzeriaAddressFK",
                table: "Pizzeria");

            migrationBuilder.DropColumn(
                name: "PizzeriaContactDataFK",
                table: "Pizzeria");

            migrationBuilder.DropColumn(
                name: "PizzaPizzeriaFK",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "CustomPizzaFreeIngredientsFK",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "PizzaIngredientsFK",
                table: "Ingredient");

            migrationBuilder.AddColumn<long>(
                name: "IngredientId",
                table: "SizeAndPrice",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PizzaId",
                table: "SizeAndPrice",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "AddressId",
                table: "Pizzeria",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ContactDataId",
                table: "Pizzeria",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PizzeriaId",
                table: "Pizza",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CustomPizzaId",
                table: "Ingredient",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PizzaId",
                table: "Ingredient",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SizeAndPrice_IngredientId",
                table: "SizeAndPrice",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeAndPrice_PizzaId",
                table: "SizeAndPrice",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzeria_AddressId",
                table: "Pizzeria",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzeria_ContactDataId",
                table: "Pizzeria",
                column: "ContactDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_PizzeriaId",
                table: "Pizza",
                column: "PizzeriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_CustomPizzaId",
                table: "Ingredient",
                column: "CustomPizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_PizzaId",
                table: "Ingredient",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Pizza_CustomPizzaId",
                table: "Ingredient",
                column: "CustomPizzaId",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Pizza_PizzaId",
                table: "Ingredient",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Pizzeria_PizzeriaId",
                table: "Pizza",
                column: "PizzeriaId",
                principalTable: "Pizzeria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzeria_Address_AddressId",
                table: "Pizzeria",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzeria_ContactData_ContactDataId",
                table: "Pizzeria",
                column: "ContactDataId",
                principalTable: "ContactData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SizeAndPrice_Ingredient_IngredientId",
                table: "SizeAndPrice",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SizeAndPrice_Pizza_PizzaId",
                table: "SizeAndPrice",
                column: "PizzaId",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
