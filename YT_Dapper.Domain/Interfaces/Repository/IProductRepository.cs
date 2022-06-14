using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT_Dapper.Core.Models;

namespace YT_Dapper.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<ICollection<Product>> GetProducts();
    }
}
