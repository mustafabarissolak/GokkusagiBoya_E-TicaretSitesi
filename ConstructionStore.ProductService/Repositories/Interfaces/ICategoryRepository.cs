using System.Collections.Generic;
using System.Threading.Tasks;
using ConstructionStore.ProductService.Entities;

namespace ConstructionStore.ProductService.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();  // Tüm kategorileri almak için
        Task<Category> GetCategoryByIdAsync(int id);         // Kategoriyi ID'sine göre almak için
        Task AddCategoryAsync(Category category);             // Yeni kategori eklemek için
        Task UpdateCategoryAsync(Category category);          // Var olan kategoriyi güncellemek için
        Task DeleteCategoryAsync(int id);                     // Kategoriyi ID'sine göre silmek için
    }
}
