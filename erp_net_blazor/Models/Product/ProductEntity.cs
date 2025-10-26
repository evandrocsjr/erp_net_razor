using System.ComponentModel.DataAnnotations;

namespace erp_net_blazor.Models.Product
{
    public class ProductEntity : BaseEntity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(96)]
        public string Name { get; set; } = string.Empty;

    }
}
