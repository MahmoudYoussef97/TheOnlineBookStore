using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheOnlineBookStore.Data;
using TheOnlineBookStore.Models;

namespace TheOnlineBookStore.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }
        public void AddCategory(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            _context.Categories.Add(category);
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();
            return categories;
        }

        public Task<Category> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
