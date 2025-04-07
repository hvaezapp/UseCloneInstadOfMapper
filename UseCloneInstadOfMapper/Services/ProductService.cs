using System.Collections.Immutable;
using UseCloneInstadOfMapper.Dtos.Product;
using UseCloneInstadOfMapper.Entities;

namespace UseCloneInstadOfMapper.Services
{
    public sealed class ProductService
    {
        public IEnumerable<GetProductDto?> GetAllProduct()
        {
            return Product.GetAll().Select(a => a.Clone() as GetProductDto);
        }
    }
}
