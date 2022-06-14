using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT_Dapper.Core.DTOs.Products;
using YT_Dapper.Core.Models;

namespace YT_Dapper.Core.Utils
{
    public class YT_DapperProfile : Profile
    {
        public YT_DapperProfile()
        {
            CreateMap<Product, ProductForRead>();
        }
    }
}
