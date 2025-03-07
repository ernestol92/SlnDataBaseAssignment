using Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class PaymentEntity : IEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required, Column(TypeName = "decimal(18,2)")]
    public decimal PaymentAmount { get; set; }

    [Required]
    public DateTime PaymentDate { get; set; }

    [Required]
    public string PaymentMethod { get; set; } = null!;

    [Required]
    public int PaymentStatusId { get; set; }
    [ForeignKey(nameof(PaymentStatusId))]
    public PaymentStatusEntity PaymentStatus { get; set; } = null!;



}
