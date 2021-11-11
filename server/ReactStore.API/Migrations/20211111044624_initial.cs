using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ReactStore.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "reactstore");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                schema: "reactstore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                schema: "reactstore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                schema: "reactstore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OS",
                schema: "reactstore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                schema: "reactstore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Capacity = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "Products",
                schema: "reactstore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Slug = table.Column<string>(type: "text", nullable: false),
                    Thumbnail = table.Column<string>(type: "text", nullable: false),
                    ShortDescription = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ScreenSize = table.Column<decimal>(type: "numeric(14,2)", precision: 14, scale: 2, nullable: false),
                    TalkTime = table.Column<decimal>(type: "numeric(14,2)", precision: 14, scale: 2, nullable: false),
                    StandByTime = table.Column<decimal>(type: "numeric(14,2)", precision: 14, scale: 2, nullable: false),
                    BrandId = table.Column<Guid>(type: "uuid", nullable: false),
                    OSId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalSchema: "reactstore",
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_OS_OSId",
                        column: x => x.OSId,
                        principalSchema: "reactstore",
                        principalTable: "OS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                schema: "reactstore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "reactstore",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                schema: "reactstore",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    FeatureId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => new { x.FeatureId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalSchema: "reactstore",
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "reactstore",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                schema: "reactstore",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    ColorId = table.Column<Guid>(type: "uuid", nullable: false),
                    StorageId = table.Column<Guid>(type: "uuid", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(14,2)", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ColorId, x.ProductId, x.StorageId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_Colors_ColorId",
                        column: x => x.ColorId,
                        principalSchema: "reactstore",
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "reactstore",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Storage_StorageId",
                        column: x => x.StorageId,
                        principalSchema: "reactstore",
                        principalTable: "Storage",
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "cc828056-a334-436d-a664-99c8631cd0e7", "Admin", "admin" },
                    { 2, "89ddd1f9-4b73-44e8-a45d-f813c3c1c6a1", "Customer", "customer" }
                });

            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6213ab61-e37d-40fe-9fd9-61ea21fba50b"), "Apple" },
                    { new Guid("7360baa4-71c3-442d-9328-7f9cfbdf5e1f"), "Samsung" },
                    { new Guid("8ab3a1c4-0b52-4671-ab2a-753e28c1a0be"), "Google" },
                    { new Guid("50c417df-62f4-4bd7-b9bc-692e0e1079e2"), "Motorola" },
                    { new Guid("777eeb02-68a3-4797-bfcd-fe1624c05710"), "LG" }
                });

            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0ec56401-7552-422d-8c91-e4ae41380fbc"), "Pink" },
                    { new Guid("fee21a32-ec49-46cd-adf9-8ed4b15211c9"), "Red" },
                    { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), "Red" },
                    { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), "Purple" },
                    { new Guid("d6ffc78c-7ed0-4bd7-85a0-ac1677d31f59"), "Grey" },
                    { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), "Blue" },
                    { new Guid("51c347f4-3293-4a63-9170-0531b325548d"), "White" },
                    { new Guid("30462f05-b486-4ee0-b2d8-364d5627145d"), "Black" },
                    { new Guid("61229546-f1a0-40e8-ace8-e14e6feac557"), "Green" }
                });

            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"), "Wireless  Charging" },
                    { new Guid("e22b3b21-a9dd-4bc8-8995-0660072c1d0b"), "USB-C Connector" },
                    { new Guid("eeb24885-50be-4454-b5c4-53b5678ac8aa"), "Fast Charger" },
                    { new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"), "4G" },
                    { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), "5G" },
                    { new Guid("3f66e2b9-ad81-42c7-9923-a7ec1d9fe252"), "Memory Expandable" }
                });
            
            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "OS",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79"), "Android" },
                    { new Guid("bc052339-a7a9-429f-a673-b03589b84fad"), "iOS" }
                });
            
            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "Storage",
                columns: new[] { "Id", "Capacity" },
                values: new object[,]
                {
                    { new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2"), "256GB" },
                    { new Guid("fb6e6a8c-19a9-4598-b290-97cce3e93272"), "32GB" },
                    { new Guid("2183be20-628e-480b-93e9-0b1fefb38120"), "64GB" },
                    { new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), "128GB" },
                    { new Guid("52f4cfc5-10a6-41b2-8761-1273de874546"), "512GB" }
                });
            
            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "Name", "OSId", "ScreenSize", "ShortDescription", "Slug", "StandByTime", "TalkTime", "Thumbnail" },
                values: new object[,]
                {
                    { new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("6213ab61-e37d-40fe-9fd9-61ea21fba50b"), "The best iPhone display ever for incredible contrast and higher resolution. With Ceramic Shield, which has four times better drop performance. Superfast speeds. Superlow latency. So you can get faster downloads, better-quality video streaming, more responsive gaming and real-time interactivity. A14 Bionic is the fastest chip in a smartphone. With a 16-core Neural Engine, it crunches trillions of operations each second. And it’s superefficient for great battery life. ", "iPhone 12 mini", new Guid("bc052339-a7a9-429f-a673-b03589b84fad"), 5.4m, "iPhone 12 Mini, 5G speed. A14 Bionic, the fastest chip in a smartphone. An edge-to-edge OLED display", "iphone-12-mini", 32m, 18m, "https://portfolioapps31.blob.core.windows.net/react-store-products/iphone-12-mini.png" },
                    { new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("6213ab61-e37d-40fe-9fd9-61ea21fba50b"), "The best iPhone display ever for incredible contrast and higher resolution. With Ceramic Shield, which has four times better drop performance. Superfast speeds. Superlow latency. So you can get faster downloads, better-quality video streaming, more responsive gaming and real-time interactivity.A14 Bionic is the fastest chip in a smartphone. With a 16-core Neural Engine, it crunches trillions of operations each second. And it’s superefficient for great battery life.", "iPhone 12", new Guid("bc052339-a7a9-429f-a673-b03589b84fad"), 6.1m, "iPhone 12, 5G speed. A14 Bionic, the fastest chip in a smartphone. An edge-to-edge OLED display.. And Night mode on every camera.", "iphone-12", 32m, 18m, "https://portfolioapps31.blob.core.windows.net/react-store-products/iphone-12.png" },
                    { new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("6213ab61-e37d-40fe-9fd9-61ea21fba50b"), "The Super Retina XDR display goes edge to edge. With Ceramic Shield, which has four times better drop performance. Superfast speeds. Superlow latency. So you can get faster downloads, better-quality video streaming, more responsive gaming and real-time interactivity. Introducing the first 5-nanometre chip in the industry. Which means more speed, more power and more efficiency. LiDAR creates accurate depth maps in nanoseconds, so objects are placed instantly and more accurately in AR experiences.", "iPhone 12 Pro Max", new Guid("bc052339-a7a9-429f-a673-b03589b84fad"), 6.7m, "iPhone 12 Pro Max, 5G speed. A14 Bionic, the fastest chip in a smartphone. And a Pro camera system that takes low-light photography to the next level — with an even bigger jump on iPhone 12 Pro Max.", "iphone-12-pro-max", 32m, 18m, "https://portfolioapps31.blob.core.windows.net/react-store-products/iphone-12-pro-max.png" },
                    { new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), new Guid("8ab3a1c4-0b52-4671-ab2a-753e28c1a0be"), "With 5G,you can download your favourite movies on the go and start watching before you know it. Go from game time to show time, all in crystal clear HD. Pixel’s 5G hotspot is powerful enough to keep multiple devices connected at once. HDR+ automatically enhances colour and lighting, so the photos that you take stay as vivid as you remember. With HD Duo screen sharing, you can read articles, watch live sports, and laugh together as if you were sitting in the same room. Adaptive Battery reduces power to the apps that you rarely use, so your mobile phone keeps its charge all day.", "Google Pixel 5", new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79"), 5.9m, "Pixel 5, The best of Google in 5G. Have a photo shoot day or night, capture moments with stunning clarity, and take clips with Hollywood-inspired effects.", "google-pixel-5", 32m, 18m, "https://portfolioapps31.blob.core.windows.net/react-store-products/google-pixel-5.png" },
                    { new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), new Guid("7360baa4-71c3-442d-9328-7f9cfbdf5e1f"), "This isn't the time to slow down, this is the time to forge ahead and take the opportunities that come your way. You don’t need a smartphone. You need a power phone. One as beautiful as it is intelligent with a pen that is mighty, a battery that doesn't leave you hanging and is as well-connected as you are. The Galaxy Note20 5G and Galaxy Note20 Ultra 5G take power to the next level with cutting-edge technology, letting you master whatever you choose to do next. The Galaxy Note20 5G and Galaxy Note20 Ultra 5G have a big battery. Big enough to last all day. But that's not all, it's also intelligent. The Galaxy Note20 5G and Galaxy Note20 Ultra 5G intuitively manage your app usage to conserve energy on its own so you don't need to. Rest assured that you can tackle those emails during the day and be left with enough power to tackle your opponents at night. And if you are running low on battery, get hours of power from minutes of charge with Super Fast Charging.", "Samsung Galaxy Note20", new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79"), 7m, "This isn't the time to slow down, this is the time to forge ahead and take the opportunities that come your way.", "samsung-galaxy-note-20", 32m, 18m, "https://portfolioapps31.blob.core.windows.net/react-store-products/galaxy-note20.png" },
                    { new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), new Guid("7360baa4-71c3-442d-9328-7f9cfbdf5e1f"), "Create share-ready GIFs and videos in one take1 or pick your favourite moments and pull your favorite stills in super high res to share with your followers. Zoom in close, take photos and videos like a pro, and capture incredible share-ready moments with our easy-to-use, multi-lens camera. Power every scroll, click, tap, and stream all day long and then some with an intelligent battery that works with you, not against you. A night out. Your best friend's birthday party. Family moments you'll want to remember forever. Capture your life's best moments in head-turning, super smooth 8K video.", "Samsung Galaxy S21 Ultra", new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79"), 7m, "Spontaneity, now captured from multiple angles. A camera so good, everyone's a pro. All-day battery, and then some. Trust us, you'll look amazing in 8K video.", "samsung-galaxy-s21-ultra", 32m, 18m, "https://portfolioapps31.blob.core.windows.net/react-store-products/galaxy-s21-ultra.png" },
                    { new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), new Guid("7360baa4-71c3-442d-9328-7f9cfbdf5e1f"), "Create share-ready GIFs and videos in one take1 or pick your favourite moments and pull your favorite stills in super high res to share with your followers. Zoom in close, take photos and videos like a pro, and capture incredible share-ready moments with our easy-to-use, multi-lens camera. Power every scroll, click, tap, and stream all day long and then some with an intelligent battery that works with you, not against you. A night out. Your best friend's birthday party. Family moments you'll want to remember forever. Capture your life's best moments in head-turning, super smooth 8K video.", "Samsung Galaxy S21", new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79"), 6m, "Spontaneity, now captured from multiple angles. A camera so good, everyone's a pro. All-day battery, and then some. Trust us, you'll look amazing in 8K video.", "samsung-galaxy-s21", 32m, 18m, "https://portfolioapps31.blob.core.windows.net/react-store-products/galaxy-s21.png" }
                });

            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "Images",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("329c8e94-89df-41cf-bfbb-d755887ba72c"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxys21/samsung-s21_3.png" },
                    { new Guid("a54657f0-f7b6-4d1e-badc-45d998067251"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxys21/samsung-s21_2.png" },
                    { new Guid("74219264-1849-4a56-9334-8994c81dbc18"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxys21/samsung-s21_1.png" },
                    { new Guid("e824f56e-3c29-4c3a-b109-fdae142963e5"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxys21/samsung-s21.png" },
                    { new Guid("63853ba3-cc78-4f93-adf0-99e2317d49b3"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), "https://portfolioapps31.blob.core.windows.net/react-store-google5/google-pixel5_3.png" },
                    { new Guid("5d1fa1f5-ebbc-497d-a466-15f808a57d46"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), "https://portfolioapps31.blob.core.windows.net/react-store-google5/google-pixel5_2.png" },
                    { new Guid("61d73ac0-62f4-4bea-bbe5-a92236e66ad7"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), "https://portfolioapps31.blob.core.windows.net/react-store-google5/google-pixel5_1.png" },
                    { new Guid("b1b6baa7-5cd2-4644-b841-31db6e8658c9"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), "https://portfolioapps31.blob.core.windows.net/react-store-google5/google-pixel5.png" },
                    { new Guid("e23770a3-d951-4951-8b34-ace211ae2c62"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), "https://portfolioapps31.blob.core.windows.net/react-store-iphone12mini/iphone-12-mini3.png" },
                    { new Guid("d0126a98-18c1-4aaa-a73f-113887fbf6c5"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), "https://portfolioapps31.blob.core.windows.net/react-store-iphone12mini/iphone-12-mini2.png" },
                    { new Guid("ae0b5688-58e2-4895-ba62-89b3c3e0f70f"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), "https://portfolioapps31.blob.core.windows.net/react-store-iphone12mini/iphone-12-mini1.png" },
                    { new Guid("d2457745-faaa-4256-92e3-8624c31875e5"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), "https://portfolioapps31.blob.core.windows.net/react-store-iphone12mini/iphone-12-mini.png" },
                    { new Guid("8090434e-9f17-4069-a36c-a9c3bcfc9249"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), "https://portfolioapps31.blob.core.windows.net/react-store-iphone12/iphone-12_2.png" },
                    { new Guid("2206c8ac-2e95-4291-b8fa-3f21410cc0ea"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), "https://portfolioapps31.blob.core.windows.net/react-store-iphone12promax/iphone12-pro2.png" },
                    { new Guid("8add73e7-ca13-4b8c-a8f4-0ae443dc6f5b"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), "https://portfolioapps31.blob.core.windows.net/react-store-iphone12/iphone-12.png" },
                    { new Guid("ec75817c-6083-4681-b25e-0ad6dca0fa97"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), "https://portfolioapps31.blob.core.windows.net/react-store-iphone12promax/iphone12-pro3.png" },
                    { new Guid("e0b114f2-d3e7-45e5-972d-5f6daf6cf528"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), "https://portfolioapps31.blob.core.windows.net/react-store-iphone12promax/iphone12-pro1.png" },
                    { new Guid("ca055cbd-deaf-475a-9520-4a6b9c9ffd43"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), "https://portfolioapps31.blob.core.windows.net/react-store-iphone12promax/iphone12-pro.png" },
                    { new Guid("36b795a6-37e4-4bff-b3fc-9fd6adae818a"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxynote20/galaxy-note20_3.png" },
                    { new Guid("4e552d81-b631-468b-a8f5-f944ba1eb0c1"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxynote20/galaxy-note20_2.png" },
                });
            
            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "Images",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("ddcfc599-8047-416a-9680-52678e68093f"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxynote20/galaxy-note20_1.png" },
                    { new Guid("08a2bc75-720f-4cbc-9167-8137b92e45ad"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxynote20/galaxy-note20.png" },
                    { new Guid("1f346493-2f60-4fe5-abb5-03f19a051fc7"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxys21ultra/samsung-s21-ultra3.png" },
                    { new Guid("f2275f1c-dc1a-48d8-9a13-bea3d3abb871"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxys21ultra/samsung-s21-ultra2.png" },
                    { new Guid("4c6ab638-cf37-4f56-98b7-f1d052f353e5"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxys21ultra/samsung-s21-ultra1.png" },
                    { new Guid("0a468c8d-5d8d-49a5-910f-3cffe1d4efd0"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), "https://portfolioapps31.blob.core.windows.net/react-store-galaxys21ultra/samsung-s21-ultra.png" },
                    { new Guid("aee9bb79-c0b4-41bd-bc57-83c19d9f186f"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), "https://portfolioapps31.blob.core.windows.net/react-store-iphone12/iphone-12_1.png" }
                });

            

            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "ProductFeatures",
                columns: new[] { "FeatureId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73") },
                    { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("a3478123-d608-4032-b447-b634a2dec89c") },
                    { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2") },
                    { new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2") },
                    { new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2") },
                    { new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"), new Guid("a3478123-d608-4032-b447-b634a2dec89c") },
                    { new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3") },
                    { new Guid("eeb24885-50be-4454-b5c4-53b5678ac8aa"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57") },
                    { new Guid("e22b3b21-a9dd-4bc8-8995-0660072c1d0b"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57") },
                    { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3") },
                    { new Guid("e22b3b21-a9dd-4bc8-8995-0660072c1d0b"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3") },
                    { new Guid("eeb24885-50be-4454-b5c4-53b5678ac8aa"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3") },
                    { new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73") },
                    { new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3") },
                    { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57") },
                    { new Guid("eeb24885-50be-4454-b5c4-53b5678ac8aa"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73") },
                    { new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d") },
                    { new Guid("eeb24885-50be-4454-b5c4-53b5678ac8aa"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30") },
                    { new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30") },
                    { new Guid("3f66e2b9-ad81-42c7-9923-a7ec1d9fe252"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30") },
                    { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30") },
                    { new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d") },
                    { new Guid("e22b3b21-a9dd-4bc8-8995-0660072c1d0b"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d") },
                    { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d") },
                    { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73") }
                });

            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "ProductVariants",
                columns: new[] { "ColorId", "ProductId", "StorageId", "Price" },
                values: new object[,]
                {
                    { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2"), 1380m },
                    { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120"), 1008m },
                    { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2"), 1225m },
                    { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1080m },
                    { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120"), 1008m },
                    { new Guid("51c347f4-3293-4a63-9170-0531b325548d"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1080m },
                    { new Guid("51c347f4-3293-4a63-9170-0531b325548d"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120"), 1008m },
                    { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2"), 1380m },
                });

            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "ProductVariants",
                columns: new[] { "ColorId", "ProductId", "StorageId", "Price" },
                values: new object[,]
                {
                    { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1236m },
                    { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120"), 1164m },
                    { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120"), 1008m },
                    { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1236m },
                    { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120"), 1164m },
                    { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2"), 1380m },
                    { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1236m },
                    { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120"), 1164m },
                    { new Guid("51c347f4-3293-4a63-9170-0531b325548d"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1236m },
                    { new Guid("51c347f4-3293-4a63-9170-0531b325548d"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120"), 1164m },
                    { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1400m },
                    { new Guid("0ec56401-7552-422d-8c91-e4ae41380fbc"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1400m },
                    { new Guid("d6ffc78c-7ed0-4bd7-85a0-ac1677d31f59"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1400m },
                    { new Guid("30462f05-b486-4ee0-b2d8-364d5627145d"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 950m },
                    { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2"), 1225m },
                    { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1080m },
                    { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1080m },
                    { new Guid("30462f05-b486-4ee0-b2d8-364d5627145d"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 2040m },
                    { new Guid("30462f05-b486-4ee0-b2d8-364d5627145d"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 2250m },
                    { new Guid("fee21a32-ec49-46cd-adf9-8ed4b15211c9"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 1596m },
                    { new Guid("fee21a32-ec49-46cd-adf9-8ed4b15211c9"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2"), 1740m },
                    { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"), 14596m },
                    { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2"), 1740m },
                    { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("52f4cfc5-10a6-41b2-8761-1273de874546"), 2016m },
                    { new Guid("30462f05-b486-4ee0-b2d8-364d5627145d"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2"), 2125m },
                    { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2"), 1225m }
                });

            

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Brands_Id",
                schema: "reactstore",
                table: "Brands",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                schema: "reactstore",
                table: "Images",
                column: "ProductId");

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                schema: "reactstore",
                table: "ProductFeatures",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                schema: "reactstore",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OSId",
                schema: "reactstore",
                table: "Products",
                column: "OSId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Slug",
                schema: "reactstore",
                table: "Products",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductId",
                schema: "reactstore",
                table: "ProductVariants",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_StorageId",
                schema: "reactstore",
                table: "ProductVariants",
                column: "StorageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Images",
                schema: "reactstore");

            migrationBuilder.DropTable(
                name: "OrderItems",
                schema: "reactstore");

            migrationBuilder.DropTable(
                name: "ProductFeatures",
                schema: "reactstore");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "reactstore");

            migrationBuilder.DropTable(
                name: "ProductVariants",
                schema: "reactstore");

            migrationBuilder.DropTable(
                name: "Features",
                schema: "reactstore");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Colors",
                schema: "reactstore");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "reactstore");

            migrationBuilder.DropTable(
                name: "Storage",
                schema: "reactstore");

            migrationBuilder.DropTable(
                name: "Brands",
                schema: "reactstore");

            migrationBuilder.DropTable(
                name: "OS",
                schema: "reactstore");
        }
    }
}
