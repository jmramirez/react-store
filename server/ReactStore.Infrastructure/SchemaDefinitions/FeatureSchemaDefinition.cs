using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class FeatureSchemaDefinition : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.ToTable("Features", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Name)
                .IsRequired();
        }
    }
}