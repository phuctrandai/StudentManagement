using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Core.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        [Required]
        public int? ClassId { get; set; }

        [Required]
        public virtual Class Class { get; set; }
    }
}
