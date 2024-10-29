using CRUDwithRepositoryServiceControllerModelLayers.Models;
using CRUDwithRepositoryServiceControllerModelLayers.Models.Entities;
using CRUDwithRepositoryServiceControllerModelLayers.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDwithRepositoryServiceControllerModelLayers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            var products = await productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<ActionResult<Product>> GetProductById(Guid id)
        {
            var product = await productService.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(AddProductDto addProductDto)
        {
            await productService.AddProduct(addProductDto);
            return Ok(addProductDto);
        }

        [HttpPut]
        [Route("{id:guid}")]

        public async Task<ActionResult> UpdateProduct(UpdateProductDto updateProductDto, Guid id)
        {
            await productService.UpdateProduct(updateProductDto, id);
            return Ok(updateProductDto);
        }

        [HttpDelete]
        [Route("{id:guid}")]

        public async Task<ActionResult> DeleteProductById(Guid id)
        {
            await productService.DeleteProductById(id);
            return Ok();
        }

    }
}
