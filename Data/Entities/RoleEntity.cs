using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Data.Entities;

public class RoleEntity 
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string RoleName { get; set; } = null!;
    public ICollection<EmployeeEntity> Employees { get; set; } = new List<EmployeeEntity>();

}



