using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace demoNetCore.Data.Migrations
{
    public partial class AlterColFileSizeOfProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Files",
                table: "ProductImage");

            migrationBuilder.AddColumn<int>(
                name: "FileSize",
                table: "ProductImage",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("affe005b-4610-401b-a1d8-905f7fd65005"),
                column: "ConcurrencyStamp",
                value: "8eb94c43-aa04-4a1a-9b66-3b20ede52151");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("663777d9-501d-4ae7-b51b-2e0c45ff926b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ace0c48-e136-4c29-b990-923eb3b2f116", "AQAAAAEAACcQAAAAEOd0kcdiOc+2TcAHYqvYnQ/CwOXzLzGbSV5SLzbGChAsD/VBGcPGBKk+MzEnwrnzfQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 4, 1, 27, 56, 900, DateTimeKind.Local).AddTicks(2931));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileSize",
                table: "ProductImage");

            migrationBuilder.AddColumn<int>(
                name: "Files",
                table: "ProductImage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("affe005b-4610-401b-a1d8-905f7fd65005"),
                column: "ConcurrencyStamp",
                value: "9b21fa14-7356-45dc-b3e6-7407e4e8b527");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("663777d9-501d-4ae7-b51b-2e0c45ff926b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ccafb000-d617-4f7a-9c50-f3beb2677632", "AQAAAAEAACcQAAAAEDZ+j7PBdeYDoJCwHU4+rhA4HcqbNDnf6KAXw8dr+wyMAALtZpdf2wRxUMTOUDiKQw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 3, 16, 54, 9, 624, DateTimeKind.Local).AddTicks(4803));
        }
    }
}
