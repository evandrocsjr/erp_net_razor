using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace erp_net_blazor.Models.ProductFinancial
{
    public class ProductFinancialEntity : BaseEntity
    {
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } = 0;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; } = 0;
    }
}
