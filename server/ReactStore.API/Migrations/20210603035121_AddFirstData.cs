using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactStore.API.Migrations
{
    public partial class AddFirstData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("50c417df-62f4-4bd7-b9bc-692e0e1079e2"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("6213ab61-e37d-40fe-9fd9-61ea21fba50b"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("7360baa4-71c3-442d-9328-7f9cfbdf5e1f"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("777eeb02-68a3-4797-bfcd-fe1624c05710"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8ab3a1c4-0b52-4671-ab2a-753e28c1a0be"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("0ec56401-7552-422d-8c91-e4ae41380fbc"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("30462f05-b486-4ee0-b2d8-364d5627145d"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("51c347f4-3293-4a63-9170-0531b325548d"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("61229546-f1a0-40e8-ace8-e14e6feac557"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d004ef26-3c08-4f6e-8060-136029b75782"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d6ffc78c-7ed0-4bd7-85a0-ac1677d31f59"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("fee21a32-ec49-46cd-adf9-8ed4b15211c9"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("3f66e2b9-ad81-42c7-9923-a7ec1d9fe252"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("aa9fb69a-380a-4c28-968f-61f700750153"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("e22b3b21-a9dd-4bc8-8995-0660072c1d0b"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("eeb24885-50be-4454-b5c4-53b5678ac8aa"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "OS",
                keyColumn: "Id",
                keyValue: new Guid("bc052339-a7a9-429f-a673-b03589b84fad"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "OS",
                keyColumn: "Id",
                keyValue: new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Storage",
                keyColumn: "Id",
                keyValue: new Guid("2183be20-628e-480b-93e9-0b1fefb38120"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Storage",
                keyColumn: "Id",
                keyValue: new Guid("52f4cfc5-10a6-41b2-8761-1273de874546"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Storage",
                keyColumn: "Id",
                keyValue: new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Storage",
                keyColumn: "Id",
                keyValue: new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Storage",
                keyColumn: "Id",
                keyValue: new Guid("fb6e6a8c-19a9-4598-b290-97cce3e93272"));
        }
    }
}
