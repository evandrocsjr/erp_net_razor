using System.ComponentModel.DataAnnotations;

namespace erp_net_blazor.Models
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}
