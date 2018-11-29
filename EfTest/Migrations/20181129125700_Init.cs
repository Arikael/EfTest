using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfTest.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdBase",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 80, nullable: true),
                    Name = table.Column<string>(maxLength: 80, nullable: true),
                    Sex = table.Column<int>(nullable: true),
                    SozialVersicherungsNr = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    CompanyId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdBase_AdBase_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "AdBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdBase_CompanyId",
                table: "AdBase",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdBase");
        }
    }
}
