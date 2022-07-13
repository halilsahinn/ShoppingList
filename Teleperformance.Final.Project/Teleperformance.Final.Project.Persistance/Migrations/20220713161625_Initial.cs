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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                schema: "ShopList",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<byte>(type: "tinyint", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Category_CategoryId",
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Unit = table.Column<byte>(type: "tinyint", nullable: false),
                    ShopListEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "ShopList",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Items_ShopListEntityId",
                        column: x => x.ShopListEntityId,
                        principalSchema: "ShopList",
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "ShopList",
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateDate", "Description", "IsActive", "UpatedDate" },
                values: new object[] { 1, "Alışveriş Listesi", new DateTime(2022, 7, 13, 16, 16, 25, 339, DateTimeKind.Utc).AddTicks(6714), "", true, null });

            migrationBuilder.InsertData(
                schema: "ShopList",
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateDate", "Description", "IsActive", "UpatedDate" },
                values: new object[] { 2, "Film Listesi", new DateTime(2022, 7, 13, 16, 16, 25, 339, DateTimeKind.Utc).AddTicks(6716), "", true, null });

            migrationBuilder.InsertData(
                schema: "ShopList",
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateDate", "Description", "IsActive", "UpatedDate" },
                values: new object[] { 3, "Yapılacaklar Listesi", new DateTime(2022, 7, 13, 16, 16, 25, 339, DateTimeKind.Utc).AddTicks(6717), "", true, null });

            migrationBuilder.InsertData(
                schema: "ShopList",
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Description", "IsActive", "ProductName", "ShopListEntityId", "Unit", "UpatedDate" },
                values: new object[] { 1, 1, new DateTime(2022, 7, 13, 16, 16, 25, 339, DateTimeKind.Utc).AddTicks(6952), "", true, "Süt", null, (byte)1, null });

            migrationBuilder.InsertData(
                schema: "ShopList",
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Description", "IsActive", "ProductName", "ShopListEntityId", "Unit", "UpatedDate" },
                values: new object[] { 2, 1, new DateTime(2022, 7, 13, 16, 16, 25, 339, DateTimeKind.Utc).AddTicks(6955), "", true, "Çikolata", null, (byte)2, null });

            migrationBuilder.InsertData(
                schema: "ShopList",
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Description", "IsActive", "ProductName", "ShopListEntityId", "Unit", "UpatedDate" },
                values: new object[] { 3, 1, new DateTime(2022, 7, 13, 16, 16, 25, 339, DateTimeKind.Utc).AddTicks(6956), "", true, "Gazoz", null, (byte)3, null });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                schema: "ShopList",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                schema: "ShopList",
                table: "Product",
                column: "CategoryId");

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
                name: "Items",
                schema: "ShopList");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "ShopList");
        }
    }
}
