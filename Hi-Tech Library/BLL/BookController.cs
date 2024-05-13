using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL.EntityFramework;
using Hi_Tech_Library.DAL;

namespace Hi_Tech_Library.BLL
{
    public class BookController
    {
        private readonly BookRepository bookRepository;

        // Constructor to initialize PublisherRepository
        public BookController()
        {
            bookRepository = new BookRepository();
        }

        //Book Methods
        // Method to retrieve all books
        public IEnumerable<Book> GetBooks() => bookRepository.GetAllBooks();

        // Method to add a new book
        public void AddBook(Book book) => bookRepository.AddBook(book);

        // Method to update an existing book
        public void UpdateBook(Book book) => bookRepository.UpdateBook(book);

        // Method to delete a book by its ISBN
        public void DeleteBook(string isbn) => bookRepository.DeleteBook(isbn);

        // Method to search for a book by its ISBN
        public Book searchBookById(string isbn) => bookRepository.SearchBookById(isbn);

        // Method to search for a book by title
        public List<Book> searchBookByTitle(string title) => bookRepository.SearchBookByTitle(title);

        // Search by categoryId
        public IEnumerable<Book> searchBookByCategory(int categoryId) => bookRepository.SearchBooksByCategory(categoryId);

        //Search by publisherId
        public IEnumerable<Book> searchBookByPublisher(int publisherId) => bookRepository.SearchBooksByPublisher(publisherId);

        //Search by Year Published
        public IEnumerable<Book> searchBookByYearPublished(int year) => bookRepository.SearchBooksByYearPublished(year);

        // Method to search for books by Quantity on Hand (QOH)
        public IEnumerable<Book> searchBookByQOH(int qoh) => bookRepository.SearchBooksByQOH(qoh);

        //Search by unit price
        public IEnumerable<Book> searchBookByUnitprice(double unitprice) => bookRepository.SearchBooksByUnitPrice(unitprice);

        // Method to retrieve all categories
        public IEnumerable<Category> GetAllCategories() => bookRepository.GetAllCategories();

        // Method to retrieve all publishers
        public IEnumerable<Publisher> GetPublishers() => bookRepository.GetPublishers();
        //Method to check is ISBN unique
        public bool IsISBNUnique(string isbn)
        {
            // Call the repository method to check if ISBN is unique
            return bookRepository.IsISBNUnique(isbn);
        }

    }
}
