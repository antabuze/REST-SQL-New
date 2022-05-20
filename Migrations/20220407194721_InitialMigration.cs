using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace REST_SQL_New.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Athletes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    short_name = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    birth_date = table.Column<DateTime>(nullable: true),
                    birth_place = table.Column<string>(nullable: true),
                    birth_country = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    country_code = table.Column<string>(nullable: true),
                    discipline = table.Column<string>(nullable: true),
                    discipline_code = table.Column<string>(nullable: true),
                    residence_place = table.Column<string>(nullable: true),
                    residence_country = table.Column<string>(nullable: true),
                    height_m_ft = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Athletes", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Athletes");
        }
    }
}
