using MarketPlace.Data.Domains;
using MarketPlace.Data.PrepData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connect = config.GetSection("ConnectionStrings").Get<List<string>>()?.FirstOrDefault();
            optionsBuilder.UseSqlServer(connect, options => options.MigrationsAssembly("MarketPlace.Data").MinBatchSize(1));
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; }
        public DbSet<Kyc> Kycs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductCondition> ProductConditions { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<State> States { get; set; }

        public DbSet<MyTable> MyTables { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //ModelBuilderExtension.Seed(builder);
        }

    }
}
