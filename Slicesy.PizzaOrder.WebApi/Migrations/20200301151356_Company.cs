using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Slicesy.PizzaOrder.WebApi.Migrations
{
    public partial class Company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Address",
                table => new
                {
                    Id = table.Column<long>()
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostalCode = table.Column<string>(),
                    City = table.Column<string>(),
                    Street = table.Column<string>(),
                    BuildingNumber = table.Column<string>(),
                    FlatNumber = table.Column<string>()
                },
                constraints: table => { table.PrimaryKey("PK_Address", x => x.Id); });

            migrationBuilder.CreateTable(
                "ContactData",
                table => new
                {
                    Id = table.Column<long>()
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PhoneNumber = table.Column<string>(),
                    EmailAddress = table.Column<string>(),
                    AdditionalInfo = table.Column<string>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_ContactData", x => x.Id); });

            migrationBuilder.CreateTable(
                "Pizza",
                table => new
                {
                    Id = table.Column<long>()
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PizzeriaId = table.Column<long>(),
                    Name = table.Column<string>(),
                    Ingredients = table.Column<string>(),
                    Description = table.Column<string>(nullable: true),
                    PricePerSlice = table.Column<decimal>()
                },
                constraints: table => { table.PrimaryKey("PK_Pizza", x => x.Id); });

            migrationBuilder.CreateTable(
                "PizzaUser",
                table => new
                {
                    Id = table.Column<long>()
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(),
                    Password = table.Column<string>(),
                    Active = table.Column<bool>(),
                    PermittedResourceId = table.Column<long>(nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_PizzaUser", x => x.Id); });

            migrationBuilder.CreateTable(
                "Companies",
                table => new
                {
                    Id = table.Column<long>()
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyContactDataFK = table.Column<long>(),
                    CompanyAddressFK = table.Column<long>(),
                    CompanyDeliveryAddressFK = table.Column<long>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        "FK_Companies_Address_CompanyAddressFK",
                        x => x.CompanyAddressFK,
                        "Address",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Companies_ContactData_CompanyContactDataFK",
                        x => x.CompanyContactDataFK,
                        "ContactData",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        "FK_Companies_Address_CompanyDeliveryAddressFK",
                        x => x.CompanyDeliveryAddressFK,
                        "Address",
                        "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_Companies_CompanyAddressFK",
                "Companies",
                "CompanyAddressFK");

            migrationBuilder.CreateIndex(
                "IX_Companies_CompanyContactDataFK",
                "Companies",
                "CompanyContactDataFK");

            migrationBuilder.CreateIndex(
                "IX_Companies_CompanyDeliveryAddressFK",
                "Companies",
                "CompanyDeliveryAddressFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Companies");

            migrationBuilder.DropTable(
                "Pizza");

            migrationBuilder.DropTable(
                "PizzaUser");

            migrationBuilder.DropTable(
                "Address");

            migrationBuilder.DropTable(
                "ContactData");
        }
    }
}