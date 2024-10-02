using System.Collections.Generic;
using System.Threading.Tasks;
using ConstructionStore.ProductService.Entities;
using ConstructionStore.ProductService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionStore.ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetAllBrands()
        {
            var brands = await _brandService.GetAllBrandsAsync();
            return Ok(brands);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrandById(int id)
        {
            var brand = await _brandService.GetBrandByIdAsync(id);
            if (brand == null)
                return NotFound();
            return Ok(brand);
        }

        [HttpPost]
        public async Task<ActionResult> AddBrand(Brand brand)
        {
            await _brandService.AddBrandAsync(brand);
            return CreatedAtAction(nameof(GetBrandById), new { id = brand.Id }, brand);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBrand(int id, Brand brand)
        {
            if (id != brand.Id)
                return BadRequest();
            await _brandService.UpdateBrandAsync(brand);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBrand(int id)
        {
            await _brandService.DeleteBrandAsync(id);
            return NoContent();
        }
    }
}
