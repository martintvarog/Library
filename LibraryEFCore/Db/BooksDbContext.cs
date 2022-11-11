using LibraryEFCore.Db.Entity;
using Microsoft.EntityFrameworkCore;

namespace LibraryEFCore.Db;

public class BooksDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=TVAROG;Initial Catalog=Library;Integrated Security=True;Trusted_Connection=True;Encrypt=False");
    }
}