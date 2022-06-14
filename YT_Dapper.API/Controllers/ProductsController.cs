using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YT_Dapper.Core.Interfaces.Services;

namespace YT_Dapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> RetrieveAllProduct()
        {
            var products = await this.productService.RetrieveProducts();

            return Ok(products);
        }
    }
}
