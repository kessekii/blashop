using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blashop.Server.Services.ProductService;
using blashop.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blashop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]

        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await _productService.GetAllProducts());
        }

        [HttpGet("Category/{categoryUrl}")]

        public async Task<ActionResult<List<Product>>> GetProductByCategory(string categoryUrl)
        {
            return Ok(await _productService.GetProductByCategory(categoryUrl));
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<List<Product>>> GetProduct(int id)
        {
            return Ok(await _productService.GetProduct(id));
        }
    }
}
