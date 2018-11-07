using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ImadErp.Migrations
{
    public partial class JobHistory1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "JobHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedOn",
                table: "JobHistories",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "JobHistories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "JobHistories",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "JobHistories");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "JobHistories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "JobHistories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "JobHistories");
        }
    }
}
