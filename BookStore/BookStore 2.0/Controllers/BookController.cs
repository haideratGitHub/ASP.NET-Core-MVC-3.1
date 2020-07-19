using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_2._0.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public String GetAllBooks()
        {
            return "All books";
        }
        public String GetBook(int id)
        {
            return $"book with id = {id}";
        }
    }
}
