﻿using System.ComponentModel.DataAnnotations;

namespace TestApi.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
