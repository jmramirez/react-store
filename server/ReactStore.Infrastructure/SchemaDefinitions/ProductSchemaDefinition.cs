using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReactStore.Domain.Entities;

namespace ReactStore.Infrastructure.SchemaDefinitions
{
    public class ProductSchemaDefinition : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", ReactStoreContext.DEFAULT_SCHEMA);
            builder.HasKey(k => k.Id);

            builder.HasIndex(p => p.Slug)
                .IsUnique();

            builder.Property(p => p.Name)
                .IsRequired();
            
            builder.Property(p => p.Slug)
                .IsRequired();
            
            builder.Property(p => p.Thumbnail)
                .IsRequired();
            
            builder.Property(p => p.ShortDescription)
                .IsRequired();
            
            builder.Property(p => p.Description)
                .IsRequired();
            
            builder.Property(p => p.ScreenSize)
                .HasPrecision(14,2)
                .IsRequired();
            
            builder.Property(p => p.TalkTime)
                .HasPrecision(14,2)
                .IsRequired();
            
            builder.Property(p => p.StandByTime)
                .HasPrecision(14,2)
                .IsRequired();

            builder
                .HasOne(p => p.OS)
                .WithMany(p => p.Products)
                .HasForeignKey(fk => fk.OSId);
            
            builder
                .HasOne(p => p.Brand)
                .WithMany(p => p.Products)
                .HasForeignKey(fk => fk.BrandId);

            builder.HasData(
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "iPhone 12 mini",
                    Slug = "iphone-12-mini",
                    Thumbnail = "https://localhost:5001/thumbnails/iphone-12-mini.png",
                    ShortDescription = "iPhone 12 Mini, 5G speed. A14 Bionic, the fastest chip in a smartphone. An edge-to-edge OLED display",
                    Description = "The best iPhone display ever for incredible contrast and higher resolution. With Ceramic Shield, which has four times better drop performance. Superfast speeds. Superlow latency. So you can get faster downloads, better-quality video streaming, more responsive gaming and real-time interactivity. A14 Bionic is the fastest chip in a smartphone. With a 16-core Neural Engine, it crunches trillions of operations each second. And it’s superefficient for great battery life. ",
                    ScreenSize = 5.4M,
                    TalkTime = 18M,
                    StandByTime = 32M,
                    BrandId = new Guid("6213ab61-e37d-40fe-9fd9-61ea21fba50b"),
                    OSId = new Guid("bc052339-a7a9-429f-a673-b03589b84fad")
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "iPhone 12",
                    Slug = "iphone-12",
                    Thumbnail = "https://localhost:5001/thumbnails/iphone-12.png",
                    ShortDescription = "iPhone 12, 5G speed. A14 Bionic, the fastest chip in a smartphone. An edge-to-edge OLED display.. And Night mode on every camera.",
                    Description = "The best iPhone display ever for incredible contrast and higher resolution. With Ceramic Shield, which has four times better drop performance. Superfast speeds. Superlow latency. So you can get faster downloads, better-quality video streaming, more responsive gaming and real-time interactivity.A14 Bionic is the fastest chip in a smartphone. With a 16-core Neural Engine, it crunches trillions of operations each second. And it’s superefficient for great battery life.",
                    ScreenSize = 6.1M,
                    TalkTime = 18M,
                    StandByTime = 32M,
                    BrandId = new Guid("6213ab61-e37d-40fe-9fd9-61ea21fba50b"),
                    OSId = new Guid("bc052339-a7a9-429f-a673-b03589b84fad")
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "iPhone 12 Pro Max",
                    Slug = "iphone-12-pro-max",
                    Thumbnail = "https://localhost:5001/thumbnails/iphone-12-pro-max.png",
                    ShortDescription = "iPhone 12 Pro Max, 5G speed. A14 Bionic, the fastest chip in a smartphone. And a Pro camera system that takes low-light photography to the next level — with an even bigger jump on iPhone 12 Pro Max.",
                    Description = "The Super Retina XDR display goes edge to edge. With Ceramic Shield, which has four times better drop performance. Superfast speeds. Superlow latency. So you can get faster downloads, better-quality video streaming, more responsive gaming and real-time interactivity. Introducing the first 5-nanometre chip in the industry. Which means more speed, more power and more efficiency. LiDAR creates accurate depth maps in nanoseconds, so objects are placed instantly and more accurately in AR experiences.",
                    ScreenSize = 6.7M,
                    TalkTime = 18M,
                    StandByTime = 32M,
                    BrandId = new Guid("6213ab61-e37d-40fe-9fd9-61ea21fba50b"),
                    OSId = new Guid("bc052339-a7a9-429f-a673-b03589b84fad")
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Google Pixel 5",
                    Slug = "google-pixel-5",
                    Thumbnail = "https://localhost:5001/thumbnails/google-pixel-5.png",
                    ShortDescription = "Pixel 5, The best of Google in 5G. Have a photo shoot day or night, capture moments with stunning clarity, and take clips with Hollywood-inspired effects.",
                    Description = "With 5G,you can download your favourite movies on the go and start watching before you know it. Go from game time to show time, all in crystal clear HD. Pixel’s 5G hotspot is powerful enough to keep multiple devices connected at once. HDR+ automatically enhances colour and lighting, so the photos that you take stay as vivid as you remember. With HD Duo screen sharing, you can read articles, watch live sports, and laugh together as if you were sitting in the same room. Adaptive Battery reduces power to the apps that you rarely use, so your mobile phone keeps its charge all day.",
                    ScreenSize = 5.9M,
                    TalkTime = 18M,
                    StandByTime = 32M,
                    BrandId = new Guid("8ab3a1c4-0b52-4671-ab2a-753e28c1a0be"),
                    OSId = new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79")
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Samsung Galaxy Note20",
                    Slug = "samsung-galaxy-note-20",
                    Thumbnail = "https://localhost:5001/thumbnails/galaxy-note20.png",
                    ShortDescription = "This isn't the time to slow down, this is the time to forge ahead and take the opportunities that come your way.",
                    Description = "This isn't the time to slow down, this is the time to forge ahead and take the opportunities that come your way. You don’t need a smartphone. You need a power phone. One as beautiful as it is intelligent with a pen that is mighty, a battery that doesn't leave you hanging and is as well-connected as you are. The Galaxy Note20 5G and Galaxy Note20 Ultra 5G take power to the next level with cutting-edge technology, letting you master whatever you choose to do next. The Galaxy Note20 5G and Galaxy Note20 Ultra 5G have a big battery. Big enough to last all day. But that's not all, it's also intelligent. The Galaxy Note20 5G and Galaxy Note20 Ultra 5G intuitively manage your app usage to conserve energy on its own so you don't need to. Rest assured that you can tackle those emails during the day and be left with enough power to tackle your opponents at night. And if you are running low on battery, get hours of power from minutes of charge with Super Fast Charging.",
                    ScreenSize = 7M,
                    TalkTime = 18M,
                    StandByTime = 32M,
                    BrandId = new Guid("7360baa4-71c3-442d-9328-7f9cfbdf5e1f"),
                    OSId = new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79")
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Samsung Galaxy S21 Ultra",
                    Slug = "samsung-galaxy-s21-ultra",
                    Thumbnail = "https://localhost:5001/thumbnails/galaxy-s21-ultra.png",
                    ShortDescription = "Spontaneity, now captured from multiple angles. A camera so good, everyone's a pro. All-day battery, and then some. Trust us, you'll look amazing in 8K video.",
                    Description = "Create share-ready GIFs and videos in one take1 or pick your favourite moments and pull your favorite stills in super high res to share with your followers. Zoom in close, take photos and videos like a pro, and capture incredible share-ready moments with our easy-to-use, multi-lens camera. Power every scroll, click, tap, and stream all day long and then some with an intelligent battery that works with you, not against you. A night out. Your best friend's birthday party. Family moments you'll want to remember forever. Capture your life's best moments in head-turning, super smooth 8K video.",
                    ScreenSize = 7M,
                    TalkTime = 18M,
                    StandByTime = 32M,
                    BrandId = new Guid("7360baa4-71c3-442d-9328-7f9cfbdf5e1f"),
                    OSId = new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79")
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Samsung Galaxy S21",
                    Slug = "samsung-galaxy-s21",
                    Thumbnail = "https://localhost:5001/thumbnails/galaxy-s21.png",
                    ShortDescription = "Spontaneity, now captured from multiple angles. A camera so good, everyone's a pro. All-day battery, and then some. Trust us, you'll look amazing in 8K video.",
                    Description = "Create share-ready GIFs and videos in one take1 or pick your favourite moments and pull your favorite stills in super high res to share with your followers. Zoom in close, take photos and videos like a pro, and capture incredible share-ready moments with our easy-to-use, multi-lens camera. Power every scroll, click, tap, and stream all day long and then some with an intelligent battery that works with you, not against you. A night out. Your best friend's birthday party. Family moments you'll want to remember forever. Capture your life's best moments in head-turning, super smooth 8K video.",
                    ScreenSize = 6M,
                    TalkTime = 18M,
                    StandByTime = 32M,
                    BrandId = new Guid("7360baa4-71c3-442d-9328-7f9cfbdf5e1f"),
                    OSId = new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79")
                }
            );
        }
    }
}