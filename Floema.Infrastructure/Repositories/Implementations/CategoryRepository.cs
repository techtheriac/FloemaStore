using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Floema.Domain.Models;
using Floema.Infrastructure.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Floema.Infrastructure.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Category Get(string id)
        {
            return _context.Categories.Single(x => x.CategoryId == id);
        }

        public List<Category> All()
        {
            return _context.Categories.ToList();
        }

        public bool Add(Category entity)
        {
             _context.Categories.Add(entity);
            return true;
        }
    }
}
