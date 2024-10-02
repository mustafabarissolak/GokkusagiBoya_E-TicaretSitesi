using System.Collections.Generic;
using System.Threading.Tasks;
using ConstructionStore.ProductService.Entities;

namespace ConstructionStore.ProductService.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();  // Tüm ürünleri almak için
        Task<Product> GetProductByIdAsync(int id);         // Ürünü ID'sine göre almak için
        Task AddProductAsync(Product product);              // Yeni ürün eklemek için
        Task UpdateProductAsync(Product product);           // Var olan ürünü güncellemek için
        Task DeleteProductAsync(int id);                    // Ürünü ID'sine göre silmek için
    }
}
