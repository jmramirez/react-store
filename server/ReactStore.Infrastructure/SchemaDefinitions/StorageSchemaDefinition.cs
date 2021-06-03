using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class StorageSchemaDefinition : IEntityTypeConfiguration<Storage>
    {
        public void Configure(EntityTypeBuilder<Storage> builder)
        {
            builder.ToTable("Storage", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Capacity)
                .IsRequired();
            
            builder.HasData(
                new Storage()
                {
                    Id = Guid.NewGuid(),
                    Capacity = "32GB"
                },
                new Storage()
                {
                    Id = Guid.NewGuid(),
                    Capacity = "64GB"
                },
                new Storage()
                {
                    Id = Guid.NewGuid(),
                    Capacity = "128GB"
                },
                new Storage()
                {
                    Id = Guid.NewGuid(),
                    Capacity = "256GB"
                },
                new Storage()
                {
                    Id = Guid.NewGuid(),
                    Capacity = "512GB"
                }
            );
        }
    }
}