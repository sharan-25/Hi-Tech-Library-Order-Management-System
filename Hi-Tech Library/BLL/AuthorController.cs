using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL.EntityFramework;
using Hi_Tech_Library.DAL;

namespace Hi_Tech_Library.BLL
{
    public class AuthorController
    {
        private readonly AuthorRepository authorRepository;

        public AuthorController()
        {
            authorRepository = new AuthorRepository();
        }

        // Method to retrieve all authors
        public IEnumerable<Author> getAuthors() => authorRepository.GetAllAuthors();

        // Method to add a new author
        public void addAuthor(Author author) => authorRepository.AddAuthor(author);

        // Method to update an existing author
        public void updateAuthor(Author author) => authorRepository.UpdateAuthor(author);

        // Method to delete an author by their ID
        public void deleteAuthor(int authorId) => authorRepository.DeleteAuthor(authorId);

        // Method to search for an author by their ID
        public Author searchAuthorById(int authorId) => authorRepository.SearchAuthorById(authorId);

        // Method to search for authors by first name
        public List<Author> searchAuthorsByFirstName(string firstName) => authorRepository.SearchAuthorsByFirstName(firstName);

        // Method to search for authors by last name
        public List<Author> searchAuthorsByLastName(string lastName) => authorRepository.SearchAuthorsByLastName(lastName);

        // Method to search for authors by email
        public List<Author> searchAuthorsByEmail(string email) => authorRepository.SearchAuthorsByEmail(email);

    }
}
