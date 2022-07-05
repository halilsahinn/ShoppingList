using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teleperformance.Final.Project.Persistance.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Main_Category_CategoryId",
                schema: "ShopList",
                table: "Main");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Main_ShopListEntityId",
                schema: "ShopList",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Main",
                schema: "ShopList",
                table: "Main");

            migrationBuilder.RenameTable(
                name: "Main",
                schema: "ShopList",
                newName: "Items",
                newSchema: "ShopList");

            migrationBuilder.RenameIndex(
                name: "IX_Main_CategoryId",
                schema: "ShopList",
                table: "Items",
                newName: "IX_Items_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                schema: "ShopList",
                table: "Items",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Category_CategoryId",
                schema: "ShopList",
                table: "Items",
                column: "CategoryId",
                principalSchema: "ShopList",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Items_ShopListEntityId",
                schema: "ShopList",
                table: "Product",
                column: "ShopListEntityId",
                principalSchema: "ShopList",
                principalTable: "Items",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Category_CategoryId",
                schema: "ShopList",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Items_ShopListEntityId",
                schema: "ShopList",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                schema: "ShopList",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                schema: "ShopList",
                newName: "Main",
                newSchema: "ShopList");

            migrationBuilder.RenameIndex(
                name: "IX_Items_CategoryId",
                schema: "ShopList",
                table: "Main",
                newName: "IX_Main_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Main",
                schema: "ShopList",
                table: "Main",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(237));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                schema: "ShopList",
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.AddForeignKey(
                name: "FK_Main_Category_CategoryId",
                schema: "ShopList",
                table: "Main",
                column: "CategoryId",
                principalSchema: "ShopList",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Main_ShopListEntityId",
                schema: "ShopList",
                table: "Product",
                column: "ShopListEntityId",
                principalSchema: "ShopList",
                principalTable: "Main",
                principalColumn: "Id");
        }
    }
}
