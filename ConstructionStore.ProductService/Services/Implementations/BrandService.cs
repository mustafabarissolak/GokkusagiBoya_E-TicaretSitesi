using ConstructionStore.ProductService.Entities;
using ConstructionStore.ProductService.Repositories.Interfaces;
using ConstructionStore.ProductService.Services.Interfaces;

namespace ConstructionStore.ProductService.Services.Implementations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<IEnumerable<Brand>> GetAllBrandsAsync()
        {
            return await _brandRepository.GetAllBrandsAsync();
        }

        public async Task<Brand> GetBrandByIdAsync(int id)
        {
            return await _brandRepository.GetBrandByIdAsync(id);
        }

        public async Task AddBrandAsync(Brand brand)
        {
            await _brandRepository.AddBrandAsync(brand);
        }

        public async Task UpdateBrandAsync(Brand brand)
        {
            await _brandRepository.UpdateBrandAsync(brand);
        }

        public async Task DeleteBrandAsync(int id)
        {
            await _brandRepository.DeleteBrandAsync(id);
        }
    }
}
