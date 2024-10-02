using System.Collections.Generic;
using System.Threading.Tasks;
using ConstructionStore.ProductService.Entities;

namespace ConstructionStore.ProductService.Repositories.Interfaces
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetAllBrandsAsync();  // Tüm markaları almak için
        Task<Brand> GetBrandByIdAsync(int id);         // Markayı ID'sine göre almak için
        Task AddBrandAsync(Brand brand);                // Yeni marka eklemek için
        Task UpdateBrandAsync(Brand brand);             // Var olan markayı güncellemek için
        Task DeleteBrandAsync(int id);                  // Markayı ID'sine göre silmek için
    }
}
