using Microsoft.EntityFrameworkCore;
using BookManager.Models;
using System.Reflection.Metadata;

namespace BookManager.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(e => e.Books)
                .WithOne(e => e.Author)
                .HasForeignKey("AuthorId")
                .IsRequired(false);
        }
    }
}
