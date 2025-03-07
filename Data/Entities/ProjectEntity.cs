using Data.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class ProjectEntity : IEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; private set; }


    [MaxLength(100)]
    public string ProjectName { get; set; } = null!;

    
    [Required]
    public DateTime StartDate { get; set; }

    
    [Required]
    public DateTime EndDate { get; set; } 

    
    [Required]
    public int ProjectManagerId { get; set; }
    [ForeignKey(nameof(ProjectManagerId))]
    public EmployeeEntity Employee { get; set; } = null!;

    [Required]
    public int CustomerId { get; set; }
    [ForeignKey(nameof(CustomerId))]
    public CustomerEntity Customer { get; set; } = null!;

    
    [Required]
    public int ServiceId { get; set; }
    [ForeignKey(nameof(ServiceId))]
    public ServiceEntity Service { get; set; } = null!;

    [Required]
    public int PaymentId { get; set; }
    [ForeignKey(nameof(PaymentId))]
    public PaymentEntity Payment { get; set; } = null!;

    [Required]
    public int StatusId { get; set; }
    [ForeignKey(nameof(StatusId))]
    public StatusEntity Status { get; set; } = null!;

    }
