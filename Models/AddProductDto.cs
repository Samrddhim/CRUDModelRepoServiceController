namespace CRUDwithRepositoryServiceControllerModelLayers.Models
{
    public class AddProductDto
    {
        public required string ProductName { get; set; }
        public int? Price { get; set; }
        public required string ProductCategory { get; set; }
    }
}
