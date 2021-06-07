using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactStore.API.Migrations
{
    public partial class AddProductVariants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("0ec56401-7552-422d-8c91-e4ae41380fbc"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("30462f05-b486-4ee0-b2d8-364d5627145d"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("30462f05-b486-4ee0-b2d8-364d5627145d"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("30462f05-b486-4ee0-b2d8-364d5627145d"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("30462f05-b486-4ee0-b2d8-364d5627145d"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("51c347f4-3293-4a63-9170-0531b325548d"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("51c347f4-3293-4a63-9170-0531b325548d"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("51c347f4-3293-4a63-9170-0531b325548d"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("51c347f4-3293-4a63-9170-0531b325548d"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("700b2a28-ea84-419c-bf6d-7fe1126b4b4b"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("52f4cfc5-10a6-41b2-8761-1273de874546") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("d004ef26-3c08-4f6e-8060-136029b75782"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("d6ffc78c-7ed0-4bd7-85a0-ac1677d31f59"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("2183be20-628e-480b-93e9-0b1fefb38120") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("ea32ab8f-e614-4327-955e-3b26670cc1c9"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("fee21a32-ec49-46cd-adf9-8ed4b15211c9"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("80c335a6-eaae-42eb-a83a-0d7f47dc543a") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductVariants",
                keyColumns: new[] { "ColorId", "ProductId", "StorageId" },
                keyValues: new object[] { new Guid("fee21a32-ec49-46cd-adf9-8ed4b15211c9"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("c1d112fd-5a18-415d-9a5f-9cbc602095a2") });

        }
    }
}
