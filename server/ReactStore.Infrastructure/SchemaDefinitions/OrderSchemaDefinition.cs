using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class OrderSchemaDefinition : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => k.Id);

            builder
                .HasOne(u => u.User)
                .WithMany(o => o.Orders)
                .HasForeignKey(fk => fk.UserId);
            
            
            
            builder
                .OwnsOne(x => x.DeliveryAddress);
        }
    }
}