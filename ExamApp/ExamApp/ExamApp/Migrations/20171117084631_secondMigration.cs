using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamApp.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Licence_Plates",
                table: "Licence_Plates");

            migrationBuilder.RenameTable(
                name: "Licence_Plates",
                newName: "licence_plates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_licence_plates",
                table: "licence_plates",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_licence_plates",
                table: "licence_plates");

            migrationBuilder.RenameTable(
                name: "licence_plates",
                newName: "Licence_Plates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Licence_Plates",
                table: "Licence_Plates",
                column: "Id");
        }
    }
}
