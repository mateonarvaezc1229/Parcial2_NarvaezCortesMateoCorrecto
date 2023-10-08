using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial2_NaturalPerson.Migrations
{
    public partial class NEWDATABASE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NaturalPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturalPerson", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NaturalPerson_FullName",
                table: "NaturalPerson",
                column: "FullName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NaturalPerson");
        }
    }
}
