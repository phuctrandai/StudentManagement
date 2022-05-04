using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Domain.Models
{
    public class Class
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public virtual ICollection<Student> Students { get; set; }
    }
}
