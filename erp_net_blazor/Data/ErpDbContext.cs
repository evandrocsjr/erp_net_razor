using erp_net_blazor.Models.Client;
using erp_net_blazor.Models.ClientOrder;
using erp_net_blazor.Models.Product;
using erp_net_blazor.Models.ProductFinancial;
using erp_net_blazor.Models.ProductInventory;
using Microsoft.EntityFrameworkCore;

namespace erp_net_blazor.Data
{
    public class ErpDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        private DbSet<ProductInventoryEntity> ProductInventories { get; set; }

        private DbSet<ProductFinancialEntity> ProductFinancials { get; set; }

        private DbSet<ClientEntity> Clients { get; set; }

        private DbSet<ClientOrderEntity> ClientOrders { get; set; }

        private DbSet<ProductEntity> Products { get; set; }
    }
}
