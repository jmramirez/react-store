using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class OsSchemaDefinition : IEntityTypeConfiguration<OS>
    {
        public void Configure(EntityTypeBuilder<OS> builder)
        {
            builder.ToTable("OS", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Name)
                .IsRequired();
        }
    }
}