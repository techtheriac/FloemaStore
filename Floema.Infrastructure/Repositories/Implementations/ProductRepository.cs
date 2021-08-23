using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floema.Domain.Models;
using Floema.Infrastructure.Repositories.Abstractions;

namespace Floema.Infrastructure.Repositories.Implementations
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public IDictionary<string, Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }
    }
}
