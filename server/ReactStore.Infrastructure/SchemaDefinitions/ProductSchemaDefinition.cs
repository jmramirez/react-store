using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class ProductSchemaDefinition : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => k.Id);

            builder.HasIndex(p => p.Slug)
                .IsUnique();

            builder.Property(p => p.Name)
                .IsRequired();
            
            builder.Property(p => p.Slug)
                .IsRequired();
            
            builder.Property(p => p.Thumbnail)
                .IsRequired();
            
            builder.Property(p => p.ShortDescription)
                .IsRequired();
            
            builder.Property(p => p.Description)
                .IsRequired();
            
            builder.Property(p => p.ScreenSize)
                .HasPrecision(14,2)
                .IsRequired();
            
            builder.Property(p => p.TalkTime)
                .HasPrecision(14,2)
                .IsRequired();
            
            builder.Property(p => p.StandByTime)
                .HasPrecision(14,2)
                .IsRequired();

            builder
                .HasOne(p => p.OS)
                .WithMany(p => p.Products)
                .HasForeignKey(fk => fk.OSId);
            
            builder
                .HasOne(p => p.Brand)
                .WithMany(p => p.Products)
                .HasForeignKey(fk => fk.BrandId);
        }
    }
}