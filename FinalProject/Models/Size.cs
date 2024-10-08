﻿using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        [Required]
        [StringLength(50)]
        public string? SizeName { get; set; }
    }
}
