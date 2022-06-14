using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT_Dapper.Core.Models;

namespace YT_Dapper.Core.DTOs.Products
{
    public class ProductForRead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<ProductVariation> ProductVariations { get; set; }
    }
}
