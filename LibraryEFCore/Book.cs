namespace LibraryEFCore.Db;

public record Book
{
    public string Name { get; init; } = string.Empty;

    public string Author { get; init; } = string.Empty;
}