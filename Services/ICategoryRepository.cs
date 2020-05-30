using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheOnlineBookStore.Models;

namespace TheOnlineBookStore.Services
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        void RemoveCategory(Category category);
        void UpdateCategory(Category category);
        Task<Category> GetCategoryByIdAsync(int id);
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<bool> SaveChangesAsync();
    }
}
