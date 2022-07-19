using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teleperformance.Final.Project.Persistance.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                schema: "ShopList",
                table: "Items",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit")
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 9);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "ShopList",
                table: "Items",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 50, 48, 532, DateTimeKind.Utc).AddTicks(3138));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 50, 48, 532, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 50, 48, 532, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 50, 48, 532, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 50, 48, 532, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 50, 48, 532, DateTimeKind.Utc).AddTicks(3311));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                schema: "ShopList",
                table: "Items",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit")
                .Annotation("Relational:ColumnOrder", 9)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "ShopList",
                table: "Items",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 30, 56, 42, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 30, 56, 42, DateTimeKind.Utc).AddTicks(1425));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 30, 56, 42, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 30, 56, 42, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 30, 56, 42, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 7, 17, 10, 30, 56, 42, DateTimeKind.Utc).AddTicks(1630));
        }
    }
}
