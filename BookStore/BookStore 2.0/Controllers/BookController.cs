using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_2._0.Models;
using BookStore_2._0.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookStore_2._0.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }
        public ViewResult GetBook(int id)
        {
            var data = _bookRepository.GetBookById(id);
            return View(data);
        }
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
        public ViewResult AddNewBook(bool isSuccess = false)
        {
            ViewBag.IsSuccess = isSuccess;
            return View();
        }
        [HttpPost]
        public ViewResult AddNewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
               
            }

            ModelState.AddModelError("", "This is my custom error message");//this is benefit of using validation summary
            return View();
        }
        /*
        public String GetAllBooks()
        {
            return "All books";
        }
        public String GetBook(int id)
        {
            return $"book with id = {id}";
        }
        */

    }
}
