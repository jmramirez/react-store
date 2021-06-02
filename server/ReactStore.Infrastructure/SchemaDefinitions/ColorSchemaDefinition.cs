using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class ColorSchemaDefinition : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Colors", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Name)
                .IsRequired();
            
            
        }
    }
}