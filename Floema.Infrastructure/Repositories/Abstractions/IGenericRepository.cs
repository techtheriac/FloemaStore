using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floema.Infrastructure.Repositories.Abstractions
{
    public interface IGenericRepository<T>
    {
        T Get(string id);
        IEnumerable<T> All();
    }
}
