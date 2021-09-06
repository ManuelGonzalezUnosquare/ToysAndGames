using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class initDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AgeRestriction = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Pic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PicThumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Active", "CreatedAt", "Guid", "Name", "UpdatedAt" },
                values: new object[] { 1, true, new DateTime(2021, 9, 6, 23, 0, 45, 621, DateTimeKind.Utc).AddTicks(8643), new Guid("8cf803a9-424b-478c-943b-ee4e9afeebe8"), "Mattel", new DateTime(2021, 9, 6, 23, 0, 45, 621, DateTimeKind.Utc).AddTicks(9029) });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Active", "CreatedAt", "Guid", "Name", "UpdatedAt" },
                values: new object[] { 2, true, new DateTime(2021, 9, 6, 23, 0, 45, 621, DateTimeKind.Utc).AddTicks(9707), new Guid("cd51c2e7-ccc7-405e-929f-d45f5069d4a3"), "Nintendo", new DateTime(2021, 9, 6, 23, 0, 45, 621, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "AgeRestriction", "CompanyId", "CreatedAt", "Description", "Guid", "Name", "Pic", "PicThumbnail", "Price", "UpdatedAt" },
                values: new object[] { 1, true, 5, 2, new DateTime(2021, 9, 6, 23, 0, 45, 623, DateTimeKind.Utc).AddTicks(5240), "Introducing Nintendo Switch Lite, a version of the Nintendo Switch system that’s optimized.", new Guid("6043fee6-c1e6-43a5-8533-7561079619b7"), "Nintendo Switch Lite", "https://m.media-amazon.com/images/I/71qmF0FHj7L._AC_SL1500_.jpg", "https://res.cloudinary.com/walmart-labs/image/upload/w_225,dpr_auto,f_auto,q_auto:good/mg/gm/1p/images/product-images/img_large/00004549688228l.jpg", 8600m, new DateTime(2021, 9, 6, 23, 0, 45, 623, DateTimeKind.Utc).AddTicks(5257) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
