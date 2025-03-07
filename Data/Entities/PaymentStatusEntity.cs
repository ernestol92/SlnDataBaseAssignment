
using Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class PaymentStatusEntity : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string PaymentStatus { get; set; } = null!;
        
        public ICollection<PaymentEntity> Payments { get; set; } = new List<PaymentEntity>();

    }
}
