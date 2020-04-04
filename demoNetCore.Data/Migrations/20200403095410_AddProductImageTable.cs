using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace demoNetCore.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2020, 4, 1, 16, 49, 34, 251, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    Files = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 1, 16, 49, 34, 251, DateTimeKind.Local).AddTicks(111),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("affe005b-4610-401b-a1d8-905f7fd65005"),
                column: "ConcurrencyStamp",
                value: "90e60bf7-48fc-4197-8120-c85b476a9b8b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("663777d9-501d-4ae7-b51b-2e0c45ff926b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8cb1d717-2937-44c8-bc96-be0e0ea9cba8", "AQAAAAEAACcQAAAAEFMblkoZBE4cFq8SutMD/l3VhLW5O7oc3CKIikn1tr5xYprVqZFkZLF7pIQtIYZgsg==" });

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
    }
}
