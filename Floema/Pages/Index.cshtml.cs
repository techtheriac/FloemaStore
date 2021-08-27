using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Floema.Domain.DTO;
using Floema.Infrastructure.Repositories.Abstractions;
using Floema.Domain.Models;
using Floema.Services.Abstractions;

namespace Floema.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        private readonly IProductServices _productServices;
        public IEnumerable<FeaturedProduct> Items { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            IProductServices productServices)
        {
            _logger = logger;
            _productServices = productServices;

        }

        public void OnGet()
        {
            Items = _productServices.GetFeaturedProducts();
        }
    }
}
