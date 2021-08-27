using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Floema.Domain.DTO;
using Floema.Domain.Models;
using Floema.Infrastructure.Repositories.Abstractions;
using Floema.Services.Abstractions;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;

namespace Floema.Services.Implementations
{
    public class ProductServices : IProductServices
    {
        // Ascertain featured products

        // Choose Items to show on different blocks of Homepage

        private readonly IProductRepository _productRepository;
        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public List<FeaturedProduct> GetFeaturedProducts()
        {
            return _productRepository.GetFeaturedProducts();
        }
    }
}
