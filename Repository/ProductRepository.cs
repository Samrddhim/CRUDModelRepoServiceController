using CRUDwithRepositoryServiceControllerModelLayers.Models;
using CRUDwithRepositoryServiceControllerModelLayers.Models.Entities;

namespace CRUDwithRepositoryServiceControllerModelLayers.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductById(Guid id);

        Task AddProduct(AddProductDto addProductDto);
        Task UpdateProduct(UpdateProductDto updateProductDto, Guid id);

        Task DeleteProductById(Guid id);
    }
}
