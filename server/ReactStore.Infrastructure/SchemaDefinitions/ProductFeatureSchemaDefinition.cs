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
        }
    }
}