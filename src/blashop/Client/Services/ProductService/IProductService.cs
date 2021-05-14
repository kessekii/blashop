using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using blashop.Shared;

namespace blashop.Client.Services.ProductService
{
    interface IProductService
    {
        event Action OnChange;

        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl = null);
        Task<Product> GetProduct(int id);
    }
}
