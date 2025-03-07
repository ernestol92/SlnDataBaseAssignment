﻿using Data.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class StatusEntity : IEntity
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public ICollection<ProjectEntity> Projects { get; set; } = new List<ProjectEntity>();
}
