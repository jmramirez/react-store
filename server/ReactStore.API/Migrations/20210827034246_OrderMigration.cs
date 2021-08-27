using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ReactStore.API.Migrations
{
    public partial class OrderMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Placed = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeliveryAddress_FirstName = table.Column<string>(type: "text", nullable: true),
                    DeliveryAddress_LastName = table.Column<string>(type: "text", nullable: true),
                    DeliveryAddress_Address1 = table.Column<string>(type: "text", nullable: true),
                    DeliveryAddress_Address2 = table.Column<string>(type: "text", nullable: true),
                    DeliveryAddress_TownCity = table.Column<string>(type: "text", nullable: true),
                    DeliveryAddress_Country = table.Column<string>(type: "text", nullable: true),
                    DeliveryAddress_Postcode = table.Column<string>(type: "text", nullable: true),
                    PaymentStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    ColorId = table.Column<int>(type: "integer", nullable: false),
                    StorageId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ProductVariantColorId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductVariantProductId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductVariantStorageId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_ProductVariants_ProductVariantColorId_ProductVari~",
                        columns: x => new { x.ProductVariantColorId, x.ProductVariantProductId, x.ProductVariantStorageId },
                        principalSchema: "reactstore",
                        principalTable: "ProductVariants",
                        principalColumns: new[] { "ColorId", "ProductId", "StorageId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductVariantColorId_ProductVariantProductId_Pro~",
                table: "OrderItem",
                columns: new[] { "ProductVariantColorId", "ProductVariantProductId", "ProductVariantStorageId" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Orders");

            
        }
    }
}
