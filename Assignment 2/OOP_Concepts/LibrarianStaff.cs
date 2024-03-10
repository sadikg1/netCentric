public class LibrarianStaff : LibraryEntity, Librarian
{
    public void IssueBook(Book book)
    {
        Console.WriteLine($"Issuing book {book.Name}");
    }

    public void ReturnBook(Book book)
    {
        Console.WriteLine($"Returning book {book.Name}");
    }

    public override string EntityType => "Librarian Staff";

    public override void DisplayInfo()
    {
        Console.WriteLine($"{EntityType}: {Name}");
        Console.WriteLine($"Description: {Description}");
    }
}