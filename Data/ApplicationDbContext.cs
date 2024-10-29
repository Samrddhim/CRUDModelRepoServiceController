using CRUDwithRepositoryServiceControllerModelLayers.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDwithRepositoryServiceControllerModelLayers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
