using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using YT_Dapper.Core.DTOs.Products;
using YT_Dapper.Core.Interfaces;
using YT_Dapper.Core.Interfaces.Services;

namespace YT_Dapper.API.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper map;

        public ProductService(IProductRepository productRepository, IMapper map)
        {
            this.productRepository = productRepository;
            this.map = map;
        }
        public async Task<ICollection<ProductForRead>> RetrieveProducts()
        {
            var products = await this.productRepository.GetProducts();

            var productsForRead = this.map.Map<ICollection<ProductForRead>>(products);

            return productsForRead;
        }
    }
}
