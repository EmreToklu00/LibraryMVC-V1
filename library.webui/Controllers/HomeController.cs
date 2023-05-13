using library.webui.Data;
using Microsoft.AspNetCore.Mvc;

namespace library.webui.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var books = new BookViewModel()
            {
                books = BookRepository.Books
            };
            return View(books);
        }

        public IActionResult Details(int Id)
        {
            return View(BookRepository.GetBookById(Id));
        }
    }
}