using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class RolesSchemaDefinition : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                new AppRole
                {
                    Id = 1,
                    Name = "Admin"
                },
                new AppRole
                {
                    Id = 2,
                    Name = "Customer"
                }
            );
            
        }
    }
}