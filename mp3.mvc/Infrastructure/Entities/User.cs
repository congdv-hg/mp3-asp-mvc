﻿using mp3.mvc.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mp3.mvc.Infrastructure.Entities
{
    [Table("users")]
    public class User : BaseEntity
    {
        public string? Username { get; set; }
        [Display(Name ="Tên hiển thị")]
        public string? DisplayName { get; set; }
        public string? AvatarUrl { get; set; }
        public int Gender { get; set; }
        public DateTime Dob { get; set; }   
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public bool IsLocked { get; set; } = false;
        public bool IsAdmin { get; set; } = false;
        public decimal Balance { get; set; } = 0;

    }
}
