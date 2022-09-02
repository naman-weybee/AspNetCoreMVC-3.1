using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Repository
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
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "JavaScript", Author = "Shivraj", Discription = "This is the Discription of JavaScript book", Category = "Concept", Language = "English", TotalPages = 137},
                new BookModel(){Id = 2, Title = "React JS", Author = "Darshan", Discription = "This is the Discription of React JS book", Category = "Concept", Language = "English", TotalPages = 121},
                new BookModel(){Id = 3, Title = "Angular", Author = "Himanshu", Discription = "This is the Discription of Anguler book", Category = "Developer", Language = "Chinese", TotalPages = 352},
                new BookModel(){Id = 4, Title = "C#", Author = "Naman", Discription = "This is the Discription of C# book", Category = "Developer", Language = "English", TotalPages = 756},
                new BookModel(){Id = 5, Title = "ASP.Net Web Forms", Author = "Yash", Discription = "This is the Discription of ASP.Net Web Forms book", Category = "Framework", Language = "German", TotalPages = 897},
                new BookModel(){Id = 6, Title = "ASP.NET Core MVC", Author = "Rishit", Discription = "This is the Discription of ASP.NET Core MVC book", Category = "Framework", Language = "English", TotalPages = 991},
            };
        }
    }
}
