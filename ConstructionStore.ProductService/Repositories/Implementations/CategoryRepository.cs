using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructionStore.ProductService.Data;
using ConstructionStore.ProductService.Entities;
using ConstructionStore.ProductService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConstructionStore.ProductService.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductDbContext _context;

        public CategoryRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync() => await _context.Categories.ToListAsync();

        public async Task<Category> GetCategoryByIdAsync(int id) => await _context.Categories.FindAsync(id);

        public async Task AddCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
