using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactStore.API.Migrations
{
    public partial class AddProductFeaturesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("3f66e2b9-ad81-42c7-9923-a7ec1d9fe252"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"), new Guid("a3478123-d608-4032-b447-b634a2dec89c") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("9f45ed5f-cbeb-4355-a9c2-7aa51ffcc1c9"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("a3478123-d608-4032-b447-b634a2dec89c") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("aa9fb69a-380a-4c28-968f-61f700750153"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"), new Guid("d96901d6-44aa-4d67-b616-a347966df5a2") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("c225a75f-4805-46d6-bb1b-ce6fda211b0d"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("e22b3b21-a9dd-4bc8-8995-0660072c1d0b"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("e22b3b21-a9dd-4bc8-8995-0660072c1d0b"), new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("e22b3b21-a9dd-4bc8-8995-0660072c1d0b"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("eeb24885-50be-4454-b5c4-53b5678ac8aa"), new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("eeb24885-50be-4454-b5c4-53b5678ac8aa"), new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("eeb24885-50be-4454-b5c4-53b5678ac8aa"), new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73") });

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "ProductFeatures",
                keyColumns: new[] { "FeatureId", "ProductId" },
                keyValues: new object[] { new Guid("eeb24885-50be-4454-b5c4-53b5678ac8aa"), new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3") });
        }
    }
}
