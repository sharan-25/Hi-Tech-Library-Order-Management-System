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
    public class BookRepository
    {
        
        private readonly HiTechOrderManagementDBEntities dBContext;
        
        public BookRepository()
        {
            dBContext = new HiTechOrderManagementDBEntities();
        }

        //Book Moethods

        // Get all books
        public IEnumerable<Book> GetAllBooks() => dBContext.Books.ToList();

        // Add a book
        public void AddBook(Book book)
        {
            dBContext.Books.Add(book);
            dBContext.SaveChanges();
        }



        // Update a book
        public void UpdateBook(Book book)
        {
            var existingBook = dBContext.Books.Find(book.ISBN); 
            if (existingBook != null)
            {
                dBContext.Entry(existingBook).CurrentValues.SetValues(book);
                dBContext.SaveChanges();
            }
        }


        // Delete a book
        public void DeleteBook(string isbn)
        {
            var book = dBContext.Books.Find(isbn);
            if (book != null)
            {
                dBContext.Books.Remove(book);
                dBContext.SaveChanges();
            }
        }
        // Search book by ISBN
        public Book SearchBookById(string isbn) => dBContext.Books.Find(isbn);

        // Search book by title
        public List<Book> SearchBookByTitle(string title) => dBContext.Books.Where(b => b.BookTitle == title).ToList();

        // Search books by category ID
        public IEnumerable<Book> SearchBooksByCategory(int categoryId) => dBContext.Books.Where(b => b.CategoryId == categoryId).ToList();

        // Search books by publisher ID
        public IEnumerable<Book> SearchBooksByPublisher(int publisherId) => dBContext.Books.Where(b => b.PublisherId == publisherId).ToList();

        // Search books by year published
        public IEnumerable<Book> SearchBooksByYearPublished(int year) => dBContext.Books.Where(b => b.YearPublished == year).ToList();

        // Search books by quantity on hand (QOH)
        public IEnumerable<Book> SearchBooksByQOH(int qoh) => dBContext.Books.Where(b => b.QOH == qoh).ToList();

        // Search books by unit price
        public IEnumerable<Book> SearchBooksByUnitPrice(double unitPrice) => dBContext.Books.Where(b => b.UnitPrice == unitPrice).ToList();

        // Get all categories
        public IEnumerable<Category> GetAllCategories() => dBContext.Categories.ToList();

        // Get all publishers
        public IEnumerable<Publisher> GetPublishers() => dBContext.Publishers.ToList();
        //Check Is ISBN unique
        public bool IsISBNUnique(string isbn)
        {
            // Check if any book in the database has the provided ISBN
            return dBContext.Books.Find(isbn) == null;
        }
    }
}
