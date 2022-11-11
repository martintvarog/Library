using LibraryEFCore.Db;
using LibraryEFCore.Db.Entity;

using var context = new BooksDbContext();
var author = new Author
{
    FirstName = "John",
    LastName = "Doe",
    Books = new List<Book>
    {
        new()
        {
            Title = "Book 1",
        },
        new()
        {
            Title = "Book 2",
        }
    }
};
context.Add(author);
context.SaveChanges();