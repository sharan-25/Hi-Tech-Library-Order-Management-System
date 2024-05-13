using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL;
using Hi_Tech_Library.BLL.EntityFramework;

namespace Hi_Tech_Library.DAL
{
    public class AuthorRepository
    {
        private readonly HiTechOrderManagementDBEntities dbContext;

        public AuthorRepository()
        {
            dbContext = new HiTechOrderManagementDBEntities();
        }

        // Get all authors
        public IEnumerable<Author> GetAllAuthors() => dbContext.Authors.ToList();

        // Add author
        public void AddAuthor(Author author)
        {
            dbContext.Authors.Add(author);
            dbContext.SaveChanges();
        }

        // Search author by ID
        public Author SearchAuthorById(int authorId) => dbContext.Authors.Find(authorId);

        // Search author by first name
        public List<Author> SearchAuthorsByFirstName(string firstName) => dbContext.Authors.Where(a => a.FirstName == firstName).ToList();

        // Search author by last name
        public List<Author> SearchAuthorsByLastName(string lastName) => dbContext.Authors.Where(a => a.LastName == lastName).ToList();

        // Search author by email
        public List<Author> SearchAuthorsByEmail(string email) => dbContext.Authors.Where(a => a.Email == email).ToList();

        // Update author
        public void UpdateAuthor(Author author)
        {
            var existingAuthor = dbContext.Authors.Find(author.AuthorId); 
            if (existingAuthor != null)
            {
                dbContext.Entry(existingAuthor).CurrentValues.SetValues(author);
                dbContext.SaveChanges();
            }
        }


        // Delete author
        public void DeleteAuthor(int authorId)
        {
            var author = dbContext.Authors.Find(authorId);
            if (author != null)
            {
                dbContext.Authors.Remove(author);
                dbContext.SaveChanges();
            }
        }
    }
}
