using Floema.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floema.Infrastructure.Repositories.Abstractions
{
    public interface IProductRepository
    {
        IDictionary<string, Product> GetProductsByCategory();
    }
}
