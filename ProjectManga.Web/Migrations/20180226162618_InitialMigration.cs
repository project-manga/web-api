using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectManga.Web.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DownloadRequests",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValueSql: "DATETIME()"),
                    FromChapter = table.Column<int>(nullable: true),
                    FromChapterPart = table.Column<int>(nullable: true),
                    FromPage = table.Column<int>(nullable: true),
                    ModificationDateTime = table.Column<DateTime>(nullable: false, defaultValueSql: "DATETIME()"),
                    RowVersion = table.Column<DateTime>(nullable: false, defaultValueSql: "DATETIME()"),
                    Sid = table.Column<string>(maxLength: 255, nullable: true),
                    ToChapter = table.Column<int>(nullable: true),
                    ToChapterPart = table.Column<int>(nullable: true),
                    ToPage = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownloadRequests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DownloadRequests");
        }
    }
}
