using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT_Dapper.Core.Models;

namespace YT_Dapper.Infrastructure.Data
{
    public class YT_DapperDbContext : DbContext
    {
        public YT_DapperDbContext(DbContextOptions<YT_DapperDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVariation> ProductVariations { get; set; }
    }
}
