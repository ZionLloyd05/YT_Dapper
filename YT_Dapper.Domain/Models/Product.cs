using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_Dapper.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public bool HasVariation { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<ProductVariation> ProductVariations { get; set; }
    }
}
