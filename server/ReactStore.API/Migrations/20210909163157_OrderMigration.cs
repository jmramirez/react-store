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
                schema: "reactstore",
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
                name: "OrderItems",
                schema: "reactstore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    ColorId = table.Column<Guid>(type: "uuid", nullable: false),
                    StorageId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "reactstore",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_ProductVariants_ColorId_ProductId_StorageId",
                        columns: x => new { x.ColorId, x.ProductId, x.StorageId },
                        principalSchema: "reactstore",
                        principalTable: "ProductVariants",
                        principalColumns: new[] { "ColorId", "ProductId", "StorageId" },
                        onDelete: ReferentialAction.Cascade);
                });

            

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ColorId_ProductId_StorageId",
                schema: "reactstore",
                table: "OrderItems",
                columns: new[] { "ColorId", "ProductId", "StorageId" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                schema: "reactstore",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                schema: "reactstore",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems",
                schema: "reactstore");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "reactstore");

            
        }
    }
}
