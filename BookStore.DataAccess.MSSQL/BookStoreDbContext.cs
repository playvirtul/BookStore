using BookStore.DataAccess.MSSQL.Configurations;
using BookStore.DataAccess.MSSQL.Entites;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess.MSSQL
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}