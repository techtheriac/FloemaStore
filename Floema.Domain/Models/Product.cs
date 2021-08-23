using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floema.Domain.Models
{ 
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductMedia> ProductMedias { get; set; }
    }
}
