using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class ProductVariantDefinition : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
            builder.ToTable("ProductVariants", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => new {k.ColorId, k.ProductId, k.StorageId});
            
            builder
                .HasOne(p => p.Color)
                .WithMany(p => p.ProductVariants)
                .HasForeignKey(fk => fk.ColorId);
            
            builder
                .HasOne(p => p.Product)
                .WithMany(p => p.ProductVariants)
                .HasForeignKey(fk => fk.ProductId);
            
            builder
                .HasOne(p => p.Storage)
                .WithMany(p => p.ProductVariants)
                .HasForeignKey(fk => fk.StorageId);

            builder.Property(p => p.Price)
                .HasPrecision(14, 2)
                .IsRequired();
        }
    }
}