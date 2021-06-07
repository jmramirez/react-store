using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class ProductVariantSchemaDefinition : IEntityTypeConfiguration<ProductVariant>
    {
        public void Configure(EntityTypeBuilder<ProductVariant> builder)
        {
            builder.ToTable("ProductVariants", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => new {k.ColorId, k.ProductId, k.StorageId});
            
            builder
                .HasOne(p => p.Color)
                .WithMany(p => p.ProductVariants)
                .HasForeignKey(fk => fk.ColorId);
            
            builder
                .HasOne(p => p.Product)
                .WithMany(p => p.ProductVariants)
                .HasForeignKey(fk => fk.ProductId);
            
            builder
                .HasOne(p => p.Storage)
                .WithMany(p => p.ProductVariants)
                .HasForeignKey(fk => fk.StorageId);

            builder.Property(p => p.Price)
                .HasPrecision(14, 2)
                .IsRequired();

            builder.HasData(
                new ProductVariant
                {
                    ProductId = new Guid("7E60CF5A-0AAB-49D5-9EF2-3F2C9B0F097D"),
                    ColorId = new Guid("30462F05-B486-4EE0-B2D8-364D5627145D"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 2040M
                },
                new ProductVariant
                {
                    ProductId = new Guid("7E60CF5A-0AAB-49D5-9EF2-3F2C9B0F097D"),
                    ColorId = new Guid("30462F05-B486-4EE0-B2D8-364D5627145D"),
                    StorageId = new Guid("C1D112FD-5A18-415D-9A5F-9CBC602095A2"),
                    Price = 2125M
                },
                new ProductVariant
                {
                    ProductId = new Guid("533ED09F-6A3A-4AD7-922F-76EBC4A9BC30"),
                    ColorId = new Guid("30462F05-B486-4EE0-B2D8-364D5627145D"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 2250M
                },
                new ProductVariant
                {
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73"),
                    ColorId = new Guid("FEE21A32-EC49-46CD-ADF9-8ED4B15211C9"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1596M
                },
                new ProductVariant
                {
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73"),
                    ColorId = new Guid("FEE21A32-EC49-46CD-ADF9-8ED4B15211C9"),
                    StorageId = new Guid("C1D112FD-5A18-415D-9A5F-9CBC602095A2"),
                    Price = 1740M
                },
                new ProductVariant
                {
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73"),
                    ColorId = new Guid("D004EF26-3C08-4F6E-8060-136029B75782"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 14596M
                },
                new ProductVariant
                {
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73"),
                    ColorId = new Guid("D004EF26-3C08-4F6E-8060-136029B75782"),
                    StorageId = new Guid("C1D112FD-5A18-415D-9A5F-9CBC602095A2"),
                    Price = 1740M
                },
                new ProductVariant
                {
                    ProductId = new Guid("8B94CAE3-0EF3-4E2E-BBCD-92EC689D3B73"),
                    ColorId = new Guid("D004EF26-3C08-4F6E-8060-136029B75782"),
                    StorageId = new Guid("52F4CFC5-10A6-41B2-8761-1273DE874546"),
                    Price = 2016M
                },
                new ProductVariant
                {
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2"),
                    ColorId = new Guid("51C347F4-3293-4A63-9170-0531B325548D"),
                    StorageId = new Guid("2183BE20-628E-480B-93E9-0B1FEFB38120"),
                    Price = 1164M
                },
                new ProductVariant
                {
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2"),
                    ColorId = new Guid("51C347F4-3293-4A63-9170-0531B325548D"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1236M
                },
                new ProductVariant
                {
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2"),
                    ColorId = new Guid("D004EF26-3C08-4F6E-8060-136029B75782"),
                    StorageId = new Guid("2183BE20-628E-480B-93E9-0B1FEFB38120"),
                    Price = 1164M
                },
                new ProductVariant
                {
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2"),
                    ColorId = new Guid("D004EF26-3C08-4F6E-8060-136029B75782"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1236M
                },
                new ProductVariant
                {
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2"),
                    ColorId = new Guid("D004EF26-3C08-4F6E-8060-136029B75782"),
                    StorageId = new Guid("C1D112FD-5A18-415D-9A5F-9CBC602095A2"),
                    Price = 1380M
                },
                new ProductVariant
                {
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2"),
                    ColorId = new Guid("700B2A28-EA84-419C-BF6D-7FE1126B4B4B"),
                    StorageId = new Guid("2183BE20-628E-480B-93E9-0B1FEFB38120"),
                    Price = 1164M
                },
                new ProductVariant
                {
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2"),
                    ColorId = new Guid("700B2A28-EA84-419C-BF6D-7FE1126B4B4B"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1236M
                },
                new ProductVariant
                {
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2"),
                    ColorId = new Guid("700B2A28-EA84-419C-BF6D-7FE1126B4B4B"),
                    StorageId = new Guid("C1D112FD-5A18-415D-9A5F-9CBC602095A2"),
                    Price = 1380M
                },
                new ProductVariant
                {
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2"),
                    ColorId = new Guid("EA32AB8F-E614-4327-955E-3B26670CC1C9"),
                    StorageId = new Guid("2183BE20-628E-480B-93E9-0B1FEFB38120"),
                    Price = 1164M
                },
                new ProductVariant
                {
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2"),
                    ColorId = new Guid("EA32AB8F-E614-4327-955E-3B26670CC1C9"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1236M
                },
                new ProductVariant
                {
                    ProductId = new Guid("D96901D6-44AA-4D67-B616-A347966DF5A2"),
                    ColorId = new Guid("EA32AB8F-E614-4327-955E-3B26670CC1C9"),
                    StorageId = new Guid("C1D112FD-5A18-415D-9A5F-9CBC602095A2"),
                    Price = 1380M
                },
                new ProductVariant
                {
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C"),
                    ColorId = new Guid("51C347F4-3293-4A63-9170-0531B325548D"),
                    StorageId = new Guid("2183BE20-628E-480B-93E9-0B1FEFB38120"),
                    Price = 1008M
                },
                new ProductVariant
                {
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C"),
                    ColorId = new Guid("51C347F4-3293-4A63-9170-0531B325548D"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1080M
                },
                new ProductVariant
                {
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C"),
                    ColorId = new Guid("D004EF26-3C08-4F6E-8060-136029B75782"),
                    StorageId = new Guid("2183BE20-628E-480B-93E9-0B1FEFB38120"),
                    Price = 1008M
                },
                new ProductVariant
                {
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C"),
                    ColorId = new Guid("D004EF26-3C08-4F6E-8060-136029B75782"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1080M
                },
                new ProductVariant
                {
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C"),
                    ColorId = new Guid("D004EF26-3C08-4F6E-8060-136029B75782"),
                    StorageId = new Guid("C1D112FD-5A18-415D-9A5F-9CBC602095A2"),
                    Price = 1225M
                },
                new ProductVariant
                {
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C"),
                    ColorId = new Guid("700B2A28-EA84-419C-BF6D-7FE1126B4B4B"),
                    StorageId = new Guid("2183BE20-628E-480B-93E9-0B1FEFB38120"),
                    Price = 1008M
                },
                new ProductVariant
                {
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C"),
                    ColorId = new Guid("700B2A28-EA84-419C-BF6D-7FE1126B4B4B"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1080M
                },
                new ProductVariant
                {
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C"),
                    ColorId = new Guid("700B2A28-EA84-419C-BF6D-7FE1126B4B4B"),
                    StorageId = new Guid("C1D112FD-5A18-415D-9A5F-9CBC602095A2"),
                    Price = 1225M
                },
                new ProductVariant
                {
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C"),
                    ColorId = new Guid("EA32AB8F-E614-4327-955E-3B26670CC1C9"),
                    StorageId = new Guid("2183BE20-628E-480B-93E9-0B1FEFB38120"),
                    Price = 1008M
                },
                new ProductVariant
                {
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C"),
                    ColorId = new Guid("EA32AB8F-E614-4327-955E-3B26670CC1C9"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1080M
                },
                new ProductVariant
                {
                    ProductId = new Guid("A3478123-D608-4032-B447-B634A2DEC89C"),
                    ColorId = new Guid("EA32AB8F-E614-4327-955E-3B26670CC1C9"),
                    StorageId = new Guid("C1D112FD-5A18-415D-9A5F-9CBC602095A2"),
                    Price = 1225M
                },
                new ProductVariant
                {
                    ProductId = new Guid("5B5087A0-5CAC-4FDE-B39D-D6FBDB7F5D57"),
                    ColorId = new Guid("30462F05-B486-4EE0-B2D8-364D5627145D"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 950M
                },
                new ProductVariant
                {
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3"),
                    ColorId = new Guid("D6FFC78C-7ED0-4BD7-85A0-AC1677D31F59"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1400M
                },
                new ProductVariant
                {
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3"),
                    ColorId = new Guid("0EC56401-7552-422D-8C91-E4AE41380FBC"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1400M
                },
                new ProductVariant
                {
                    ProductId = new Guid("FC386A0A-48A8-49E9-AFF7-E0BF6902D3B3"),
                    ColorId = new Guid("EA32AB8F-E614-4327-955E-3B26670CC1C9"),
                    StorageId = new Guid("80C335A6-EAAE-42EB-A83A-0D7F47DC543A"),
                    Price = 1400M
                }
            );
        }
    }
}