using DAL.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class ToysGamesContext : DbContext
    {
        public ToysGamesContext(DbContextOptions<ToysGamesContext> options)
           : base(options)
        {


        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Company>().Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Entity<Company>().HasKey(f => f.Id);
            builder.Entity<Product>().HasKey(f => f.Id);

            builder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Mattel", Guid = Guid.NewGuid(), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Active = true, },
                new Company { Id = 2, Name = "Nintendo", Guid = Guid.NewGuid(), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, Active = true, }
                );

            builder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Name = "Nintendo Switch Lite",
                     AgeRestriction = 5,
                     CompanyId = 2,
                     Guid = Guid.NewGuid(),
                     Active = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     Pic = "https://m.media-amazon.com/images/I/71qmF0FHj7L._AC_SL1500_.jpg",
                     PicThumbnail = "https://res.cloudinary.com/walmart-labs/image/upload/w_225,dpr_auto,f_auto,q_auto:good/mg/gm/1p/images/product-images/img_large/00004549688228l.jpg",
                     Price = (decimal)8600,
                     Description = "Introducing Nintendo Switch Lite, a version of the Nintendo Switch system that’s optimized.",
                 }
                );

            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseModel && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow;

                if (entity.State == EntityState.Added)
                {
                    ((BaseModel)entity.Entity).Active = true;
                    ((BaseModel)entity.Entity).CreatedAt = now;
                }
                ((BaseModel)entity.Entity).UpdatedAt = now;
            }
        }
    }
}
