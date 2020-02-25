using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Slicesy.PizzaOrder.WebApi.Migrations
{
    public partial class address : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Address");

            migrationBuilder.DropTable(
                "PizzaUser");
        }
    }
}