using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teleperformance.Final.Project.Persistance.Migrations
{
    public partial class UpdatedDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "ShopList",
                table: "Product",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "ShopList",
                table: "Items",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "ShopList",
                table: "Category",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 7, 6, 12, 12, 40, 790, DateTimeKind.Utc).AddTicks(2669));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "ShopList",
                table: "Product",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "ShopList",
                table: "Items",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "ShopList",
                table: "Category",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 5, 7, 34, 25, 813, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 5, 7, 34, 25, 813, DateTimeKind.Utc).AddTicks(2377));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 7, 5, 7, 34, 25, 813, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 5, 7, 34, 25, 813, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 5, 7, 34, 25, 813, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 7, 5, 7, 34, 25, 813, DateTimeKind.Utc).AddTicks(2883));
        }
    }
}
