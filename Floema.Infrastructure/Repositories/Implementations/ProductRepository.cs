using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floema.Domain.DTO;
using Floema.Domain.Models;
using Floema.Infrastructure.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Floema.Infrastructure.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<IGrouping<string, Product>> GetProductsByCategory()
        {
            var res = _context.Products.GroupBy(product => product.Category.CategoryName);
            return res;
        }

        public Product Get(string id)
        {
            return _context.Products.Single(a => a.ProductId == id);
        }

        public IEnumerable<Product> All()
        {
            return _context.Products.ToList();
        }

        public List<FeaturedProduct> GetFeaturedProducts()
        {
            var featuredProducts = _context.Products
                .Include(c => c.ProductMedias)
                .Select(c => new FeaturedProduct()
                {
                    Id = c.ProductId,
                    ProductName = c.ProductName,
                    Category = c.Category.CategoryName,
                    Photos = c.ProductMedias.Select(x => x.Url).ToList(),
                    Price = c.Price,
                    ProductDescription = c.ProductDescription
                });

            return featuredProducts.ToList();
        }

        public bool Add(Product entity)
        {
            _context.Products.Add(entity);
            return true;
        }
    }
}
