using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL;
using Hi_Tech_Library.BLL.EntityFramework;

namespace Hi_Tech_Library.DAL
{
    public class BookAuthorRepository
    {
     
            private readonly HiTechOrderManagementDBEntities dbContext;

            public BookAuthorRepository()
            {
                dbContext = new HiTechOrderManagementDBEntities();
            }

            // Get all BookAuthors
            public IEnumerable<BookAuthor> GetAllBookAuthors() => dbContext.BookAuthors.ToList();

            // Add BookAuthor
            public void AddBookAuthor(BookAuthor bookAuthor)
            {
                dbContext.BookAuthors.Add(bookAuthor);
                dbContext.SaveChanges();
            }

            // Search BookAuthor by BookAuthorId
            public BookAuthor SearchBookAuthorById(int bookAuthorId) => dbContext.BookAuthors.Find(bookAuthorId);

            // Search BookAuthors by ISBN
            public List<BookAuthor> SearchBookAuthorsByISBN(string isbn) => dbContext.BookAuthors.Where(ba => ba.ISBN == isbn).ToList();

            // Search BookAuthors by AuthorId
            public List<BookAuthor> SearchBookAuthorsByAuthorId(int authorId) => dbContext.BookAuthors.Where(ba => ba.AuthorId == authorId).ToList();

        // Update BookAuthor
        public void UpdateBookAuthor(BookAuthor bookAuthor)
        {
            var existingBookAuthor = dbContext.BookAuthors.Find(bookAuthor.BookAuthorId);
            if (existingBookAuthor != null)
            {
                dbContext.Entry(existingBookAuthor).CurrentValues.SetValues(bookAuthor);
                dbContext.SaveChanges();
            }
        }


        // Delete BookAuthor
        public void DeleteBookAuthor(int bookAuthorId)
            {
                var bookAuthor = dbContext.BookAuthors.Find(bookAuthorId);
                if (bookAuthor != null)
                {
                    dbContext.BookAuthors.Remove(bookAuthor);
                    dbContext.SaveChanges();
                }
            }
        // Get all ISBN numbers
        public IEnumerable<Book> GetAllBookISBN() => dbContext.Books.ToList();

        // Get all Author ID's
        public IEnumerable<Author> GetAllBookAuthorId() => dbContext.Authors.ToList();
    }

    }

