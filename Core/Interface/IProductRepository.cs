using System.Collections.Generic;
using System.Threading.Tasks;
using CoreEntities;

namespace Core.Interface
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsyn(int id);
        Task<IReadOnlyList<Product>> GetProductAsyn();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsyn();

        Task<IReadOnlyList<ProductType>> GetProductTypesAsyn();

    }
}