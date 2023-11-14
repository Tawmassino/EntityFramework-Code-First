using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_Code_First.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration // kaip pakeisti duombaze jog atitiktu musu konteksta
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)//kai migruosim naujasia versija
        {
            migrationBuilder.CreateTable(//sukurs lentele
                name: "Pages",
                columns: table => new//tokie stulpeliai
                {// !! code first budu darant lentele labai svarbu nekeisti cia. keisti per klase.

                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)//migruojam nuo to ka turim, i senesne versija
        {//
            migrationBuilder.DropTable(
                name: "Pages");
        }
    }
}
