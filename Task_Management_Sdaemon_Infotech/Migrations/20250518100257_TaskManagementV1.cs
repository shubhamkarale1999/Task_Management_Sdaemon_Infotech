using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_Management_Sdaemon_Infotech.Migrations
{
    /// <inheritdoc />
    public partial class TaskManagementV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tbl_ManageTask",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "tbl_ManageTask",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "tbl_ManageTask",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "tbl_ManageTask",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tbl_ManageTask");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "tbl_ManageTask");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "tbl_ManageTask");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "tbl_ManageTask");
        }
    }
}
