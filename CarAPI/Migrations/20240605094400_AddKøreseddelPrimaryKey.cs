using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddKøreseddelPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Køresedler",
                columns: table => new
                {
                    KoreseddelModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bruger = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Formal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SlutDato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KmStart = table.Column<int>(type: "int", nullable: false),
                    KmSlut = table.Column<int>(type: "int", nullable: false),
                    FraDestination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TilDestination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BilId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Køresedler", x => x.KoreseddelModelId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Køresedler");
        }
    }
}
