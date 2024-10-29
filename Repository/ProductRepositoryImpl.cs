using CRUDwithRepositoryServiceControllerModelLayers.Data;
using CRUDwithRepositoryServiceControllerModelLayers.Models;
using CRUDwithRepositoryServiceControllerModelLayers.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDwithRepositoryServiceControllerModelLayers.Repository
{
    public class ProductRepositoryImpl : IProductRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ProductRepositoryImpl(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task AddProduct(AddProductDto addProductDto)
        {
            var productEntity = new Product()
            {
                ProductName = addProductDto.ProductName,
                ProductCategory = addProductDto.ProductCategory,
                Price = addProductDto.Price
            };
            await applicationDbContext.Products.AddAsync(productEntity);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteProductById(Guid id)
        {
            var product = await applicationDbContext.Products.FindAsync(id);

            if (product != null)
            {
                applicationDbContext.Products.Remove(product);
                await applicationDbContext.SaveChangesAsync();

            }
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await applicationDbContext.Products.ToListAsync();
        }

        public async Task<Product?> GetProductById(Guid id)
        {
            var product =  await applicationDbContext.Products.FindAsync(id);
            return(product);
        }

        public async Task UpdateProduct(UpdateProductDto updateProductDto, Guid id)
        {
            var productToUpdate = await applicationDbContext.Products.FindAsync(id);
            if (productToUpdate != null)
            {
                productToUpdate.ProductName = updateProductDto.ProductName;
                productToUpdate.ProductCategory = updateProductDto.ProductCategory;
                productToUpdate.Price = updateProductDto.Price;

                await applicationDbContext.SaveChangesAsync();
            }

            else
            {
                throw new Exception("Product not Found");
            }

        }
    }
}
