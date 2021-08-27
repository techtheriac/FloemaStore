using Floema.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floema.Domain.DTO;

namespace Floema.Infrastructure.Repositories.Abstractions
{
    public interface IProductRepository
    {
        IEnumerable<IGrouping<string, Product>> GetProductsByCategory();
        Product Get(string id);
        IEnumerable<Product> All();
        bool Add(Product entity);
        List<FeaturedProduct> GetFeaturedProducts();
    }
}
