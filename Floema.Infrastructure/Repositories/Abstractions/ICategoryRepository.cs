using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floema.Domain.Models;

namespace Floema.Infrastructure.Repositories.Abstractions
{
    public interface ICategoryRepository
    {
        Category Get(string id); 
        List<Category> All();
        bool Add(Category entity);

    }
}
