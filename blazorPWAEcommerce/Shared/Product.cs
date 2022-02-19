using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazorPWAEcommerce.Shared
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
       
        [Column(TypeName= "decimal(18,2)")]
        public decimal ProductPrice { get; set; }
        public string ProductUrl { get; set; } = string.Empty;
    }
}
