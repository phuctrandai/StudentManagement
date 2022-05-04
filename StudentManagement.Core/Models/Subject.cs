using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Core.Models
{
    public class Subject
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int NumberOfCredits { get; set; }

        public int Year { get; set; }

        public int Phase { get; set; }

        public string? InstructorID { get; set; }

        [Required]
        public virtual Instructor Instructor { get; set; }
    }
}
