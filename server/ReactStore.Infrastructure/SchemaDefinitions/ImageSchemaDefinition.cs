using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class ImageSchemaDefinition : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Images", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Url)
                .IsRequired();

            builder.HasOne(p => p.Product)
                .WithMany(i => i.Images)
                .HasForeignKey(fk => fk.ProductId);

            builder.HasData(
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url ="https://localhost:5001/galaxys21ultra/samsung-s21-ultra.png",
                    ProductId = new Guid("7E60CF5A-0AAB-49D5-9EF2-3F2C9B0F097D")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url ="https://localhost:5001/galaxys21ultra/samsung-s21-ultra1.png",
                    ProductId = new Guid("7E60CF5A-0AAB-49D5-9EF2-3F2C9B0F097D")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url ="https://localhost:5001/galaxys21ultra/samsung-s21-ultra2.png",
                    ProductId = new Guid("7E60CF5A-0AAB-49D5-9EF2-3F2C9B0F097D")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url ="https://localhost:5001/galaxys21ultra/samsung-s21-ultra3.png",
                    ProductId = new Guid("7E60CF5A-0AAB-49D5-9EF2-3F2C9B0F097D")
                },
               new Image()
               {
                   Id = Guid.NewGuid(),
                   Url = "https://localhost:5001/galaxynote20/galaxy-note20.png",
                   ProductId = new Guid("533ED09F-6A3A-4AD7-922F-76EBC4A9BC30")
               },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/galaxynote20/galaxy-note20_1.png",
                    ProductId = new Guid("533ED09F-6A3A-4AD7-922F-76EBC4A9BC30")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/galaxynote20/galaxy-note20_2.png",
                    ProductId = new Guid("533ED09F-6A3A-4AD7-922F-76EBC4A9BC30")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/galaxynote20/galaxy-note20_3.png",
                    ProductId = new Guid("533ED09F-6A3A-4AD7-922F-76EBC4A9BC30")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/iphone12promax/iphone12-pro.png",
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/iphone12promax/iphone12-pro1.png",
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/iphone12promax/iphone12-pro2.png",
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/iphone12promax/iphone12-pro3.png",
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/iphone12/iphone-12.png",
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/iphone12/iphone-12_1.png",
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/iphone12/iphone-12_2.png",
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/iphone12mini/iphone-12-mini.png",
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/iphone12mini/iphone-12-mini1.png",
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/iphone12mini/iphone-12-mini2.png",
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/iphone12mini/iphone-12-mini3.png",
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/google5/google-pixel5.png",
                    ProductId = new Guid("5B5087A0-5CAC-4FDE-B39D-D6FBDB7F5D57")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/google5/google-pixel5_1.png",
                    ProductId = new Guid("5B5087A0-5CAC-4FDE-B39D-D6FBDB7F5D57")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/google5/google-pixel5_2.png",
                    ProductId = new Guid("5B5087A0-5CAC-4FDE-B39D-D6FBDB7F5D57")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/google5/google-pixel5_3.png",
                    ProductId = new Guid("5B5087A0-5CAC-4FDE-B39D-D6FBDB7F5D57")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/galaxys21/samsung-s21.png",
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/galaxys21/samsung-s21_1.png",
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/galaxys21/samsung-s21_2.png",
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3")
                },
                new Image()
                {
                    Id = Guid.NewGuid(),
                    Url = "https://localhost:5001/galaxys21/samsung-s21_3.png",
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3")
                }
            );
        }
    }
}