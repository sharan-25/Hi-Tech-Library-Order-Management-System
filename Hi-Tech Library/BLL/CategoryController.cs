using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Library.BLL.EntityFramework;
using Hi_Tech_Library.DAL;

namespace Hi_Tech_Library.BLL
{
    public class CategoryController
    {
        private readonly CategoryRepository categoryRepository;

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
        }

        // Method to retrieve all categories
        public IEnumerable<Category> GetCategories() => categoryRepository.GetAllCategories();

        // Method to add a new category
        public void addCategory(Category category) => categoryRepository.AddCategory(category);

        // Method to update an existing category
        public void updateCategory(Category category) => categoryRepository.UpdateCategory(category);

        // Method to delete a category by its ID
        public void deleteCategory(int categoryId) => categoryRepository.DeleteCategory(categoryId);

        // Method to search for a category by its ID
        public Category searchCategorybyId(int categoryId) => categoryRepository.SearchCategoryById(categoryId);

        // Method to search for a category by name
        public List<Category> searchCategoryByName(string categoryName) => categoryRepository.SearchCategoryByName(categoryName);
    }
}
