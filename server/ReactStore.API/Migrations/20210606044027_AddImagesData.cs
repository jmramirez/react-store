using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactStore.API.Migrations
{
    public partial class AddImagesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "Images",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("329c8e94-89df-41cf-bfbb-d755887ba72c"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), "https://localhost:5001/galaxys21/samsung-s21_3.png" },
                    { new Guid("a54657f0-f7b6-4d1e-badc-45d998067251"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), "https://localhost:5001/galaxys21/samsung-s21_2.png" },
                    { new Guid("74219264-1849-4a56-9334-8994c81dbc18"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), "https://localhost:5001/galaxys21/samsung-s21_1.png" },
                    { new Guid("e824f56e-3c29-4c3a-b109-fdae142963e5"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), "https://localhost:5001/galaxys21/samsung-s21.png" },
                    { new Guid("63853ba3-cc78-4f93-adf0-99e2317d49b3"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), "https://localhost:5001/google5/google-pixel5_3.png" },
                    { new Guid("5d1fa1f5-ebbc-497d-a466-15f808a57d46"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), "https://localhost:5001/google5/google-pixel5_2.png" },
                    { new Guid("61d73ac0-62f4-4bea-bbe5-a92236e66ad7"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), "https://localhost:5001/google5/google-pixel5_1.png" },
                    { new Guid("b1b6baa7-5cd2-4644-b841-31db6e8658c9"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), "https://localhost:5001/google5/google-pixel5.png" },
                    { new Guid("e23770a3-d951-4951-8b34-ace211ae2c62"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), "https://localhost:5001/iphone12mini/iphone-12-mini3.png" },
                    { new Guid("d0126a98-18c1-4aaa-a73f-113887fbf6c5"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), "https://localhost:5001/iphone12mini/iphone-12-mini2.png" },
                    { new Guid("ae0b5688-58e2-4895-ba62-89b3c3e0f70f"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), "https://localhost:5001/iphone12mini/iphone-12-mini1.png" },
                    { new Guid("d2457745-faaa-4256-92e3-8624c31875e5"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), "https://localhost:5001/iphone12mini/iphone-12-mini.png" },
                    { new Guid("8090434e-9f17-4069-a36c-a9c3bcfc9249"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), "https://localhost:5001/iphone12/iphone-12_2.png" },
                    { new Guid("2206c8ac-2e95-4291-b8fa-3f21410cc0ea"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), "https://localhost:5001/iphone12promax/iphone12-pro2.png" },
                    { new Guid("8add73e7-ca13-4b8c-a8f4-0ae443dc6f5b"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), "https://localhost:5001/iphone12/iphone-12.png" },
                    { new Guid("ec75817c-6083-4681-b25e-0ad6dca0fa97"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), "https://localhost:5001/iphone12promax/iphone12-pro3.png" },
                    { new Guid("e0b114f2-d3e7-45e5-972d-5f6daf6cf528"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), "https://localhost:5001/iphone12promax/iphone12-pro1.png" },
                    { new Guid("ca055cbd-deaf-475a-9520-4a6b9c9ffd43"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), "https://localhost:5001/iphone12promax/iphone12-pro.png" },
                    { new Guid("36b795a6-37e4-4bff-b3fc-9fd6adae818a"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), "https://localhost:5001/galaxynote20/galaxy-note20_3.png" },
                    { new Guid("4e552d81-b631-468b-a8f5-f944ba1eb0c1"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), "https://localhost:5001/galaxynote20/galaxy-note20_2.png" },
                    { new Guid("ddcfc599-8047-416a-9680-52678e68093f"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), "https://localhost:5001/galaxynote20/galaxy-note20_1.png" },
                    { new Guid("08a2bc75-720f-4cbc-9167-8137b92e45ad"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), "https://localhost:5001/galaxynote20/galaxy-note20.png" }
                });

            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "Images",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("1f346493-2f60-4fe5-abb5-03f19a051fc7"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), "https://localhost:5001/galaxys21ultra/samsung-s21-ultra3.png" },
                    { new Guid("f2275f1c-dc1a-48d8-9a13-bea3d3abb871"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), "https://localhost:5001/galaxys21ultra/samsung-s21-ultra2.png" },
                    { new Guid("4c6ab638-cf37-4f56-98b7-f1d052f353e5"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), "https://localhost:5001/galaxys21ultra/samsung-s21-ultra1.png" },
                    { new Guid("0a468c8d-5d8d-49a5-910f-3cffe1d4efd0"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), "https://localhost:5001/galaxys21ultra/samsung-s21-ultra.png" },
                    { new Guid("aee9bb79-c0b4-41bd-bc57-83c19d9f186f"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), "https://localhost:5001/iphone12/iphone-12_1.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("08a2bc75-720f-4cbc-9167-8137b92e45ad"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0a468c8d-5d8d-49a5-910f-3cffe1d4efd0"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("1f346493-2f60-4fe5-abb5-03f19a051fc7"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2206c8ac-2e95-4291-b8fa-3f21410cc0ea"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("329c8e94-89df-41cf-bfbb-d755887ba72c"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("36b795a6-37e4-4bff-b3fc-9fd6adae818a"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4c6ab638-cf37-4f56-98b7-f1d052f353e5"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4e552d81-b631-468b-a8f5-f944ba1eb0c1"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5d1fa1f5-ebbc-497d-a466-15f808a57d46"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("61d73ac0-62f4-4bea-bbe5-a92236e66ad7"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("63853ba3-cc78-4f93-adf0-99e2317d49b3"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("74219264-1849-4a56-9334-8994c81dbc18"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8090434e-9f17-4069-a36c-a9c3bcfc9249"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("8add73e7-ca13-4b8c-a8f4-0ae443dc6f5b"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a54657f0-f7b6-4d1e-badc-45d998067251"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ae0b5688-58e2-4895-ba62-89b3c3e0f70f"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("aee9bb79-c0b4-41bd-bc57-83c19d9f186f"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b1b6baa7-5cd2-4644-b841-31db6e8658c9"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ca055cbd-deaf-475a-9520-4a6b9c9ffd43"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d0126a98-18c1-4aaa-a73f-113887fbf6c5"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d2457745-faaa-4256-92e3-8624c31875e5"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ddcfc599-8047-416a-9680-52678e68093f"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e0b114f2-d3e7-45e5-972d-5f6daf6cf528"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e23770a3-d951-4951-8b34-ace211ae2c62"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("e824f56e-3c29-4c3a-b109-fdae142963e5"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ec75817c-6083-4681-b25e-0ad6dca0fa97"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f2275f1c-dc1a-48d8-9a13-bea3d3abb871"));

        }
    }
}
