using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Data;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new Books()
            {
                Title = model.Title,
                Description = model.Description,
                Author = model.Author,
                LanguageId = model.LanguageId,
                TotalPages = model.TotalPages ?? 0,
                CreatedOn = DateTime.UtcNow,
                UpdatedOn = DateTime.UtcNow
            };

            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            return newBook.Id;
        }

        public async Task<List<BookModel>> GetAllBooks()
        {
            return await _context.Books
                  .Select(book => new BookModel()
                  {
                      Id = book.Id,
                      Title = book.Title,
                      Author = book.Author,
                      Description = book.Description,
                      LanguageId = book.LanguageId,
                      Language = book.Language.Name,
                      Category = book.Category,
                      TotalPages = book.TotalPages,
                  }).ToListAsync();
        }

        public async Task<BookModel> GetBookById(int id)
        {
            return await _context.Books.Where(x => x.Id == id)
                .Select(book => new BookModel()
                {
                    Id = book.Id,
                    Title = book.Title,
                    Author = book.Author,
                    Description = book.Description,
                    LanguageId = book.LanguageId,
                    Language = book.Language.Name,
                    Category = book.Category,
                    TotalPages = book.TotalPages
                }).FirstOrDefaultAsync();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return null;
        }
    }
}
