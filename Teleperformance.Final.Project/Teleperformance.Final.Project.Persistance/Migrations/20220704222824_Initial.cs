using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teleperformance.Final.Project.Persistance.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ShopList");

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "ShopList",
                columns: table => new
                {
                    CategoryName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Main",
                schema: "ShopList",
                columns: table => new
                {
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<byte>(type: "tinyint", nullable: false),
                    IsTaken = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Main_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "ShopList",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "ShopList",
                columns: table => new
                {
                    ProductName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<byte>(type: "tinyint", nullable: false),
                    CategoryEntityId = table.Column<int>(type: "int", nullable: true),
                    ShopListEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryEntityId",
                        column: x => x.CategoryEntityId,
                        principalSchema: "ShopList",
                        principalTable: "Category",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_Main_ShopListEntityId",
                        column: x => x.ShopListEntityId,
                        principalSchema: "ShopList",
                        principalTable: "Main",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "ShopList",
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateDate", "Description", "IsActive", "UpatedDate" },
                values: new object[,]
                {
                    { 1, "Alışveriş Listesi", new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(235), "", true, null },
                    { 2, "Film Listesi", new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(237), "", true, null },
                    { 3, "Yapılacaklar Listesi", new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(238), "", true, null }
                });

            migrationBuilder.InsertData(
                schema: "ShopList",
                table: "Product",
                columns: new[] { "Id", "CategoryEntityId", "CreateDate", "Description", "IsActive", "ProductName", "ShopListEntityId", "Unit", "UpatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(526), "", true, "Süt", null, (byte)1, null },
                    { 2, null, new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(528), "", true, "Çikolata", null, (byte)2, null },
                    { 3, null, new DateTime(2022, 7, 4, 22, 28, 23, 952, DateTimeKind.Utc).AddTicks(529), "", true, "Gazoz", null, (byte)3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Main_CategoryId",
                schema: "ShopList",
                table: "Main",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryEntityId",
                schema: "ShopList",
                table: "Product",
                column: "CategoryEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ShopListEntityId",
                schema: "ShopList",
                table: "Product",
                column: "ShopListEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product",
                schema: "ShopList");

            migrationBuilder.DropTable(
                name: "Main",
                schema: "ShopList");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "ShopList");
        }
    }
}
