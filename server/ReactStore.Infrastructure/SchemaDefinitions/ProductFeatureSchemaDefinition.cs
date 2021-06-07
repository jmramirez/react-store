using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class ProductFeatureSchemaDefinition : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.ToTable("ProductFeatures", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(pf => new {pf.FeatureId, pf.ProductId});

            builder.HasOne(pf => pf.Feature)
                .WithMany(f => f.ProductFeatures)
                .HasForeignKey(k => k.FeatureId);
            
            builder.HasOne(pf => pf.Product)
                .WithMany(f => f.ProductFeatures)
                .HasForeignKey(k => k.ProductId);

            builder.HasData(
                new ProductFeature
                {
                    FeatureId = new Guid("AA9FB69A-380A-4C28-968F-61F700750153"),
                    ProductId = new Guid("7E60CF5A-0AAB-49D5-9EF2-3F2C9B0F097D")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("E22B3B21-A9DD-4BC8-8995-0660072C1D0B"),
                    ProductId = new Guid("7E60CF5A-0AAB-49D5-9EF2-3F2C9B0F097D")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("9F45ED5F-CBEB-4355-A9C2-7AA51FFCC1C9"),
                    ProductId = new Guid("7E60CF5A-0AAB-49D5-9EF2-3F2C9B0F097D")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("C225A75F-4805-46D6-BB1B-CE6FDA211B0D"),
                    ProductId = new Guid("7E60CF5A-0AAB-49D5-9EF2-3F2C9B0F097D")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("AA9FB69A-380A-4C28-968F-61F700750153"),
                    ProductId = new Guid("533ED09F-6A3A-4AD7-922F-76EBC4A9BC30")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("3F66E2B9-AD81-42C7-9923-A7EC1D9FE252"),
                    ProductId = new Guid("533ED09F-6A3A-4AD7-922F-76EBC4A9BC30")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("C225A75F-4805-46D6-BB1B-CE6FDA211B0D"),
                    ProductId = new Guid("533ED09F-6A3A-4AD7-922F-76EBC4A9BC30")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("EEB24885-50BE-4454-B5C4-53B5678AC8AA"),
                    ProductId = new Guid("533ED09F-6A3A-4AD7-922F-76EBC4A9BC30")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("AA9FB69A-380A-4C28-968F-61F700750153"),
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("EEB24885-50BE-4454-B5C4-53B5678AC8AA"),
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("C225A75F-4805-46D6-BB1B-CE6FDA211B0D"),
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("9F45ED5F-CBEB-4355-A9C2-7AA51FFCC1C9"),
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("AA9FB69A-380A-4C28-968F-61F700750153"),
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("C225A75F-4805-46D6-BB1B-CE6FDA211B0D"),
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("9F45ED5F-CBEB-4355-A9C2-7AA51FFCC1C9"),
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("AA9FB69A-380A-4C28-968F-61F700750153"),
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("9F45ED5F-CBEB-4355-A9C2-7AA51FFCC1C9"),
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("AA9FB69A-380A-4C28-968F-61F700750153"),
                    ProductId = new Guid("5B5087A0-5CAC-4FDE-B39D-D6FBDB7F5D57")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("EEB24885-50BE-4454-B5C4-53B5678AC8AA"),
                    ProductId = new Guid("5B5087A0-5CAC-4FDE-B39D-D6FBDB7F5D57")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("E22B3B21-A9DD-4BC8-8995-0660072C1D0B"),
                    ProductId = new Guid("5B5087A0-5CAC-4FDE-B39D-D6FBDB7F5D57")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("AA9FB69A-380A-4C28-968F-61F700750153"),
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("E22B3B21-A9DD-4BC8-8995-0660072C1D0B"),
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("EEB24885-50BE-4454-B5C4-53B5678AC8AA"),
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("9F45ED5F-CBEB-4355-A9C2-7AA51FFCC1C9"),
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3")
                },
                new ProductFeature
                {
                    FeatureId = new Guid("C225A75F-4805-46D6-BB1B-CE6FDA211B0D"),
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3")
                }
            );
        }
    }
}