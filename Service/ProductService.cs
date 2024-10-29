using CRUDwithRepositoryServiceControllerModelLayers.Models;
using CRUDwithRepositoryServiceControllerModelLayers.Models.Entities;

namespace CRUDwithRepositoryServiceControllerModelLayers.Service
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product?> GetProductById(Guid id);

        Task AddProduct(AddProductDto addProductDto);
        Task DeleteProductById(Guid id);
        Task UpdateProduct(UpdateProductDto updateProductDto, Guid id);
    }
}
