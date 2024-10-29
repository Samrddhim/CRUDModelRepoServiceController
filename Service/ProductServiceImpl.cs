using CRUDwithRepositoryServiceControllerModelLayers.Models;
using CRUDwithRepositoryServiceControllerModelLayers.Models.Entities;
using CRUDwithRepositoryServiceControllerModelLayers.Repository;

namespace CRUDwithRepositoryServiceControllerModelLayers.Service
{
    public class ProductServiceImpl : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductServiceImpl(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task AddProduct(AddProductDto addProductDto)
        {
            await productRepository.AddProduct(addProductDto);
        }

        public async Task DeleteProductById(Guid id)
        {
            await productRepository.DeleteProductById(id);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
           return await productRepository.GetAllProductsAsync();
        }

        public Task<Product?> GetProductById(Guid id)
        {
            return productRepository.GetProductById(id);
        }

        public async Task UpdateProduct(UpdateProductDto updateProductDto, Guid id)
        {
            await productRepository.UpdateProduct(updateProductDto, id);
        }
    }
}
