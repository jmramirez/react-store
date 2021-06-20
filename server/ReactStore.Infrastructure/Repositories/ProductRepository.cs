using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Repositories;

namespace ReactStore.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ReactStoreContext _context;

        public ProductRepository(ReactStoreContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Product>> GetAsync(string q, string brands, int? minPrice, int? maxPrice, int? minScreen, int? maxScreen, string capacity,
            string colors, string os, string features)
        {

            var Query = $"%{q?.ToLower()}%";
            var Brands = string.IsNullOrEmpty(brands) ? new List<string>() : brands.Split('|').ToList();
            var Capacity = string.IsNullOrEmpty(capacity) ? new List<string>() : capacity.Split('|').ToList();
            var Colors = string.IsNullOrEmpty(colors) ? new List<string>() : colors.Split('|').ToList();
            var OS = string.IsNullOrEmpty(os) ? new List<string>() : os.Split('|').ToList();
            
            
            var products = await _context.Products
                .AsNoTracking()
                .Where(x => 
                    string.IsNullOrEmpty(q) ||
                    (
                        EF.Functions.Like(x.Name.ToLower(), Query) ||
                        EF.Functions.Like(x.ShortDescription.ToLower(), Query) ||
                        EF.Functions.Like(x.Description.ToLower(), Query) ||
                        EF.Functions.Like(x.Brand.Name.ToLower(), Query) ||
                        EF.Functions.Like(x.OS.Name.ToLower(), Query) ||
                        x.ProductFeatures.Any(f =>
                            EF.Functions.Like(f.Feature.Name.ToLower(), Query))
                    )
                )
                .Where(x => Brands.Any() == false || Brands.Contains(x.Brand.Name))
                .Where(x => minPrice.HasValue == false || x.ProductVariants.Any(v => v.Price >= minPrice.Value))
                .Where(x => maxPrice.HasValue == false || x.ProductVariants.Any(v => v.Price <= maxPrice.Value))
                .Where(x => minScreen.HasValue == false || x.ScreenSize >= Convert.ToDecimal(minScreen.Value))
                .Where(x => maxScreen.HasValue == false || x.ScreenSize <= Convert.ToDecimal(maxScreen.Value))
                .Where(x => Capacity.Any() == false ||
                            x.ProductVariants.Any(v => Capacity.Contains(v.Storage.Capacity)))
                .Where(x => Colors.Any() == false || x.ProductVariants.Any(v => Colors.Contains(v.Color.Name)))
                .Where(x => OS.Any() == false || OS.Contains(x.OS.Name))
                //.AsSplitQuery()
                //.Include( x=> x.Brand)
                .Include(pf => pf.ProductFeatures)
                .ThenInclude(f => f.Feature)
                .Include(v => v.ProductVariants)
                .ToListAsync();

            return products;
        }

        public async Task<Product> GetProductBySlugAsync(string slug)
        {
            var product = await _context.Products
                .AsNoTracking()
                .Where(x => x.Slug == slug)
                .AsSplitQuery()
                .Include(f => f.ProductFeatures)
                .ThenInclude(ft => ft.Feature)
                .Include(p => p.ProductVariants)
                .ThenInclude(v => v.Color)
                .Include(p => p.ProductVariants)
                .ThenInclude(v => v.Storage)
                .Include( x => x.Images)
                .FirstOrDefaultAsync();

            if (product == null) return null;

            _context.Entry(product).State = EntityState.Detached;
            return product;
        }
    }
}