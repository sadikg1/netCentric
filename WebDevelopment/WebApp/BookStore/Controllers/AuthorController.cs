using BookStore.Data.Models;
using Microsoft.AspNetCore.Mvc;
public class AuthorController: Controller

{
    BookStoreDb db = new BookStoreDb();

    public IActionResult Index()
    {
        List<Author> authors = db.Authors.ToList();

        return View(authors);
    }

    // [HttpGet] - default
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Author author)
    {
        //setting cookie
        
        db.Authors.Add(author);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var author = db.Authors.Find(id);
        return View(author);
    }

    [HttpPost]
    public IActionResult Edit(Author author)
    {
        db.Authors.Update(author);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var author = db.Authors.Find(id);
        return View(author);
    }

    [HttpPost]
    public IActionResult Delete(Author author)
    {
        db.Authors.Remove(author);
        db.SaveChanges();

        return RedirectToAction("Index");
    }
}
