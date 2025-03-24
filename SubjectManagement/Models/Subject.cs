using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SubManagement.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SubjectName { get; set; }

        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
}