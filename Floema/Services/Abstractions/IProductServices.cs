using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Floema.Domain.DTO;
using Floema.Domain.Models;

namespace Floema.Services.Abstractions
{
    public interface IProductServices
    {
        List<FeaturedProduct> GetFeaturedProducts();
    }
}
