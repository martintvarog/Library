using System.ComponentModel.DataAnnotations;

namespace LibraryEFCore.Db.Entity;

public record Author
{
    public int Id { get; init; }
    
    [StringLength(50)] public string FirstName { get; init; } = string.Empty;
    
    [StringLength(75)] public string LastName { get; init; } = string.Empty;
    
    [StringLength(75)] public List<Book> Books { get; init; } = new();
}