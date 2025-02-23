using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class CustomerEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int Id { get; set; }

    [Required ,MaxLength(100)]
    public string BusinessName { get; set; } = null!;

    [Required, MaxLength(100)]
    public string ContactPerson { get; set; } = null!;

    [Required, MaxLength(100), EmailAddress]
    public string Email { get; set; } = null!;

    public ICollection<ProjectEntity> Projects { get; set; } = new List<ProjectEntity>();

}
