using System.ComponentModel.DataAnnotations;

namespace LibraryEFCore.Db.Entity;

public record Book
{
    public int Id { get; set; }
    
    [StringLength(255)] public string Title { get; init; } = string.Empty;

    public int AuthorId { get; set; }

    public Author Author { get; init; } = new();
}