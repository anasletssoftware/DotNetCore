using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ImadErp.Migrations
{
    public partial class JobHistory12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "JobHistories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_JobHistories_JobId",
                table: "JobHistories",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobHistories_Jobs_JobId",
                table: "JobHistories",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobHistories_Jobs_JobId",
                table: "JobHistories");

            migrationBuilder.DropIndex(
                name: "IX_JobHistories_JobId",
                table: "JobHistories");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "JobHistories");
        }
    }
}
