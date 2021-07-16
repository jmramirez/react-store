using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReactStore.Domain.Entities;
using ReactStore.Domain.Repositories;
using ReactStore.Infrastructure.SchemaDefinitions;


namespace ReactStore.Infrastructure
{
    public class ReactStoreContext : IdentityDbContext<AppUser, AppRole, int>, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "reactstore";
        
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<OS> OS { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<Storage> Storage { get; set; }
        
        public ReactStoreContext(DbContextOptions<ReactStoreContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandSchemaDefinition());
            modelBuilder.ApplyConfiguration(new ColorSchemaDefinition());
            modelBuilder.ApplyConfiguration(new OsSchemaDefinition());
            modelBuilder.ApplyConfiguration(new ImageSchemaDefinition());
            modelBuilder.ApplyConfiguration(new FeatureSchemaDefinition());
            modelBuilder.ApplyConfiguration(new ProductSchemaDefinition());
            modelBuilder.ApplyConfiguration(new ProductFeatureSchemaDefinition());
            modelBuilder.ApplyConfiguration(new ProductVariantSchemaDefinition());
            modelBuilder.ApplyConfiguration(new StorageSchemaDefinition());
            modelBuilder.ApplyConfiguration(new RolesSchemaDefinition());
            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}