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
                new BookModel(){Id=1, Title="MVC", Author="Haider",Description="This is the description for MVC book", Category="Programming", Language="English", Totalpages=1076},
                new BookModel(){Id=2, Title="C#", Author="Ali", Description="This is the description for C# book", Category="Programming", Language="English", Totalpages=1073},
                new BookModel(){Id=3, Title="Java", Author="Abbas", Description="This is the description for Java book", Category="Programming", Language="English", Totalpages=1276},
                new BookModel(){Id=4, Title="Python", Author="Hussain", Description="This is the description for python book", Category="Programming", Language="English", Totalpages=176},
                new BookModel(){Id=5, Title="AI", Author="Fiza", Description="This is the description for AI book", Category="Programming", Language="English", Totalpages=106}
            };
        }
    }
}
