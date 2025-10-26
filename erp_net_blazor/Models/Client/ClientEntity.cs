using System.ComponentModel.DataAnnotations;

namespace erp_net_blazor.Models.Client
{
    public class ClientEntity : BaseEntity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
    }
}
