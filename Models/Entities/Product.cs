using System.ComponentModel.DataAnnotations;

namespace CRUDwithRepositoryServiceControllerModelLayers.Models.Entities
{
    public class Product
    {
      
        public Guid Id { get; set; }
        public required string ProductName { get; set; }
        public int? Price { get; set; }
        public required string ProductCategory { get; set; }
    }
}
