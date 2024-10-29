namespace CRUDwithRepositoryServiceControllerModelLayers.Models
{
    public class UpdateProductDto
    {
        public required string ProductName { get; set; }
        public int? Price { get; set; }
        public required string ProductCategory { get; set; }
    }
}
