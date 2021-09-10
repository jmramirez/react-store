using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class OrderItemSchemaDefinition : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => k.Id);

            builder
                .HasOne(v => v.ProductVariant)
                .WithMany(pv => pv.Items)
                .HasForeignKey(fk => new { fk.ColorId, fk.ProductId, fk.StorageId});
        }
    }
}