using library_otomation.Models;
using Microsoft.AspNetCore.Mvc;

namespace library_otomation.Controllers
{
    public class LibraryController : Controller
    {
        private readonly Library Lib; // lib nesnesi Dependency Injection ile oluşturulur

        // dependency injection: bir sınıfın başka bir sınıfı kullanabilmesi
        // için gerekli olan nesnenin dışarıdan verilmesi işlemidir

        public LibraryController(Library lib)
        {
            Lib = lib;
        }

        public ActionResult Index()
        {
            var books = Lib.ListAllBooks();
            return View();
        }

        public ActionResult ListBooks()
        {
            return View("listBooks");
        }

        public ActionResult Search()
        {
            return View("search");
        }

        public ActionResult RemoveBooks()
        {
            return View("removeBooks");
        }

        public ActionResult AddBooks()
        {
            return View("addBooks");
        }

        public ActionResult About()
        {
            return View("about");
        }

        [HttpPost]
        public IActionResult Add(int year, string name, string author)
        { 
            var book = new Book(year, name, author);
            Lib.addBook(book);
            TempData["Message"] = "Book added successfully";
            return View("Index");
        }
        [HttpPost]
        public IActionResult Remove(string name)
        {
            Lib.removeBook(name);
            return RedirectToAction("Index");
        }

        [HttpGet("SearchByName")]
        public IActionResult SearchByName(string name)
        {
            var books = Lib.SearchByName(name);
            return View(books);
        }

        [HttpGet("SearchByAuthor")]
        public IActionResult SearchByAuthor(string author)
        { 
            var books = Lib.SearchByAuthor(author);
            return View(books);
        }

        [HttpGet]
        public IActionResult SearchByYear(int year)
        {
            var books = Lib.searchByYear(year);
            return View(books);
        }

        [HttpGet]
        public IActionResult ListAllBooks()
        {
            var books = Lib.ListAllBooks();
            return View(books);
        }
    }
}
