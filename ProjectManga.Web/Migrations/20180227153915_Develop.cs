using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectManga.Web.Migrations
{
    public partial class Develop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreationDateTime = table.Column<DateTime>(nullable: false, defaultValueSql: "DATETIME()"),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    ModificationDateTime = table.Column<DateTime>(nullable: false, defaultValueSql: "DATETIME()"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    RowVersion = table.Column<DateTime>(nullable: false, defaultValueSql: "DATETIME()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

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
                    SourceId = table.Column<int>(nullable: false),
                    ToChapter = table.Column<int>(nullable: true),
                    ToChapterPart = table.Column<int>(nullable: true),
                    ToPage = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownloadRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DownloadRequests_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DownloadRequests_SourceId",
                table: "DownloadRequests",
                column: "SourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DownloadRequests");

            migrationBuilder.DropTable(
                name: "Sources");
        }
    }
}
