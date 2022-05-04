using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Core.Models
{
    public class Instructor
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime DayOfBirth { get; set; }   

        [Required]
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
