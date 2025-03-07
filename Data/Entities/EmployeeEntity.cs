
using Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class EmployeeEntity : IEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = null!;
    [Required]
    public string LastName { get; set; } = null!;
    [Required, EmailAddress]
    public string Email { get; set; } = null!;
    [Required]
    public string PhoneNumber { get; set; } = null!;

    [Required]
    public int RoleId {  get; set; }
    [ForeignKey(nameof(RoleId))]
    public RoleEntity Role { get; set; } = null!;

    public ICollection<ProjectEntity> Projects { get; set; } = new List<ProjectEntity>();

}
