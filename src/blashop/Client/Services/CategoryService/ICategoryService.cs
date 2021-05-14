using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using blashop.Shared;

namespace blashop.Client.Services.CategoryService
{
    interface ICategoryService
    {
        public List<Category> Categories { get; set; }

        Task LoadCategories();
    }
}
