using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interface;
using CoreEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductByIdAsyn(int id)
        {
           return await _context.Products
           .Include(p=>p.ProductType)
            .Include(p=>p.ProductBrand)
            .FirstOrDefaultAsync(p=>p.Id==id);
        }
        public async Task<IReadOnlyList<Product>> GetProductAsyn()
        {
            return await _context.Products.Include(p=>p.ProductType)
            .Include(p=>p.ProductBrand)
            .ToListAsync();
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsyn()
        {
           return  await _context.ProductBrands.ToListAsync(); 
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsyn()
        {
          return await _context.ProductTypes.ToListAsync();
        }
    }
}