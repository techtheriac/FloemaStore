using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floema.Domain.Models
{
    public class Category
    {
        [Key]
        [Column(TypeName = "text")]
        public string CategoryId { get; set; }

        [Column(TypeName = "text")]
        public string CategoryName { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
