using Catalog.API.Data;
using Catalog.API.Entities;

namespace Catalog.API.Repository
{
    public class ProductRepository : IProductRepository
    {
        readonly ICatalogContext _context;
        public ProductRepository(ICatalogContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProduct(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }
        public async Task CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
