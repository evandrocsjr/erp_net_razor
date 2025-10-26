using System.ComponentModel.DataAnnotations;

namespace erp_net_blazor.Models.ClientOrder
{
    public class ClientOrderEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

    }
}
