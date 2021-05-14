using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blashop.Shared;

namespace blashop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
            {
                new Category { Id = 1, Name = "Salads", Url = "salads", Icon = "salad" },
                new Category { Id = 2, Name = "Seafood", Url = "seafood", Icon = "shrimp" },
                new Category { Id = 3, Name = "Fish", Url = "fish", Icon = "fish" }
            };

        public async Task<List<Category>> GetCategories()
        {

            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
