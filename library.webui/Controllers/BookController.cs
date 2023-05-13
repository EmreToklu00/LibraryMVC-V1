using library.webui.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using library.webui.Models;
using shopapp.webui.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace library.webui.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index(int? id, string q)
        {
            var books = BookRepository.Books;
            if (id != null)
            {
                books = books.Where(b => b.CategoryId == id).ToList();
            }
            if (!(string.IsNullOrEmpty(q)))
            {
                books = books.Where(b => b.Name.ToLower().Contains(q.ToString().ToLower()) || b.Description.ToLower().Contains(q.ToString().ToLower())).ToList();
            }
            var bookViewModel = new BookViewModel()
            {
                books = books
            };

            return View(bookViewModel);
        }

        public IActionResult Details(int id)
        {
            return View(BookRepository.GetBookById(id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "Id", "Name");
            return View(new Book());
        }

        [HttpPost]
        public IActionResult Create(Book b)
        {

            if (ModelState.IsValid)
            {
                BookRepository.AddProduct(b);
                return RedirectToAction("index");
            }
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "Id", "Name");
            return View(b);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "Id", "Name");
            return View(BookRepository.GetBookById(id));
        }

        [HttpPost]
        public IActionResult Edit(Book b)
        {
            BookRepository.EditBook(b);
            return RedirectToAction("");
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            BookRepository.Delete(Id);
            return RedirectToAction("index");
        }


    }
}