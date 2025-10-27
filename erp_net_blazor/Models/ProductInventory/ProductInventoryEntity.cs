using System.ComponentModel.DataAnnotations;

namespace erp_net_blazor.Models.ProductInventory
{
    public class ProductInventoryEntity : BaseEntity
    {
        [Required]
        public long Quantity { get; set; } = 0;

        [Required]
        public long MinimumQuantity { get; set; } = 0;

        [Required]
        public long MaximumQuantity { get; set; } = 0;
    }
}
