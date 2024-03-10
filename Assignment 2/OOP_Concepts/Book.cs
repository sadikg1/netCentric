public class Book : LibraryEntity
{
    public string Author { get; set; }
    public int Pages { get; set; }

    public override string EntityType => "Book";

    public override void DisplayInfo()
    {
        Console.WriteLine($"{EntityType}: {Name}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Pages: {Pages}");
        Console.WriteLine($"Description: {Description}");
    }
}