using System;
using System.Collections.Generic;
using blashop.Shared;

namespace blashop.Client.Services.ProductService
{
    interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
