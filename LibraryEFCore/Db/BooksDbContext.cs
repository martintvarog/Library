using Microsoft.EntityFrameworkCore;

namespace LibraryEFCore.Db;

public class BooksDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().Property(b => b.Name).IsRequired();
        modelBuilder.Entity<Book>().Property(b => b.Author).IsRequired();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.Use("Server=(localdb)\\mssqllocaldb;Database=LibraryEFCore;Trusted_Connection=True;");
    }
}