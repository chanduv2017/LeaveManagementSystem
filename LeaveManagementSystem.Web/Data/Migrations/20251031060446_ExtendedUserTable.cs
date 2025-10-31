using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819d90de-0e93-4dec-be3d-b92399659bfe",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16882a9a-e7bf-4296-86db-d7be389e2405", new DateOnly(1950, 12, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEKChNS+0pkDdmkJ5PvI1vV+GTKVBmlrosl9l79Ub/SEdbGjl+fb2p3lJ7u8i4GqFKA==", "12f7e524-439b-4efa-bf78-6c58b8dbb07d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819d90de-0e93-4dec-be3d-b92399659bfe",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bb22b5b-b30e-47e8-bd3b-1c6afa5b7f97", "AQAAAAIAAYagAAAAEAnws8Wy246AhLAgdEZoiRIKynbcwWal6vqSBmhK/p+JwW+JPUnorwAHmuamWbKKKA==", "90cd1175-d09e-436b-bf63-06776c0be9d4" });
        }
    }
}
