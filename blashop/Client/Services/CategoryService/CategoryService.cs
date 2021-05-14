using System;
using System.Collections.Generic;
using blashop.Shared;

namespace blashop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public CategoryService()
        {
        }

        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category { Id = 1, Name = "Salads", Url = "salads", Icon = "salad" },
                new Category { Id = 2, Name = "Seafood", Url = "seafood", Icon = "shrimp" },
                new Category { Id = 3, Name = "Fish", Url = "fish", Icon = "fish" }
            };
        }
    }
}
