using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace demoNetCore.Data.Migrations
{
    public partial class AlterColFileSizeLenght : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("affe005b-4610-401b-a1d8-905f7fd65005"),
                column: "ConcurrencyStamp",
                value: "65d7ab80-b923-4182-b488-18553e34aebd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("663777d9-501d-4ae7-b51b-2e0c45ff926b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3951f3ee-8c70-4544-9540-40225dd5208b", "AQAAAAEAACcQAAAAEKVQQsE/iDjlo0xZ4DqF89fx0fUQ/SMkUyxJAGH1tkM081DhITt2e9Gmjn/D4YHoIQ==" });

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
                value: new DateTime(2020, 4, 4, 1, 31, 34, 942, DateTimeKind.Local).AddTicks(3914));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImage",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

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
    }
}
