using System;
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
            
            builder.HasData(
                new Feature()
                {
                    Id = Guid.NewGuid(),
                    Name = "5G"
                },
                new Feature()
                {
                    Id = Guid.NewGuid(),
                    Name = "4G"
                },
                new Feature()
                {
                    Id = Guid.NewGuid(),
                    Name = "Memory Expandable"
                },
                new Feature()
                {
                    Id = Guid.NewGuid(),
                    Name = "USB-C Connector"
                },
                new Feature()
                {
                    Id = Guid.NewGuid(),
                    Name = "Fast Charger"
                },
                new Feature()
                {
                    Id = Guid.NewGuid(),
                    Name= "Wireless  Charging"
                }
            );
        }
    }
}