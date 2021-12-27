using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PruebaEFCore.DataAccess.Model;

namespace PruebaEFCore.DataAccess
{
    public class DatabaseDbContext: DbContext
    {
        public DatabaseDbContext(DbContextOptions<DatabaseDbContext> options) : base(options)
        {
            
        }

        public DbSet<Blog> Blogs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().ToTable("Blogs");
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.HasKey(e => e.BlogId);
                entity.Property(e => e.DateTimeAdd).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}