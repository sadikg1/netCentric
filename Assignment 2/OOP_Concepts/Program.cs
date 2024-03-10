Book book = new Book
{
    Name = "China Harayeko MAnche",
    Author = "Hari Bansha Acharya",
    Pages = 280,
    Description = "The struggles and challenges of a man named Drishya during Nepal's Maoist insurgency."
};

LibrarianStaff librarian = new LibrarianStaff
{
    Name = "Sadik Ghimire",
    Description = "Senior Librarian"
};
book.DisplayInfo();
Console.WriteLine();
librarian.DisplayInfo();
Console.WriteLine();

librarian.IssueBook(book);
librarian.ReturnBook(book);