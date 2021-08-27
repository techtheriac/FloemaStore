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
    public class IndexModel : PageModel
    {
        private readonly ILogger<Pages.IndexModel> _logger;


        private readonly IProductServices _productServices;
        public FeaturedProduct Item { get; private set; }

        public string Id { get; set; }

        public IndexModel(ILogger<Pages.IndexModel> logger,
            IProductServices productServices)
        {
            _logger = logger;
            _productServices = productServices;

        }
        public void OnGet(string id)
        {
            Item = _productServices.GetProduct(id);
        }
    }
}
