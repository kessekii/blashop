using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using blashop.Shared;

namespace blashop.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductByCategory(string categoryUrl);
        Task<Product> GetProduct(int id);
    }
}
