using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class BrandSchemaDefinition : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasIndex(k => k.Id);

            builder.Property(p => p.Name)
                .IsRequired();

            builder.HasData(
                new Brand()
                {
                    Id = Guid.NewGuid(),
                    Name = "Apple"
                },
                new Brand()
                {
                    Id = Guid.NewGuid(),
                    Name = "Samsung"
                },
                new Brand()
                {
                    Id = Guid.NewGuid(),
                    Name = "Google"
                },
                new Brand()
                {
                    Id = Guid.NewGuid(),
                    Name = "Motorola"
                },
                new Brand()
                {
                    Id = Guid.NewGuid(),
                    Name = "LG"
                }
            );
        }
    }
}