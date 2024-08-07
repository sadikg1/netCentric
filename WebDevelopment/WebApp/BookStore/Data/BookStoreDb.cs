using BookStore.Data.Models;
using Microsoft.EntityFrameworkCore;
public class BookStoreDb : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=BookStore.db");
    }
}