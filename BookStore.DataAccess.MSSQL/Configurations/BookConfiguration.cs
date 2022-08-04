using BookStore.DataAccess.MSSQL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DataAccess.MSSQL.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Author).IsRequired().HasMaxLength(100);

            builder.Property(b => b.Title).IsRequired().HasMaxLength(100);

            builder.Property(b => b.PublishYear)
                .HasConversion(b => b.ToUniversalTime(), b => b)
                .IsRequired();
        }
    }
}
