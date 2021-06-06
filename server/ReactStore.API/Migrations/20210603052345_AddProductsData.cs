using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReactStore.API.Migrations
{
    public partial class AddProductsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "reactstore",
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "Name", "OSId", "ScreenSize", "ShortDescription", "Slug", "StandByTime", "TalkTime", "Thumbnail" },
                values: new object[,]
                {
                    { new Guid("a3478123-d608-4032-b447-b634a2dec89c"), new Guid("6213ab61-e37d-40fe-9fd9-61ea21fba50b"), "The best iPhone display ever for incredible contrast and higher resolution. With Ceramic Shield, which has four times better drop performance. Superfast speeds. Superlow latency. So you can get faster downloads, better-quality video streaming, more responsive gaming and real-time interactivity. A14 Bionic is the fastest chip in a smartphone. With a 16-core Neural Engine, it crunches trillions of operations each second. And it’s superefficient for great battery life. ", "iPhone 12 mini", new Guid("bc052339-a7a9-429f-a673-b03589b84fad"), 5.4m, "iPhone 12 Mini, 5G speed. A14 Bionic, the fastest chip in a smartphone. An edge-to-edge OLED display", "iphone-12-mini", 32m, 18m, "https://localhost:5001/thumbnails/iphone-12-mini.png" },
                    { new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"), new Guid("6213ab61-e37d-40fe-9fd9-61ea21fba50b"), "The best iPhone display ever for incredible contrast and higher resolution. With Ceramic Shield, which has four times better drop performance. Superfast speeds. Superlow latency. So you can get faster downloads, better-quality video streaming, more responsive gaming and real-time interactivity.A14 Bionic is the fastest chip in a smartphone. With a 16-core Neural Engine, it crunches trillions of operations each second. And it’s superefficient for great battery life.", "iPhone 12", new Guid("bc052339-a7a9-429f-a673-b03589b84fad"), 6.1m, "iPhone 12, 5G speed. A14 Bionic, the fastest chip in a smartphone. An edge-to-edge OLED display.. And Night mode on every camera.", "iphone-12", 32m, 18m, "https://localhost:5001/thumbnails/iphone-12.png" },
                    { new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"), new Guid("6213ab61-e37d-40fe-9fd9-61ea21fba50b"), "The Super Retina XDR display goes edge to edge. With Ceramic Shield, which has four times better drop performance. Superfast speeds. Superlow latency. So you can get faster downloads, better-quality video streaming, more responsive gaming and real-time interactivity. Introducing the first 5-nanometre chip in the industry. Which means more speed, more power and more efficiency. LiDAR creates accurate depth maps in nanoseconds, so objects are placed instantly and more accurately in AR experiences.", "iPhone 12 Pro Max", new Guid("bc052339-a7a9-429f-a673-b03589b84fad"), 6.7m, "iPhone 12 Pro Max, 5G speed. A14 Bionic, the fastest chip in a smartphone. And a Pro camera system that takes low-light photography to the next level — with an even bigger jump on iPhone 12 Pro Max.", "iphone-12-pro-max", 32m, 18m, "https://localhost:5001/thumbnails/iphone-12-pro-max.png" },
                    { new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"), new Guid("8ab3a1c4-0b52-4671-ab2a-753e28c1a0be"), "With 5G,you can download your favourite movies on the go and start watching before you know it. Go from game time to show time, all in crystal clear HD. Pixel’s 5G hotspot is powerful enough to keep multiple devices connected at once. HDR+ automatically enhances colour and lighting, so the photos that you take stay as vivid as you remember. With HD Duo screen sharing, you can read articles, watch live sports, and laugh together as if you were sitting in the same room. Adaptive Battery reduces power to the apps that you rarely use, so your mobile phone keeps its charge all day.", "Google Pixel 5", new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79"), 5.9m, "Pixel 5, The best of Google in 5G. Have a photo shoot day or night, capture moments with stunning clarity, and take clips with Hollywood-inspired effects.", "google-pixel-5", 32m, 18m, "https://localhost:5001/thumbnails/google-pixel-5.png" },
                    { new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"), new Guid("7360baa4-71c3-442d-9328-7f9cfbdf5e1f"), "This isn't the time to slow down, this is the time to forge ahead and take the opportunities that come your way. You don’t need a smartphone. You need a power phone. One as beautiful as it is intelligent with a pen that is mighty, a battery that doesn't leave you hanging and is as well-connected as you are. The Galaxy Note20 5G and Galaxy Note20 Ultra 5G take power to the next level with cutting-edge technology, letting you master whatever you choose to do next. The Galaxy Note20 5G and Galaxy Note20 Ultra 5G have a big battery. Big enough to last all day. But that's not all, it's also intelligent. The Galaxy Note20 5G and Galaxy Note20 Ultra 5G intuitively manage your app usage to conserve energy on its own so you don't need to. Rest assured that you can tackle those emails during the day and be left with enough power to tackle your opponents at night. And if you are running low on battery, get hours of power from minutes of charge with Super Fast Charging.", "Samsung Galaxy Note20", new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79"), 7m, "This isn't the time to slow down, this is the time to forge ahead and take the opportunities that come your way.", "samsung-galaxy-note-20", 32m, 18m, "https://localhost:5001/thumbnails/galaxy-note20.png" },
                    { new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"), new Guid("7360baa4-71c3-442d-9328-7f9cfbdf5e1f"), "Create share-ready GIFs and videos in one take1 or pick your favourite moments and pull your favorite stills in super high res to share with your followers. Zoom in close, take photos and videos like a pro, and capture incredible share-ready moments with our easy-to-use, multi-lens camera. Power every scroll, click, tap, and stream all day long and then some with an intelligent battery that works with you, not against you. A night out. Your best friend's birthday party. Family moments you'll want to remember forever. Capture your life's best moments in head-turning, super smooth 8K video.", "Samsung Galaxy S21 Ultra", new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79"), 7m, "Spontaneity, now captured from multiple angles. A camera so good, everyone's a pro. All-day battery, and then some. Trust us, you'll look amazing in 8K video.", "samsung-galaxy-s21-ultra", 32m, 18m, "https://localhost:5001/thumbnails/galaxy-s21-ultra.png" },
                    { new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"), new Guid("7360baa4-71c3-442d-9328-7f9cfbdf5e1f"), "Create share-ready GIFs and videos in one take1 or pick your favourite moments and pull your favorite stills in super high res to share with your followers. Zoom in close, take photos and videos like a pro, and capture incredible share-ready moments with our easy-to-use, multi-lens camera. Power every scroll, click, tap, and stream all day long and then some with an intelligent battery that works with you, not against you. A night out. Your best friend's birthday party. Family moments you'll want to remember forever. Capture your life's best moments in head-turning, super smooth 8K video.", "Samsung Galaxy S21", new Guid("c81d73b4-2d7e-4ae8-8802-057dda516f79"), 6m, "Spontaneity, now captured from multiple angles. A camera so good, everyone's a pro. All-day battery, and then some. Trust us, you'll look amazing in 8K video.", "samsung-galaxy-s21", 32m, 18m, "https://localhost:5001/thumbnails/galaxy-s21.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("533ed09f-6a3a-4ad7-922f-76ebc4a9bc30"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b5087a0-5cac-4fde-b39d-d6fbdb7f5d57"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e60cf5a-0aab-49d5-9ef2-3f2c9b0f097d"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8b94cae3-0ef3-4e2e-bbcd-92ec689d3b73"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a3478123-d608-4032-b447-b634a2dec89c"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d96901d6-44aa-4d67-b616-a347966df5a2"));

            migrationBuilder.DeleteData(
                schema: "reactstore",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc386a0a-48a8-49e9-aff7-e0bf6902d3b3"));

        }
    }
}
