using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT_Dapper.Core.DTOs.Products;

namespace YT_Dapper.Core.Interfaces.Services
{
    public interface IProductService
    {
        Task<ICollection<ProductForRead>> RetrieveProducts();
    }
}
