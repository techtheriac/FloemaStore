using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Floema.Domain.DTO;
using Floema.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Floema.Pages.Product
{
    public class AllModel : PageModel
    {
        
        private readonly IProductServices _productServices;
        public IEnumerable<FeaturedProduct> Items { get; private set; }

        public AllModel(IProductServices productServices)
        {
            _productServices = productServices;
        }

        public void OnGet()
        {
            Items = _productServices.GetFeaturedProducts();
        }
    }
}
