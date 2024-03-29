﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities
{
    [Table("categories")]
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
