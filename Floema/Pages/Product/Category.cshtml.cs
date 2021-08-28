using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Floema.Domain.DTO;
using Floema.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Floema.Pages.Product
{
    public class CategoryModel : PageModel
    {
        private readonly IProductServices _productServices;

        public IEnumerable<FeaturedProduct> Items { get; set; }
        public CategoryModel(IProductServices productServices)
        {
            _productServices = productServices;
        }
        public void OnGet(string id)
        {
            Items = _productServices.GetFeaturedProducts().Where(x => x.Category == id);
        }
    }
}
