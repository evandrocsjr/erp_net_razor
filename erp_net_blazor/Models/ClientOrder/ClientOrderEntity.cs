using System.ComponentModel.DataAnnotations;

namespace erp_net_blazor.Models.ClientOrder
{
    public class ClientOrderEntity : BaseEntity
    {
        [Required]
        [MaxLength(96)]
        public string Name { get; set; } = string.Empty;

    }
}
