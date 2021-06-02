using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class ImageSchemaDefinition : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Images", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Url)
                .IsRequired();

            builder.HasOne(p => p.Product)
                .WithMany(i => i.Images)
                .HasForeignKey(fk => fk.ProductId);
        }
    }
}