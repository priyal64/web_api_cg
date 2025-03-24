using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SubManagement.Models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TopicName { get; set; }

        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public List<SubTopic> Subtopics { get; set; } = new List<SubTopic>();
    }
}