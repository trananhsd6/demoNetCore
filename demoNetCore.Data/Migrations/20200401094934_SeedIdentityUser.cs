using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace demoNetCore.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 1, 16, 49, 34, 251, DateTimeKind.Local).AddTicks(111),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2020, 4, 1, 16, 33, 30, 946, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("affe005b-4610-401b-a1d8-905f7fd65005"), "90e60bf7-48fc-4197-8120-c85b476a9b8b", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("663777d9-501d-4ae7-b51b-2e0c45ff926b"), new Guid("affe005b-4610-401b-a1d8-905f7fd65005") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("663777d9-501d-4ae7-b51b-2e0c45ff926b"), 0, "8cb1d717-2937-44c8-bc96-be0e0ea9cba8", new DateTime(1997, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "trananhsd6@gmail.com", true, "Anh", "Tran", false, null, "trananhsd6@gmail.com", "admin", "AQAAAAEAACcQAAAAEFMblkoZBE4cFq8SutMD/l3VhLW5O7oc3CKIikn1tr5xYprVqZFkZLF7pIQtIYZgsg==", null, false, "", false, "admin" });

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
                value: new DateTime(2020, 4, 1, 16, 49, 34, 269, DateTimeKind.Local).AddTicks(6011));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("affe005b-4610-401b-a1d8-905f7fd65005"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("663777d9-501d-4ae7-b51b-2e0c45ff926b"), new Guid("affe005b-4610-401b-a1d8-905f7fd65005") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("663777d9-501d-4ae7-b51b-2e0c45ff926b"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 1, 16, 33, 30, 946, DateTimeKind.Local).AddTicks(1913),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 4, 1, 16, 49, 34, 251, DateTimeKind.Local).AddTicks(111));

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
                value: new DateTime(2020, 4, 1, 16, 33, 30, 972, DateTimeKind.Local).AddTicks(1373));
        }
    }
}
