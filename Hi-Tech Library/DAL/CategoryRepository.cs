using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL;
using Hi_Tech_Library.BLL.EntityFramework;

namespace Hi_Tech_Library.DAL
{
    public class CategoryRepository
    {
        private readonly HiTechOrderManagementDBEntities dBContext;

        public CategoryRepository()
        {
            dBContext = new HiTechOrderManagementDBEntities();
        }
        //Category Methods
        //get the list of all Categories
        public IEnumerable<Category> GetAllCategories() => dBContext.Categories.ToList();

        //add publisher
        public void AddCategory(Category category)
        {
            dBContext.Categories.Add(category);
            dBContext.SaveChanges();
        }

        //Search Category by id
        public Category SearchCategoryById(int cId) => dBContext.Categories.Find(cId);

        //Search Category by name

        public List<Category> SearchCategoryByName(string categoryName) => dBContext.Categories.Where(p => p.CategoryName == categoryName).ToList();


        // Update Category
        public void UpdateCategory(Category category)
        {
            var existingCategory = dBContext.Categories.Find(category.CategoryId);
            if (existingCategory != null)
            {
                dBContext.Entry(existingCategory).CurrentValues.SetValues(category);
                dBContext.SaveChanges();
            }
            
        }

        // Delete Category
        public void DeleteCategory(int cId)
        {
            var category = dBContext.Categories.Find(cId);
            if (category != null)
            {
                dBContext.Categories.Remove(category);
                dBContext.SaveChanges();
            }
        }
    }
}
