using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_Dapper.Infrastructure.Data
{
    public class YT_DapperDbContextFactory : IDesignTimeDbContextFactory<YT_DapperDbContext>
    {
        public YT_DapperDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<YT_DapperDbContext>();
            optionsBuilder
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=YTDapperDB;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new YT_DapperDbContext(optionsBuilder.Options);
        }
    }
}
