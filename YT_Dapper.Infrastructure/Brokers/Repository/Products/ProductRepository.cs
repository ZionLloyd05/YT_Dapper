using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT_Dapper.Core.Interfaces;
using YT_Dapper.Core.Models;
using YT_Dapper.Infrastructure.Data;

namespace YT_Dapper.Infrastructure.Brokers.Repository.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly YT_DapperConnection dbConnection;

        public ProductRepository(YT_DapperConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public async Task<ICollection<Product>> GetProducts()
        {
            var query = $@"SELECT prod.Id, prod.Name, prod.Price, prod.IsAvailable, prod.HasVariation, prod.CreatedAt,
                         prodVar.Id as prodVarId, prodVar.Title, prodVar.Value, prodVar.Price, prodVar.CreatedAt, prodVar.productId
                         FROM [dbo].[Products] as prod LEFT JOIN [dbo].[ProductVariations] as prodVar ON prod.Id = prodVar.productId";

            var productDictionary = new Dictionary<int, Product>();

            using(var dbConnection = this.dbConnection.CreateConnection())
            {
                IEnumerable<Product> result = await dbConnection.QueryAsync<Product, ProductVariation, Product>(query, (prod, productVar) =>
                {
                    Product product;
                    if(!productDictionary.TryGetValue(prod.Id, out product))
                    {
                        product = prod;
                        product.ProductVariations = new List<ProductVariation>();
                        productDictionary.Add(prod.Id, product);
                    }
                    if (productVar.ProductId > 0) product.ProductVariations.Add(productVar);
                    return product;
                }, splitOn: "prodVarId");

                var products = result.Distinct().ToList();

                return products;
            }
        }
    }
}
