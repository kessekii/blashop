using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using blashop.Shared;

namespace blashop.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryUrl);
    }


}
