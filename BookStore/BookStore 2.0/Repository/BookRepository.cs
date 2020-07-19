using BookStore_2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_2._0.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title == title && x.Author == authorName).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="MVC", Author="Haider"},
                new BookModel(){Id=2, Title="C#", Author="Haider"},
                new BookModel(){Id=3, Title="Java", Author="Haider"},
                new BookModel(){Id=4, Title="Python", Author="Haider"},
                new BookModel(){Id=5, Title="AI", Author="Haider"}
            };
        }
    }
}
