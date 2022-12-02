﻿using System.ComponentModel.DataAnnotations;

namespace MYEmployeePortal_OnVM.Models
{
    public class Employee
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        public decimal? Salary { get; set; }
    }
}
