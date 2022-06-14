using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_Dapper.Core.Models
{
    public class ProductVariation
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
