using BookStore.Data.Models;

public class Book
{
  //Id, Title, Genre, PublishedDate, ISBN, Price, PublisherId, AuthorId
  public int Id { get; set; }

  public string Title { get; set; }=string.Empty;

  public Genre Genre { get; set; }
  public DateTime PublishedDate { get; set; }
  public string? ISBN { get; set; }
  public int AuthorId{get; set;}

  public Author? Author{get; set;}

}