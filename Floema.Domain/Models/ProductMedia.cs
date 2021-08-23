using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floema.Domain.Models
{
    public class ProductMedia
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
