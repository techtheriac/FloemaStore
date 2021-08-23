using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floema.Infrastructure.Repositories.Abstractions;

namespace Floema.Infrastructure.Repositories.Implementations
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public virtual T Get(string id)
        {
            return default(T);
        }

        public virtual IEnumerable<T> All()
        {
            return new List<T>();
        }
    }
}
