using LibraryEFCore.Db;

using var context = new BooksDbContext();
var authors = context.Books.Select(x => x.Author).ToList();
authors.ForEach(a => Console.WriteLine(a.FirstName + " " + a.LastName));
Console.ReadKey();