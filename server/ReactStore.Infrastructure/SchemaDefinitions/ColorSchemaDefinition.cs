using System;
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

            builder.HasData(
                new Color()
                {
                    Id = Guid.NewGuid(),
                    Name = "Black"
                },
                new Color()
                {
                    Id = Guid.NewGuid(),
                    Name = "White"
                },
                new Color()
                {
                    Id = Guid.NewGuid(),
                    Name = "Blue"
                },
                new Color()
                {
                    Id = Guid.NewGuid(),
                    Name = "Green"
                },
                new Color()
                {
                    Id = Guid.NewGuid(),
                    Name = "Purple"
                },
                new Color()
                {
                    Id = Guid.NewGuid(),
                    Name = "Red"
                },
                new Color()
                {
                    Id = Guid.NewGuid(),
                    Name = "Red"
                },
                new Color()
                {
                    Id = Guid.NewGuid(),
                    Name = "Pink"
                },
                new Color()
                {
                    Id = Guid.NewGuid(),
                    Name="Grey"
                }
            );
        }
    }
}