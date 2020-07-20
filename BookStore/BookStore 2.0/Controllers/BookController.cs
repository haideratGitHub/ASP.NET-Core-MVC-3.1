using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_2._0.Models;
using BookStore_2._0.Repository;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
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
