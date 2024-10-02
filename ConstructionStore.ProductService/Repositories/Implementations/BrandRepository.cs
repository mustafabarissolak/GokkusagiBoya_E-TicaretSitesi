using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructionStore.ProductService.Data;
using ConstructionStore.ProductService.Entities;
using ConstructionStore.ProductService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConstructionStore.ProductService.Repositories.Implementations
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ProductDbContext _context;

        public BrandRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Brand>> GetAllBrandsAsync() => await _context.Brands.ToListAsync();

        public async Task<Brand> GetBrandByIdAsync(int id) => await _context.Brands.FindAsync(id);

        public async Task AddBrandAsync(Brand brand)
        {
            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBrandAsync(Brand brand)
        {
            _context.Brands.Update(brand);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBrandAsync(int id)
        {
            var brand = await _context.Brands.FindAsync(id);
            if (brand != null)
            {
                _context.Brands.Remove(brand);
                await _context.SaveChangesAsync();
            }
        }
    }
}
