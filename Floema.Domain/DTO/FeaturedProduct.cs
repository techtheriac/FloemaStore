using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floema.Domain.Models;

namespace Floema.Domain.DTO
{
    public class FeaturedProduct
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }

        public string Category;
        public List<string> Photos { get; set; }
    }
}
