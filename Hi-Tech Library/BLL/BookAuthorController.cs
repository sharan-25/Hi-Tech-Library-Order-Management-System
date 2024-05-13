using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL.EntityFramework;
using Hi_Tech_Library.DAL;

namespace Hi_Tech_Library.BLL
{
    public class BookAuthorController
    {
        private readonly BookAuthorRepository bookAuthorRepository;

        public BookAuthorController()
        {
            bookAuthorRepository = new BookAuthorRepository();
        }

        // Method to retrieve all book authors
        public IEnumerable<BookAuthor> GetBookAuthors() => bookAuthorRepository.GetAllBookAuthors();

        // Method to add a new book author
        public void addBookAuthor(BookAuthor bookAuthor) => bookAuthorRepository.AddBookAuthor(bookAuthor);

        // Method to update an existing book author
        public void updateBookAuthor(BookAuthor bookAuthor) => bookAuthorRepository.UpdateBookAuthor(bookAuthor);

        // Method to delete a book author by its ID
        public void deleteBookAuthor(int bookAuthorId) => bookAuthorRepository.DeleteBookAuthor(bookAuthorId);

        // Method to search for a book author by its ID
        public BookAuthor searchBookAuthorById(int bookAuthorId) => bookAuthorRepository.SearchBookAuthorById(bookAuthorId);

        // Method to search for book authors by ISBN
        public List<BookAuthor> searchBookAuthorsByISBN(string isbn) => bookAuthorRepository.SearchBookAuthorsByISBN(isbn);

        // Method to search for book authors by AuthorId
        public List<BookAuthor> searchBookAuthorsByAuthorId(int authorId) => bookAuthorRepository.SearchBookAuthorsByAuthorId(authorId);
        // Method to retrieve all Book ISBN
        public IEnumerable<Book> GetAllbookISBN() => bookAuthorRepository.GetAllBookISBN();

        // Method to retrieve all Author ID's
        public IEnumerable<Author> GetAllAuthorId() => bookAuthorRepository.GetAllBookAuthorId();

    }
}
